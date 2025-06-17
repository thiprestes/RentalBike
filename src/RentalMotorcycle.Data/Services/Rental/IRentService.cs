using RentalMotorcycle.Data.Services.Rental.DTO;

namespace RentalMotorcycle.Data.Services.Rental;

public interface IRentService
{
    public Task<RentDTO> GetById(string id);
    public int GetValorDiaria(RentDTO rentDto);
    public Task<(bool existDeliveryMan, bool existMotorcycle, bool ExistRent)>  PostRent(RentDTO rentDto);
    public Task<(decimal totalRent, bool success)> PutRent(string id, DateTime dateDevolucao);
}