using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace RentalMotorcycle.Business.Entities.Rental;

public class Rent
{
    public string Identificador { get; set; }
    public string Entregador_id { get; set; }
    public string Moto_id { get; set; }
    public DateTime Data_inicio { get; set; }
    public DateTime Data_termino { get; set; }
    public DateTime Data_previsao_termino { get; set; }
    public DateTime Data_devolucao { get; set; }
    public int Plano { get; set; }
}