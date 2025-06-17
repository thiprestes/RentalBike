using RentalMotorcycle.Data.Repositories.DeliveryMen;
using RentalMotorcycle.Data.Services.DeliveryMen.DTO;
using RentalMotorcycle.Data.Services.DeliveryMen.Mapper;

namespace RentalMotorcycle.Data.Services.DeliveryMen;

public class DeliveryManService(IDeliveryManRepository deliveryManRepository, IDeliveryManMapper deliveryManMapper) : IDeliveryManService
{
    public async Task<DeliveryManDTO> GetById(string id)
    {   
        var ret = await deliveryManRepository.GetByIdAsync(id);
        if (ret == null)
        {
            return null;
        }
        return deliveryManMapper.Map(ret);
    } 
    
    public async Task<bool> PostDeliveryMan(DeliveryManDTO deliveryMan)
    {
        try
        {
            await deliveryManRepository.AddAsync(deliveryManMapper.Map(deliveryMan));
            await deliveryManRepository.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public async Task<bool> PutDeliveryManCnh(string id, string imageCnh)
    {
        try
        {
            var ret = await deliveryManRepository.GetByIdAsync(id);
            if (ret == null)
            {
                return false;
            }
            ret.Imagem_cnh = imageCnh;
            await deliveryManRepository.SaveChangesAsync(); 
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }
}