
namespace Biblioteca;

public abstract class Estado 
{
    public required string Nombre { get; set; }

    public Estado(string nombre) => Nombre = nombre;

    public abstract void Comer(Mascota mascota);

    public abstract void Jugar(Mascota mascota);
    public abstract bool PuedeJugar {get;}
}