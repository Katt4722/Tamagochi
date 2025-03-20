namespace Biblioteca;

public class Hambrienta : Estado
{
    public Hambrienta() : base("Hambrienta") { }

    public override bool PuedeJugar => false;

    public override void Comer(Mascota mascota)
    {
        mascota.Estado = new Contenta();
    }

    public override void Jugar(Mascota mascota)
        => throw new InvalidOperationException("No Puede jugar");
}
