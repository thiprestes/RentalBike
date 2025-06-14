using RentalMotorcycle.Api.ViewModels.Motorcycle.Request;
using RentalMotorcycle.Data.Services.Motorcycles.DTO;
using Riok.Mapperly.Abstractions;

namespace RentalMotorcycle.Api.Mapper.Motorcycle;

[Mapper]
public partial class MotorcycleMapper : IMotorcycleMapper
{
    public partial MotorcycleDTO Map(MotorcycleViewModel model);
    public partial MotorcycleViewModel Map(MotorcycleDTO model);
    public partial List<MotorcycleViewModel> Map(List<MotorcycleDTO> model);
}