using System;
namespace Ejercicios{
public class Dimension
{
    public double Alto { get; set; }
    public double Ancho { get; set; }
    public double Profundidad { get; set; }
    public Dimension()
    {
        Alto = 0;
        Ancho = 0;
        Profundidad = 0;
    }
    public Dimension(double alto, double ancho, double profundidad)
    {
        Alto = alto;
        Ancho = ancho;
        Profundidad = profundidad;
    }
    public double GetVolumen()
    {
        return Alto * Ancho * Profundidad;
    }
    public override string ToString()
    {
        return $"Alto: {Alto}, Ancho: {Ancho}, Profundidad: {Profundidad}, Volumen: {GetVolumen()}";
    }
}
}