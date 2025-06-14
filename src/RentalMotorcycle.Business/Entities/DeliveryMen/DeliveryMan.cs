using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace RentalMotorcycle.Business.Entities.DeliveryMen;

public class DeliveryMan
{
    public Guid Id { get; set; }
    public string Identificador { get; set; }
    public string Nome { get; set; }
    public string Cnpj { get; set; }
    public DateTime Data_nascimento { get; set; }
    public string Cnh { get; set; }
    public string Tipo_cnh { get; set; }
    public string Imagem_cnh { get; set; }
}