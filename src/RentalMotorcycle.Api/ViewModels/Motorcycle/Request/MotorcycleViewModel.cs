namespace RentalMotorcycle.Api.ViewModels.Motorcycle.Request;

public record MotorcycleViewModel(
    string Identificador,
    int Ano,
    string Modelo,
    string Placa);