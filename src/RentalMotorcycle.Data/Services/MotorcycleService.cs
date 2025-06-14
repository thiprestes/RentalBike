using RentalMotorcycle.Data.Repositories.Motorcycles;
using RentalMotorcycle.Data.Services.Motorcycles.DTO;
using RentalMotorcycle.Data.Services.Motorcycles.Mapper;

namespace RentalMotorcycle.Data.Services;

public class MotorcycleService(IMotorcycleRepository motorcycleRepository, IMotorcycleMapper motorcycleMapper) : IMotorcycleService
{
    public async Task<List<MotorcycleDTO>> ListAsync()
    {
        var ret =  await motorcycleRepository.GetAllAsync();
        return motorcycleMapper.Map(ret);
    }
}