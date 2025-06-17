using RentalMotorcycle.Data.Services.DeliveryMen.DTO;

namespace RentalMotorcycle.Data.Services.DeliveryMen;

public interface IDeliveryManService
{
    public Task<DeliveryManDTO> GetById(string id);
    public Task<bool> PostDeliveryMan(DeliveryManDTO deliveryMan);
    public Task<bool> PutDeliveryManCnh(string id, string imageCnh);
}