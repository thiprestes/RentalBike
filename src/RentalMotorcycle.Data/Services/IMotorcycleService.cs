using RentalMotorcycle.Business.Entities.Motorcycle;
using RentalMotorcycle.Data.Services.Motorcycle.DTO;

namespace RentalMotorcycle.Data.Services.Motorcycle;

public interface IMotorcycleService
{
    public Task<List<MotorcycleDTO>> ListAsync();
}