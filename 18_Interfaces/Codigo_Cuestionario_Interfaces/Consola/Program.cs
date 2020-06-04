using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(SmartHub.EncenderDispositivo(new Televisor()));
            //Console.ReadKey();
            System.Console.WriteLine(SmartHub.EncenderDispositivo(new Computadora()));
            Console.ReadKey();
        }
    }
}
