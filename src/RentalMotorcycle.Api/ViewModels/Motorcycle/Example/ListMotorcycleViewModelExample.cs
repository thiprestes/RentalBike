using RentalMotorcycle.Api.ViewModels.Motorcycle.Request;
using Swashbuckle.AspNetCore.Filters;

namespace RentalMotorcycle.Api.ViewModels.Motorcycle.Example;

public class ListMotorcycleViewModelExample : IExamplesProvider<List<MotorcycleViewModel>>
{
    public List<MotorcycleViewModel> GetExamples()
    {
        var motorcycle = new MotorcycleViewModel(
            Identificador: "moto123",
            Ano: 2025,
            Modelo: "BMW S 1000 RR",
            Placa: "BRA-4E21");
        var motorcycles = new List<MotorcycleViewModel>();
        motorcycles.Add(motorcycle);
        return motorcycles;
    }
}