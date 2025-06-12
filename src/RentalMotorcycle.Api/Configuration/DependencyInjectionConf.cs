using RentalMotorcycle.Data.Configuration;
using RentalMotorcycle.Api.Mapper;

namespace RentalMotorcycle.Api.Configuration;

public static class DependencyInjectionConf
{
    public static IServiceCollection DependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddApiConfiguration(configuration);
        services.AddScoped<IMotorcycleMapper, MotorcycleMapper>();
        services.DataDependencies(configuration);
        return services;   
    } 
}