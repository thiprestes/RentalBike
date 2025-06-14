using RentalMotorcycle.Business.Entities.Rental;
using RentalMotorcycle.Data.Repositories.Generic;

namespace RentalMotorcycle.Data.Repositories.Rental;

public class RentRepository(DatabaseContext context) 
    : Repository<Rent>(context), IRentRepository
{
    
}