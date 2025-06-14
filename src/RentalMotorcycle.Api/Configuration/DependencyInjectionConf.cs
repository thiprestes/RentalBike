using RentalMotorcycle.Data.Configuration;
using RentalMotorcycle.Api.Mapper.DeliveryMen;
using RentalMotorcycle.Api.Mapper.Motorcycle;
using RentalMotorcycle.Api.Mapper.Rental;
using MotorcycleMapper = RentalMotorcycle.Api.Mapper.Motorcycle.MotorcycleMapper;
using RentMapper = RentalMotorcycle.Api.Mapper.Rental.RentMapper;
using DeliveryManMapper = RentalMotorcycle.Api.Mapper.DeliveryMen.DeliveryManMapper;

namespace RentalMotorcycle.Api.Configuration;

public static class DependencyInjectionConf
{
    public static IServiceCollection DependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddApiConfiguration(configuration);
        services.AddScoped<IMotorcycleMapper, MotorcycleMapper>();
        services.AddScoped<IRentMapper, RentMapper>();
        services.AddScoped<IDeliveryManMapper, DeliveryManMapper>();
        services.DataDependencies(configuration);
        return services;   
    } 
}