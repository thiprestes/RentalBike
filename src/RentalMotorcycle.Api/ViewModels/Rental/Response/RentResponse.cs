namespace RentalMotorcycle.Api.ViewModels.Rental.Response;

public record RentResponse( 
    string Identificador, 
    int Valor_diaria,
    string Entregador_id,
    string Moto_id,
    DateTime Data_inicio,
    DateTime Data_termino,
    DateTime Data_precisa_termino,
    DateTime Data_devolucao
);