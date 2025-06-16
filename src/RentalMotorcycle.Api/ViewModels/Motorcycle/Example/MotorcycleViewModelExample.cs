using RentalMotorcycle.Api.ViewModels.Motorcycle.Request;
using Swashbuckle.AspNetCore.Filters;

namespace RentalMotorcycle.Api.ViewModels.Motorcycle.Example;

public class MotorcycleViewModelExample : IExamplesProvider<MotorcycleViewModel>
{
    public MotorcycleViewModel GetExamples()
    {
        return new MotorcycleViewModel(
            Identificador: "moto123",
            Ano: 2025,
            Modelo: "BMW S 1000 RR",
            Placa: "BRA-4E21"
        );
    }
}