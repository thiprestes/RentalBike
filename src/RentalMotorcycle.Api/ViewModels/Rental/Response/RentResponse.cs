namespace RentalMotorcycle.Api.ViewModels.Rental.Response;

public class RentResponse : BaseResponse
{
    public string identificador { get; set; } 
    public int valor_diaria { get; set; }
    public string entregador_id { get; set; }
    public string moto_id { get; set; }
    public DateTime data_inicio { get; set; }
    public DateTime data_termino { get; set; }
    public DateTime Data_precisa_termino { get; set; }
    public DateTime Data_devolucao { get; set; }
}