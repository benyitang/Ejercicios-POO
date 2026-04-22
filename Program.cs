using System;
using Ejercicios; // Esto conecta con tus clases

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- INICIANDO SISTEMA DE COLECCIONES ---");

    
            Superheroe batman = new Superheroe("Batman");
            batman.Descripcion = "El caballero de la noche";
            batman.Capa = true;

            Superheroe spiderman = new Superheroe("Spider-Man");
            spiderman.Descripcion = "Tu amigable vecino";
            spiderman.Capa = false;

        
            Dimension dimGrande = new Dimension(30, 20, 15);
            Dimension dimPequena = new Dimension(15, 10, 10);

         
            Figura fig1 = new Figura("BAT-001", 150.50, dimGrande, batman);
            Figura fig2 = new Figura("SPI-002", 80.00, dimPequena, spiderman);

            Coleccion miColeccion = new Coleccion("Mi Colección Premium");
            miColeccion.AñadirFigura(fig1);
            miColeccion.AñadirFigura(fig2);

         
            Console.WriteLine(miColeccion.ToString());

            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Valor total de la colección: ${miColeccion.GetValorColeccion()}");
            Console.WriteLine($"Volumen total necesario: {miColeccion.GetVolumenColeccion()} cm³");
            
            Figura masCara = miColeccion.MasValioso();
            Console.WriteLine($"La figura más valiosa es: {masCara.Superheroe.Nombre} ({masCara.Codigo})");

            Console.WriteLine("\n--- Figuras que tienen capa ---");
            Console.WriteLine(miColeccion.ConCapa());
        }
    }
}