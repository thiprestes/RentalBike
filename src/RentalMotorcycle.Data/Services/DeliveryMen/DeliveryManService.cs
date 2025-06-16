using RentalMotorcycle.Data.Repositories.DeliveryMen;
using RentalMotorcycle.Data.Services.DeliveryMen.DTO;
using RentalMotorcycle.Data.Services.DeliveryMen.Mapper;

namespace RentalMotorcycle.Data.Services.DeliveryMen;

public class DeliveryManService(IDeliveryManRepository deliveryManRepository, IDeliveryManMapper deliveryManMapper) : IDeliveryManService
{
    public async Task<DeliveryManDTO> GetById(string id)
    {
        var ret = await deliveryManRepository.GetByIdAsync(id);
        return deliveryManMapper.Map(ret);
    } 
    
    public async Task<DeliveryManDTO> PostDeliveryMan(DeliveryManDTO deliveryMan)
    {
        await deliveryManRepository.AddAsync(deliveryManMapper.Map(deliveryMan));
        await deliveryManRepository.SaveChangesAsync();
        return deliveryMan;
    }
}