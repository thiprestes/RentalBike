using RentalMotorcycle.Business.Entities.Motorcycles;
using RentalMotorcycle.Data.Repositories.Generic;

namespace RentalMotorcycle.Data.Repositories.Motorcycles;

public class MotorcycleRepository(DatabaseContext context) 
    : Repository<Motorcycle>(context), IMotorcycleRepository
{
    
}