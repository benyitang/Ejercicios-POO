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
