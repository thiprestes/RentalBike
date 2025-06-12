using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;
using RentalMotorcycle.Api.Configuration;
using RentalMotorcycle.Data;

namespace RentalMotorcycle.Api;

public class Startup (IConfiguration configuration)
{
    private IConfiguration Configuration { get; } = configuration;
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddHttpLogging(w => new HttpLoggingOptions());
        services.DependencyInjection(Configuration);
        services.AddSwaggerConfiguration();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DatabaseContext context)
    {
        app.UseRequestLocalization();
        context.Database.Migrate();
        
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseHttpLogging();
        app.UseApiConfiguration(env);
        app.UseSwaggerConfiguration();
    }
}