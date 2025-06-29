﻿namespace RentalMotorcycle.Data.Services.DeliveryMen.DTO;

public class DeliveryManDTO
{
    public string Identificador { get; set; }
    public string Nome { get; set; }
    public string Cnpj { get; set; }
    public DateTime Data_nascimento { get; set; }
    public string Numero_cnh { get; set; }
    public string Tipo_cnh { get; set; }
    public string Imagem_cnh { get; set; }
    public decimal Valor_diaria { get; set; }
}