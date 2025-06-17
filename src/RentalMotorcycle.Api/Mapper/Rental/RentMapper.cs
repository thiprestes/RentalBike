using RentalMotorcycle.Api.ViewModels.Rental.Request;
using RentalMotorcycle.Business.Entities.Rental;
using RentalMotorcycle.Data.Services.Rental.DTO;
using Riok.Mapperly.Abstractions;

namespace RentalMotorcycle.Api.Mapper.Rental;

[Mapper]
public partial class RentMapper : IRentMapper
{
    public partial RentDTO Map(RentViewModel model);
    public partial RentViewModel Map(RentDTO model);
}