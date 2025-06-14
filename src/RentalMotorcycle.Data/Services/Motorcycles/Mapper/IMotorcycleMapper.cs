using RentalMotorcycle.Business.Entities.Motorcycles;
using RentalMotorcycle.Data.Services.Motorcycles.DTO;

namespace RentalMotorcycle.Data.Services.Motorcycles.Mapper;

public interface IMotorcycleMapper
{
    MotorcycleDTO Map(Motorcycle model);
    Motorcycle Map(MotorcycleDTO model);
    List<MotorcycleDTO> Map(List<Motorcycle> model);
    List<MotorcycleDTO> Map(IEnumerable<Motorcycle> model);    
}