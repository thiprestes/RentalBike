using Microsoft.Extensions.DependencyInjection;
using RentalMotorcycle.Data.Repositories.Motorcycle;
using RentalMotorcycle.Data.Services.Motorcycle;
using RentalMotorcycle.Data.Services.Motorcycle.Mapper;

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