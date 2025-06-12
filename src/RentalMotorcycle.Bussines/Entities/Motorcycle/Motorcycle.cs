namespace RentalMotorcycle.business.Entities.Motorcycle;

public class Motorcycle
{
    public Guid Id { get; set; }
    public string Identificador { get; set; }
    public int Ano { get; set; }
    public string Modelo { get; set; }
    public string Placa { get; set; }
}