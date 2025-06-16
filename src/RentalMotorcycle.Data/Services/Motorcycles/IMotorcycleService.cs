using RentalMotorcycle.Data.Services.Motorcycles.DTO;

namespace RentalMotorcycle.Data.Services.Motorcycles;

public interface IMotorcycleService
{
    public Task<List<MotorcycleDTO>> ListAsync();
    public Task<MotorcycleDTO> GetById(string id);
    public Task<MotorcycleDTO> PostMotorcycle(MotorcycleDTO motorcycleDto);
}