using Riok.Mapperly.Abstractions;
using RentalMotorcycle.Api.ViewModels.Motorcycle;
using RentalMotorcycle.business.Entities.Motorcycle;
using RentalMotorcycle.Data.Services.Motorcycle.DTO;

namespace RentalMotorcycle.Api.Mapper;

[Mapper]
public partial class MotorcycleMapper : IMotorcycleMapper
{
    public partial MotorcycleDTO Map(MotorcycleViewModel model);
    public partial MotorcycleViewModel Map(MotorcycleDTO model);
    public partial List<MotorcycleViewModel> Map(List<MotorcycleDTO> model);
}