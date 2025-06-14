using RentalMotorcycle.Business.Entities.DeliveryMen;
using RentalMotorcycle.Data.Repositories.Generic;

namespace RentalMotorcycle.Data.Repositories.DeliveryMen;

public class DeliveryManRepository(DatabaseContext context) 
    : Repository<DeliveryMan>(context), IDeliveryManRepository
{
    
}