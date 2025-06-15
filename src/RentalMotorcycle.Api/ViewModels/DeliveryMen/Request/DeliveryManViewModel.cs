namespace RentalMotorcycle.Api.ViewModels.DeliveryMen.Request;

public record DeliveryManViewModel(
    string Identificador,
    string Nome,
    string Cnpj,
    DateTime Data_nascimento,
    string Cnh,
    string Tipo_cnh,
    string Imagem_cnh);