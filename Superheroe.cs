using System;
namespace Ejercicios{
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
}