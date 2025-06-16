namespace RentalMotorcycle.Api.ViewModels.Motorcycle.Response;

public record MotorcycleResponse(
    string id,
    int ano,
    string modelo,
    string placa) ;