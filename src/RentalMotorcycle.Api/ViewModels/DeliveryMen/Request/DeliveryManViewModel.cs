namespace RentalMotorcycle.Api.ViewModels.DeliveryMen.Request;

public record DeliveryManViewModel(
    string identificador,
    string nome,
    string cnpj,
    DateTime data_nascimento,
    string numero_cnh,
    string tipo_cnh,
    string imagem_cnh);