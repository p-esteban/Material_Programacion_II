using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesos p1 = new Pesos(100);
            Dolar d1 = new Dolar(100);
            Euro e1 = new Euro(100);

            Pesos p2 = p1 + e1;

            Console.WriteLine("Cantidad de pesos: {0}",p2.GetCantidad());
            Console.ReadKey();
        }
    }
}
