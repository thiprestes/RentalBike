using RentalMotorcycle.Api.ViewModels.Motorcycle;
using RentalMotorcycle.Data.Services.Motorcycle.DTO;

namespace RentalMotorcycle.Api.Mapper;

public interface IMotorcycleMapper
{
    MotorcycleDTO Map(MotorcycleViewModel model);
    MotorcycleViewModel Map(MotorcycleDTO model);
    List<MotorcycleViewModel> Map(List<MotorcycleDTO> model);
}