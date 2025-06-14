using RentalMotorcycle.Api.ViewModels.Rental.Request;
using RentalMotorcycle.Data.Services.Rental.DTO;

namespace RentalMotorcycle.Api.Mapper.Rental;

public interface IRentMapper
{
    RentDTO Map(RentViewModel model);
    RentViewModel Map(RentDTO model);
}