namespace RentalMotorcycle.Api.ViewModels.Rental.Request;

public record RentViewModel(
    string entregador_id,
    string moto_id,
    DateTime data_inicio,
    DateTime data_termino,
    DateTime data_precisao_termino,
    int plano);