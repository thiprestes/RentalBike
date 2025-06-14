namespace RentalMotorcycle.Api;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args)
    {
        var builder = Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(w => {w.UseStartup<Startup>();});
        return builder;
    }
}