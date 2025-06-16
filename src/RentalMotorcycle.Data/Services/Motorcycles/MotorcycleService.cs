using RentalMotorcycle.Data.Repositories.Motorcycles;
using RentalMotorcycle.Data.Services.Motorcycles.DTO;
using RentalMotorcycle.Data.Services.Motorcycles.Mapper;

namespace RentalMotorcycle.Data.Services.Motorcycles;

public class MotorcycleService(IMotorcycleRepository motorcycleRepository, IMotorcycleMapper motorcycleMapper) : IMotorcycleService
{
    public async Task<List<MotorcycleDTO>> ListAsync()
    {
        var ret =  await motorcycleRepository.GetAllAsync();
        return motorcycleMapper.Map(ret);
    }

    public async Task<MotorcycleDTO> GetById(string id)
    {
        var ret = await motorcycleRepository.GetByIdAsync(id);
        return motorcycleMapper.Map(ret);
    }
    
    public async Task<MotorcycleDTO> PostMotorcycle(MotorcycleDTO motorcycle)
    {
        await motorcycleRepository.AddAsync(motorcycleMapper.Map(motorcycle));
        await motorcycleRepository.SaveChangesAsync();
        return motorcycle;
    }
}