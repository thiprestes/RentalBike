using RentalMotorcycle.Business.Entities.Motorcycles;
using Riok.Mapperly.Abstractions;
using RentalMotorcycle.Data.Services.Motorcycles.DTO;

namespace RentalMotorcycle.Data.Services.Motorcycles.Mapper;
[Mapper]
public partial class MotorcycleMapper : IMotorcycleMapper
{
    public partial MotorcycleDTO Map(Motorcycle motorcycle);
    public partial Motorcycle Map(MotorcycleDTO motorcycleDto);
    public partial List<MotorcycleDTO> Map(List<Motorcycle> listmotorcycle);
    public partial List<MotorcycleDTO> Map(IEnumerable<Motorcycle> enummotorcycle);
}