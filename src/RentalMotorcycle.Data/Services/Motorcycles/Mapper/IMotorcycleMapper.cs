using RentalMotorcycle.business.Entities.Motorcycle;
using RentalMotorcycle.Data.Services.Motorcycle.DTO;

namespace RentalMotorcycle.Data.Services.Motorcycle.Mapper;

public interface IMotorcycleMapper
{
    MotorcycleDTO Map(Motorcycle model);
    Motorcycle Map(MotorcycleDTO model);
    List<MotorcycleDTO> Map(List<Motorcycle> model);
    List<MotorcycleDTO> Map(IEnumerable<Motorcycle> model);    
}