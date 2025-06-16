using Microsoft.AspNetCore.Http.HttpResults;

namespace RentalMotorcycle.Api.ViewModels;

public class BaseResponse
{
    public required string Mensagem { get; set; }
}