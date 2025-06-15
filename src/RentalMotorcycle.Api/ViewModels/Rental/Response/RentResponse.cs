namespace RentalMotorcycle.Api.ViewModels.Rental.Response;

public class RentResponse : BaseResponse
{
    public string Identificador { get; set; } 
    public int Valor_diaria { get; set; }
    public string Entregador_id { get; set; }
    public string Moto_id { get; set; }
    public DateTime Data_inicio { get; set; }
    public DateTime Data_termino { get; set; }
    public DateTime Data_precisa_termino { get; set; }
    public DateTime Data_devolucao { get; set; }
}