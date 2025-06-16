using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RentalMotorcycle.Business.Entities.DeliveryMen;
using RentalMotorcycle.Business.Entities.Motorcycles;
using RentalMotorcycle.Business.Entities.Rental;
using RentalMotorcycle.Data.Configuration;

namespace RentalMotorcycle.Data
{
    public class DatabaseContext(DbContextOptions<DatabaseContext> options) : Microsoft.EntityFrameworkCore.DbContext(options)
    {
        public DbSet<Motorcycle> Motorcycle { get; set; }
        public DbSet<Rent> Rent { get; set; }
        public DbSet<DeliveryMan> DeliveryMan { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(DbContextConfiguration.Schema);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);    
            base.OnModelCreating(modelBuilder);
        }
    }
    public class ContextV3Factory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetSection("ConnectionStrings:Default").Value;

            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseNpgsql(connectionString,
                builder =>
                {
                    builder.UseQuerySplittingBehavior(QuerySplittingBehavior.SingleQuery);
                    builder.MigrationsHistoryTable(DbContextConfiguration.MigrationsHistoryTable, DbContextConfiguration.Schema);
                });

            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}