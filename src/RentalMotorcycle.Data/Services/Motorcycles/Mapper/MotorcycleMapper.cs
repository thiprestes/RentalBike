using RentalMotorcycle.Business.Entities.Motorcycles;
using Riok.Mapperly.Abstractions;
using RentalMotorcycle.Data.Services.Motorcycles.DTO;

namespace RentalMotorcycle.Data.Services.Motorcycles.Mapper;
[Mapper]
public partial class MotorcycleMapper : IMotorcycleMapper
{
    public partial MotorcycleDTO Map(Motorcycle model);
    public partial Motorcycle Map(MotorcycleDTO model);
    public partial List<MotorcycleDTO> Map(List<Motorcycle> model);
    public partial List<MotorcycleDTO> Map(IEnumerable<Motorcycle> model);
}