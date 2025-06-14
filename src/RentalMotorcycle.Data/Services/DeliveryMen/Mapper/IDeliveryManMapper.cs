using RentalMotorcycle.Business.Entities.DeliveryMen;
using RentalMotorcycle.Data.Services.DeliveryMen.DTO;

namespace RentalMotorcycle.Data.Services.DeliveryMen.Mapper;

public interface IDeliveryManMapper
{
    DeliveryManDTO Map(DeliveryMan model);
    DeliveryMan Map(DeliveryManDTO model);
}