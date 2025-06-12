namespace RentalMotorcycle.Api.ViewModels.Motorcycle;

public record MotorcycleViewModel(
    string identificador,
    int ano,
    string modelo,
    string placa);