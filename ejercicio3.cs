using System;
public class Figura
{
    public string Codigo { get; set; }
    public double Precio { get; set; }
    public Superheroe Superheroe { get; set; }
    public Dimension Dimensiones { get; set; }
    public Figura(string codigo, double precio, Dimension dimensiones, Superheroe superheroe)
    {
        Codigo = codigo;
        Precio = precio;
        Dimensiones = dimensiones;
        Superheroe = superheroe;
    }
    public void SubirPrecio(double cantidad)
    {
        Precio += cantidad;
    }
    public override string ToString()
    {
        return $"Código: {Codigo}, Precio: {Precio}\n{Superheroe}\n{Dimensiones}";
    }
}
