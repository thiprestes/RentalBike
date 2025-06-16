using RentalMotorcycle.Business.Entities.DeliveryMen;
using RentalMotorcycle.Data.Services.DeliveryMen.DTO;
using Riok.Mapperly.Abstractions;

namespace RentalMotorcycle.Data.Services.DeliveryMen.Mapper;

[Mapper]
public partial class DeliveryManMapper : IDeliveryManMapper
{
    public partial DeliveryManDTO Map(DeliveryMan deliveryMan);
    public partial DeliveryMan Map(DeliveryManDTO deliveryManDto);
}