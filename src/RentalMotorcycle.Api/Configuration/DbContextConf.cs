using Microsoft.EntityFrameworkCore;
using RentalMotorcycle.Data.Configuration;
using RentalMotorcycle.Data.Helper;

namespace RentalMotorcycle.Api.Configuration;

public static class DbContextConf
{
    public const string ConnectionStringNotFoundLog = "Não foi possível localizar conexão de destino.";
    
    public static IServiceCollection AddDbContextConf(this IServiceCollection services, IConfiguration configuration)
    {
        CreatePostgresSchemaIfNotExists(configuration, DbContextConfiguration.Schema);
        services.AddDbContextStocks(configuration);
        return services;
    }
    
    
    private static void CreatePostgresSchemaIfNotExists(IConfiguration configuration, string schema)
    {
        var connectionString = configuration.GetConnectionStringPostgres(schema);
        
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new Exception(ConnectionStringNotFoundLog);
        }
        var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
        optionsBuilder.UseNpgsql(connectionString);
        using var newContext = new DbContext(optionsBuilder.Options);
    }
}