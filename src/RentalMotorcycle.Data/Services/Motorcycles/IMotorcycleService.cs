using RentalMotorcycle.Data.Services.Motorcycles.DTO;
namespace RentalMotorcycle.Data.Services;

public interface IMotorcycleService
{
    public Task<List<MotorcycleDTO>> ListAsync();
    public Task<MotorcycleDTO> PostMotorcycle(MotorcycleDTO motorcycle);
}