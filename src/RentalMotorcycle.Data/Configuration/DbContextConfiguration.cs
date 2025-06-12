using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentalMotorcycle.Data.Helper;

namespace RentalMotorcycle.Data.Configuration;

public static class DbContextConfiguration
{
    public const string Schema = "RentalMotorcycle";

    public const string MigrationsHistoryTable = "__EFMigrationsHistory";

    public static IServiceCollection AddDbContextStocks(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContextFactory<DatabaseContext>(w =>
        {
            w.UseNpgsql(configuration.GetConnectionStringPostgres(Schema), 
                builder =>
                {
                    builder.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                    builder.MigrationsHistoryTable(MigrationsHistoryTable, Schema);
                });
        });
        return services;    
    }    
}