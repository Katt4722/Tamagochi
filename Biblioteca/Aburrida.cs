namespace Biblioteca;

public class Aburrida : Estado
{
    public Aburrida() : base("Aburrida")
    {
        
    }
    public DateTime Inicio { get; set; }
    public short minutosAburrida { get; set; } 
    public short umbralComida { get; set; }

    public override bool PuedeJugar => throw new NotImplementedException();

    public override void Comer(Mascota mascota)
    {
        throw new NotImplementedException();
        
    }

    public override void Jugar(Mascota mascota)
    {
        throw new NotImplementedException();
    }
}