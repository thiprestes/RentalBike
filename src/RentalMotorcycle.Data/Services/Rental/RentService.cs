using RentalMotorcycle.Data.Repositories.Rental;
using RentalMotorcycle.Data.Services.DeliveryMen;
using RentalMotorcycle.Data.Services.Motorcycles;
using RentalMotorcycle.Data.Services.Rental.DTO;
using RentalMotorcycle.Data.Services.Rental.Mapper;

namespace RentalMotorcycle.Data.Services.Rental;

public class RentService(
    IRentRepository rentRepository,
    IRentMapper rentMapper,
    IDeliveryManService deliveryManService,
    IMotorcycleService motorcycleService) : IRentService
{
    public async Task<RentDTO> GetById(string id)
    {
        var ret = await rentRepository.GetByIdAsync(id);
        if (ret == null)
        {
            return null;
        }

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
        else
        {
            return 0;
        }

        return rentDto.Valor_diaria;
    }

    public async Task<(bool existDeliveryMan, bool existMotorcycle, bool ExistRent)> PostRent(RentDTO rentDto)
    {
        var existDeliveryMan = deliveryManService.GetById(rentDto.Entregador_id).Result;
        var existMotorcycle = motorcycleService.GetById(rentDto.Moto_id).Result;
        var existRent = GetById(rentDto.Identificador).Result;
        if (existDeliveryMan == null || existMotorcycle == null || existRent != null)
        {
            return ((existDeliveryMan != null), (existMotorcycle != null), (existRent != null));
        }

        await rentRepository.AddAsync(rentMapper.Map(rentDto));
        await rentRepository.SaveChangesAsync();
        return ((existDeliveryMan != null), (existMotorcycle != null), (existRent != null));
    }

    public async Task<(decimal totalRent, bool success)> PutRent(string id, DateTime dataDevolucao)
    {
        var ret = await GetById(id);
        if (ret == null)
        {
            return (0, false);
        }
        else
        {
            decimal rentFines = 0;
            decimal totalRent = 0; 
            int daysLeft = 0;
            int valuePerDay = GetValorDiaria(ret);
            var qtdDays = GetNumberOfDays(ret.Data_inicio, dataDevolucao);
            if (qtdDays > ret.Plano)
            {
                rentFines = CalcularteAdicionalValue(ret.Plano, qtdDays);
            }
            else
            {
                daysLeft = ret.Plano - qtdDays;
                if (ret.Plano == 7)
                {
                    rentFines = (decimal)((daysLeft * valuePerDay) * 0.2);
                }
                else
                {
                    rentFines = (decimal)((daysLeft * valuePerDay) * 0.4);    
                }
            }

            totalRent = rentFines + CalculateRentValue(qtdDays, valuePerDay);
            
            ret.Data_devolucao = dataDevolucao;
            await rentRepository.SaveChangesAsync();
            return (totalRent, true);
        }
    }

    public int GetNumberOfDays(DateTime dataInicio,DateTime dataDevolucao)
    {
        var QuantidadeDiaria = 0;
        QuantidadeDiaria = dataDevolucao.Subtract(dataInicio).Days;
        return QuantidadeDiaria;
    }

    public decimal CalculateRentValue(int days, int ValuePerDay)
    {
        return days * ValuePerDay;
    }

    public decimal CalcularteAdicionalValue(int plano, int qtdDays)
    {
        const decimal additionalPerDay = 50;
        return (qtdDays - plano ) * additionalPerDay;  
    }
}