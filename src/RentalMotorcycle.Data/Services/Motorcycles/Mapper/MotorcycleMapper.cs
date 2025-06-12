using Riok.Mapperly.Abstractions;
using RentalMotorcycle.business.Entities.Motorcycle;
using RentalMotorcycle.Data.Services.Motorcycle.DTO;
using RentalMotorcycle.Data.Services.Motorcycle.DTO;

namespace RentalMotorcycle.Data.Services.Motorcycle.Mapper;

public partial class MotorcycleMapper : IMotorcycleMapper
{
    public partial MotorcycleDTO Map(Motorcycle model);
    public partial Motorcycle Map(MotorcycleDTO model);
    public partial List<MotorcycleDTO> Map(List<Motorcycle> model);
    public partial List<MotorcycleDTO> Map(IEnumerable<Motorcycle> model);
}