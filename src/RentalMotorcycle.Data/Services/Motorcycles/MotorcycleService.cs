using RentalMotorcycle.Business.Entities.Motorcycles;
using RentalMotorcycle.Data.Repositories.Motorcycles;
using RentalMotorcycle.Data.Services.Motorcycles.DTO;
using RentalMotorcycle.Data.Services.Motorcycles.Mapper;

namespace RentalMotorcycle.Data.Services.Motorcycles;

public class MotorcycleService(IMotorcycleRepository motorcycleRepository, IMotorcycleMapper motorcycleMapper) : IMotorcycleService
{
    public async Task<List<MotorcycleDTO>> ListAsync()
    {
        var ret = await motorcycleRepository.GetAllAsync();
        return motorcycleMapper.Map(ret);
    }

    public async Task<MotorcycleDTO> GetById(string id)
    {
        var ret = await motorcycleRepository.GetByIdAsync(id);
        if (ret == null)
        {
            return null;
        }
        return motorcycleMapper.Map(ret);
    }
    
    public async Task<bool> PostMotorcycle(MotorcycleDTO motorcycle)
    {
        try
        {
            await motorcycleRepository.AddAsync(motorcycleMapper.Map(motorcycle));
            await motorcycleRepository.SaveChangesAsync();
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }

    public async Task<bool> PutMotorcyclePlate(string id, string plate)
    {
        try
        {
           var ret = await motorcycleRepository.GetByIdAsync(id);
           if (ret == null)
           {
               return false;
           }
           ret.Placa = plate;
           await motorcycleRepository.SaveChangesAsync(); 
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }

    public async Task<bool> DeleteMotorcycle(string id)
    {
        var ret = await motorcycleRepository.GetByIdAsync(id);
        if (ret == null)
        {
            return false;
        }
        motorcycleRepository.Delete(ret);
        await motorcycleRepository.SaveChangesAsync();
        return true;
    }
}