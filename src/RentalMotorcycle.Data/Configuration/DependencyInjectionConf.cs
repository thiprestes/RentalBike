using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentalMotorcycle.Data.Repositories.Motorcycles;
using RentalMotorcycle.Data.Services;
using RentalMotorcycle.Data.Services.Motorcycles.Mapper;

namespace RentalMotorcycle.Data.Configuration;

public static class DependencyInjectionConf
{
    public static IServiceCollection DataDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IMotorcycleService, MotorcycleService>();
        
        services.AddScoped<IMotorcycleRepository, MotorcycleRepository>();
        
        services.AddScoped<IMotorcycleMapper, MotorcycleMapper>();
        
        return services;   
    }     
}