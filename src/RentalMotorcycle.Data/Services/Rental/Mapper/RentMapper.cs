using RentalMotorcycle.Business.Entities.Rental;
using RentalMotorcycle.Data.Services.Rental.DTO;
using Riok.Mapperly.Abstractions;

namespace RentalMotorcycle.Data.Services.Rental.Mapper;

[Mapper]
public partial class RentMapper : IRentMapper
{
    public partial RentDTO Map(Rent rent);
    public partial Rent Map(RentDTO rentDTO);
}