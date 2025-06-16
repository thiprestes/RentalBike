using RentalMotorcycle.Data.Services.DeliveryMen.DTO;

namespace RentalMotorcycle.Data.Services.DeliveryMen;

public interface IDeliveryManService
{
    public Task<DeliveryManDTO> GetById(string id);
    public Task<DeliveryManDTO> PostDeliveryMan(DeliveryManDTO deliveryMan);
}