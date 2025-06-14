namespace RentalMotorcycle.Api.ViewModels.Motorcycle.Request;

public record MotorcycleViewModel(
    string identificador,
    int ano,
    string modelo,
    string placa);