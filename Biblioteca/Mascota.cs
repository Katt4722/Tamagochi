
namespace Biblioteca;

public class Mascota
{
    public byte Felicidad { get; set; }
    public Estado Estado { get; set; }
    public int TiempoAburrida { get; set; }
    public int VecesJugando { get; set; }
    public void Comer() => Estado.Comer(this);

    public void Jugar() => Estado.Jugar(this);
    public void PuedeJugar () => Estado.Jugar(this);

    }