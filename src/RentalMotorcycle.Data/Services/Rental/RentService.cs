using RentalMotorcycle.Data.Repositories.Rental;
using RentalMotorcycle.Data.Services.Rental.DTO;
using RentalMotorcycle.Data.Services.Rental.Mapper;

namespace RentalMotorcycle.Data.Services.Rental;

public class RentService(IRentRepository rentRepository, IRentMapper rentMapper) : IRentService
{
    public async Task<RentDTO> GetById(string id)
    {
        var ret = await rentRepository.GetByIdAsync(id);
        return rentMapper.Map(ret);
    }

    public int GetValorDiaria(RentDTO rentDto)
    {
        if (rentDto.Plano == 7)
        {
            rentDto.Valor_diaria = 30;
        }
        else if (rentDto.Plano == 15)
        {
            rentDto.Valor_diaria = 28;
        }
        else if (rentDto.Plano == 30)
        {
            rentDto.Valor_diaria = 22;
        }
        else if (rentDto.Plano == 45)
        {
            rentDto.Valor_diaria = 20;
        }
        else if (rentDto.Plano == 50)
        {
            rentDto.Valor_diaria = 18;
        }
        return rentDto.Valor_diaria;
    }

    public async Task<RentDTO> PostRent(RentDTO rentDto)
    {
        await rentRepository.AddAsync(rentMapper.Map(rentDto));
        await rentRepository.SaveChangesAsync();
        return rentDto;    
    }
}