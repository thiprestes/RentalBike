namespace RentalMotorcycle.Api.ViewModels.Rental.Request;

public record RentViewModel(
    string Identificador,
    string Entregador_id,
    string Moto_id,
    DateTime Data_inicio,
    DateTime Data_termino,
    DateTime Data_previsao_termino,
    int Plano);