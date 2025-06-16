using RentalMotorcycle.Business.Entities.Motorcycles;
using RentalMotorcycle.Data.Services.Motorcycles.DTO;

namespace RentalMotorcycle.Data.Services.Motorcycles.Mapper;

public interface IMotorcycleMapper
{
    MotorcycleDTO Map(Motorcycle motorcycle);
    Motorcycle Map(MotorcycleDTO motorcycleDto);
    List<MotorcycleDTO> Map(List<Motorcycle> listmotorcycle);
    List<MotorcycleDTO> Map(IEnumerable<Motorcycle> enummotorcycle);    
}