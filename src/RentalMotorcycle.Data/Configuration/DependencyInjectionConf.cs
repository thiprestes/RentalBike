using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentalMotorcycle.Data.Repositories.DeliveryMen;
using RentalMotorcycle.Data.Repositories.Motorcycles;
using RentalMotorcycle.Data.Repositories.Rental;
using RentalMotorcycle.Data.Services;
using RentalMotorcycle.Data.Services.DeliveryMen.Mapper;
using RentalMotorcycle.Data.Services.Motorcycles.Mapper;
using RentalMotorcycle.Data.Services.Rental.Mapper;

namespace RentalMotorcycle.Data.Configuration;

public static class DependencyInjectionConf
{
    public static IServiceCollection DataDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IMotorcycleService, MotorcycleService>();
        services.AddScoped<IMotorcycleRepository, MotorcycleRepository>();
        services.AddScoped<IMotorcycleMapper, MotorcycleMapper>();
        
        services.AddScoped<IRentRepository, RentRepository>();
        services.AddScoped<IRentMapper, RentMapper>();
        
        services.AddScoped<IDeliveryManRepository, DeliveryManRepository>();
        services.AddScoped<IDeliveryManMapper, DeliveryManMapper>();
        
        return services;   
    }     
}