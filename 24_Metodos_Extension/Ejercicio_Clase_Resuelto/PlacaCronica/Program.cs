using System;
using Biblioteca;

namespace PlacaCronica
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;
            Console.WriteLine("{0}", fecha.ObtenerPlacaCronica(Estaciones.Invierno));
            Console.WriteLine("{0}", fecha.ObtenerPlacaCronica(Estaciones.Verano));
            Console.WriteLine("{0}", fecha.ObtenerPlacaCronica(Estaciones.Primavera));
            Console.WriteLine("{0}", fecha.ObtenerPlacaCronica(Estaciones.Otonio));

            Console.ReadKey();
        }
    }
}
