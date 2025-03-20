namespace Biblioteca;

public class Contenta : Estado
{

    public Contenta() : base("Contenta") { }

    public override bool PuedeJugar => true;

    public override void Comer(Mascota mascota)
    {
        throw new NotImplementedException();
    }

    public override void Jugar(Mascota mascota)
    {
        throw new NotImplementedException();
    }
}