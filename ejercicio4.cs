using System.Collections.Generic;
using System.Text;
using System;

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
