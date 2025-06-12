using RentalMotorcycle.business.Entities.Motorcycle;
using RentalMotorcycle.Data.Repositories.Motorcycle;
using RentalMotorcycle.Data.Services.Motorcycle.DTO;
using RentalMotorcycle.Data.Services.Motorcycle.Mapper;

namespace RentalMotorcycle.Data.Services.Motorcycle;

public class MotorcycleService(IMotorcycleRepository motorcycleRepository, IMotorcycleMapper motorcycleMapper) : IMotorcycleService
{
    public async Task<List<MotorcycleDTO>> ListAsync()
    {
        var ret =  await motorcycleRepository.GetAllAsync();
        return motorcycleMapper.Map(ret);
    }
}