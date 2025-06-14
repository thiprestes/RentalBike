namespace RentalMotorcycle.Api.ViewModels.Motorcycle.Response;

public record MotorcycleResponse(
    Guid Id,
    string identificador,
    int ano,
    string modelo,
    string placa) ;