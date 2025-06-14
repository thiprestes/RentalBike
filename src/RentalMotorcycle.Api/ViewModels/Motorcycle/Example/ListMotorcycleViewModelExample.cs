using RentalMotorcycle.Api.ViewModels.Motorcycle.Request;
using Swashbuckle.AspNetCore.Filters;

namespace RentalMotorcycle.Api.ViewModels.Motorcycle.Example;

public class ListMotorcycleViewModelExample : IExamplesProvider<List<MotorcycleViewModel>>
{
    public List<MotorcycleViewModel> GetExamples()
    {
        var motorcycle = new MotorcycleViewModel(
            identificador: "moto123",
            ano: 2025,
            modelo: "BMW S 1000 RR",
            placa: "BRA-4E21");
        var motorcycles = new List<MotorcycleViewModel>();
        motorcycles.Add(motorcycle);
        return motorcycles;
    }
}