namespace RentalMotorcycle.Api.ViewModels;

public class BaseResponse
{
    public required string Mensagem { get; set; }
    public required Guid Id { get; set; }
}