namespace RentalMotorcycle.Data.Services.Rental.DTO;

public class RentDTO
{
    public string Identificador { get; set; }
    public string Entregador_id { get; set; }
    public string Moto_id { get; set; } 
    public int Valor_diaria { get; set; }
    public decimal Valor_Total { get; set; }
    public DateTime Data_inicio { get; set; }
    public DateTime Data_termino { get; set; }
    public DateTime Data_previsao_termino { get; set; }
    public DateTime Data_devolucao { get; set; }
    public int Plano { get; set; }   
}