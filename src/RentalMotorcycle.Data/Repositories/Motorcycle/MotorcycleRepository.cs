using RentalMotorcycle.Data.Repositories.Generic;

namespace RentalMotorcycle.Data.Repositories.Motorcycle;

public class MotorcycleRepository(DatabaseContext context) 
    : Repository<Motorcycle>(context), IMotorcycleRepository
{
    
}