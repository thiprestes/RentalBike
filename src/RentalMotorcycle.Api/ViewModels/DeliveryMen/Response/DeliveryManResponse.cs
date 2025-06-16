namespace RentalMotorcycle.Api.ViewModels.DeliveryMen.Response;

public record DeliveryManResponse(
    string identificador,
    string nome,
    string cnpj,
    DateTime data_nascimento,
    string cnh,
    string tipo_cnh,
    string imagem_cnh
);
    