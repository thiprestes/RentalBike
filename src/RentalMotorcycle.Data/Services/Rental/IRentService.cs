using RentalMotorcycle.Data.Services.Rental.DTO;

namespace RentalMotorcycle.Data.Services.Rental;

public interface IRentService
{
    public Task<RentDTO> GetById(string id);
    public int GetValorDiaria(RentDTO rentDto);
    
    public Task<RentDTO> PostRent(RentDTO rentDto);
}