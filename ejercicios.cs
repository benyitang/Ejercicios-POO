using System;
using System.Collections.Generic;
using System.Text;

public class Superheroe
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public bool Capa { get; set; }


    public Superheroe(string nombre)
    {
        Nombre = nombre;
        Descripcion = "void";
        Capa = false;
    }
    public override string ToString()
    {
        return $"Nombre: {Nombre}, Descripción: {Descripcion}, Capa: {Capa}";
    }
}

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

public class Coleccion
{
    public string NombreColeccion { get; set; }
    private List<Figura> listaFiguras;


    public Coleccion(string nombreColeccion)
    {
        NombreColeccion = nombreColeccion;
        listaFiguras = new List<Figura>();
    }


    public void AñadirFigura(Figura fig)
    {
        listaFiguras.Add(fig);
    }
    public void SubirPrecio(double cantidad, string id)
    {
        foreach (var fig in listaFiguras)
        {
            if (fig.Codigo == id)
            {
                fig.SubirPrecio(cantidad);
            }
        }
    }
    public string ConCapa()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var fig in listaFiguras)
        {
            if (fig.Superheroe.Capa)
            {
                sb.AppendLine(fig.ToString());
            }
        }
        return sb.ToString();
    }
    public Figura MasValioso()
    {
        Figura max = null;
        foreach (var fig in listaFiguras)
        {
            if (max == null || fig.Precio > max.Precio)
            {
                max = fig;
            }
        }
        return max;
    }
    public double GetValorColeccion()
    {
        double total = 0;
        foreach (var fig in listaFiguras)
        {
            total += fig.Precio;
        }
        return total;
    }


    public double GetVolumenColeccion()
    {
        double total = 0;
        foreach (var fig in listaFiguras)
        {
            total += fig.Dimensiones.GetVolumen();
        }
        return total + 200;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Colección: {NombreColeccion}");
        foreach (var fig in listaFiguras)
        {
            sb.AppendLine(fig.ToString());
        }
        return sb.ToString();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Superheroe batman = new Superheroe("Batman");
        batman.Descripcion = "Traje oscuro";
        batman.Capa = true;


        Dimension dim = new Dimension(10, 5, 3);


        Figura figura1 = new Figura("F001", 100, dim, batman);


        Coleccion coleccion = new Coleccion("DC");


        coleccion.AñadirFigura(figura1);


        Console.WriteLine(coleccion);


        Console.WriteLine("Más valioso:");
        Console.WriteLine(coleccion.MasValioso());


        Console.WriteLine("Valor total: " + coleccion.GetValorColeccion());
        Console.WriteLine("Volumen total: " + coleccion.GetVolumenColeccion());
    }
}
