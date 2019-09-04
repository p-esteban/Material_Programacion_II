using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = default(int);
            double acumulador = 0;
            string entrada = string.Empty;
            int max = 0;
            int min = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un número:");
                entrada = Console.ReadLine();
                bool esValido = Int32.TryParse(entrada, out numero);
                if (esValido)
                {
                    acumulador += numero;
                    if (i == 0)
                    {
                        max = numero;
                        min = numero;
                    }
                    else if (numero > max)
                    {
                        max = numero;
                    }
                    else if (numero < min)
                    {
                        min = numero;
                    }
                } 
            }
            /*Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;*/
            Console.WriteLine("Màximo: {0}", max);
            Console.WriteLine("Minimo: {0}", min);
            Console.WriteLine("Promedio: {0}", acumulador / 5.0);
            
            Console.ReadKey();
        }
    }
}
