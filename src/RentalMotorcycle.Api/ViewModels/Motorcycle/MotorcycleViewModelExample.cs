using Swashbuckle.AspNetCore.Filters;

namespace RentalMotorcycle.Api.ViewModels.Motorcycle;

public class MotorcycleViewModelExample : IExamplesProvider<MotorcycleViewModel>
{
    public MotorcycleViewModel GetExamples()
    {
        return new MotorcycleViewModel(
            identificador: "moto123",
            ano: 2025,
            modelo: "BMW S 1000 RR",
            placa: "BRA-4E21"
        );
    }
}