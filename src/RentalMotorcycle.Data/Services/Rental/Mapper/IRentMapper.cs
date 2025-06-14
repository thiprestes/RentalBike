using RentalMotorcycle.Business.Entities.Rental;
using RentalMotorcycle.Data.Services.Rental.DTO;

namespace RentalMotorcycle.Data.Services.Rental.Mapper;

public interface IRentMapper
{
    RentDTO Map(Rent model);
    Rent Map(RentDTO model);
}