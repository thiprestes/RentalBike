using RentalMotorcycle.Api.ViewModels.Motorcycle.Request;
using RentalMotorcycle.Data.Services.Motorcycles.DTO;

namespace RentalMotorcycle.Api.Mapper.Motorcycle;

public interface IMotorcycleMapper
{
    MotorcycleDTO Map(MotorcycleViewModel model);
    MotorcycleViewModel Map(MotorcycleDTO model);
    List<MotorcycleViewModel> Map(List<MotorcycleDTO> model);
}