using Microsoft.OpenApi.Models;
using RentalMotorcycle.Api.ViewModels.Motorcycle.Example;
using Swashbuckle.AspNetCore.Filters;

namespace RentalMotorcycle.Api.Configuration;

public static class SwaggerConf
{
    public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
    {
        services.AddSwaggerGen(w =>
        {
            w.UseInlineDefinitionsForEnums();
            w.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Projeto destinado para controle de locação de motocicleta",
                Description = "Projeto destinado para controle de locação de motocicletas por entregadores.",
                Contact = new OpenApiContact
                {
                    Name = "Thiago Prestes",
                    Email = "thiprestes_@hotmail.com",
                }
            });
            w.ExampleFilters();
        });
        services.AddSwaggerExamplesFromAssemblyOf<MotorcycleViewModelExample>();
        services.AddSwaggerExamplesFromAssemblyOf<ListMotorcycleViewModelExample>();
        return services;
    }

    public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(w => w.SwaggerEndpoint("/swagger/v1/swagger.json", "RentalMotorcycle.Api"));
        return app;    
    }
}