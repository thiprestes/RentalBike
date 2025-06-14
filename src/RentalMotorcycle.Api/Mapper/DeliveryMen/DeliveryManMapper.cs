using RentalMotorcycle.Api.ViewModels.DeliveryMen.Request;
using RentalMotorcycle.Data.Services.DeliveryMen.DTO;
using Riok.Mapperly.Abstractions;

namespace RentalMotorcycle.Api.Mapper.DeliveryMen;

[Mapper]
public partial class DeliveryManMapper : IDeliveryManMapper
{
    public partial DeliveryManDTO Map(DeliveryManViewModel model);
    public partial DeliveryManViewModel Map(DeliveryManDTO model);
}