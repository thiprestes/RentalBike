using System.Globalization;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using RentalMotorcycle.Data;

namespace RentalMotorcycle.Api.Configuration;

public static class ApiConf
{
    public static void AddApiConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        var supportedCultures = new[]
        {
            new CultureInfo("pt-BR"),
            new CultureInfo("en-US"),
        };

        services.Configure<RequestLocalizationOptions>(w =>
        {
            w.SupportedCultures = supportedCultures;
            w.SupportedUICultures = supportedCultures;
        });

        services.AddLocalization();
        services.AddControllers();
        services.AddHealthChecks().AddDbContextCheck<DatabaseContext>();
        services.AddDbContextConf(configuration);
        services.AddMemoryCache();
        services.AddHttpContextAccessor();
        services.AddCors(w =>
        {
            w.AddPolicy("All", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
        });
    }

    public static IApplicationBuilder UseApiConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseHsts();
        }

        app.UseRouting();
        app.UseCors("All");
        app.UseEndpoints(w =>
        {
            w.MapHealthChecks("/health/startup");
            w.MapHealthChecks("/health/live", new HealthCheckOptions
            {
                Predicate = _ => true,
            });
            w.MapHealthChecks("/health/ready", new HealthCheckOptions
            {
                Predicate = _ => true,
            });
            w.MapControllers();
        });
        return app;
    }
}