using RentalMotorcycle.Api.ViewModels.DeliveryMen.Request;
using RentalMotorcycle.Data.Services.DeliveryMen.DTO;

namespace RentalMotorcycle.Api.Mapper.DeliveryMen;

public interface IDeliveryManMapper
{
    DeliveryManDTO Map(DeliveryManViewModel model);
    DeliveryManViewModel Map(DeliveryManDTO model);
}