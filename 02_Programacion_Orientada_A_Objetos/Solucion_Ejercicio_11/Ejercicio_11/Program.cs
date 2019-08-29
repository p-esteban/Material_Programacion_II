using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            const int limiteMinimo = -100;
            const int limiteMaximo = 100;
            const int cantidadIteraciones = 5;
            int acumulador = 0;
            int maximo = default(int);
            int minimo = default(int);

            for (int i = 0; i < cantidadIteraciones; i++)
            {
                int numero;
                Console.WriteLine("Ingrese un número:");
                while (!int.TryParse(Console.ReadLine(), out numero)
                    || !Validacion.Validar(numero, limiteMinimo, limiteMaximo))
                {
                    Console.WriteLine("Debe ingresar un número válido entre {0} y {1}", limiteMinimo, limiteMaximo);
                }

                acumulador += numero;

                if (i == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else if (numero > maximo)
                {
                    maximo = numero;
                }
                else if (numero < minimo)
                {
                    minimo = numero;
                }
            }

            Console.WriteLine("El promedio es {0}", acumulador / cantidadIteraciones);
            Console.WriteLine("El maximo es {0}", maximo);
            Console.WriteLine("El minimo es {0}", minimo);
            Console.ReadKey();
        }
    }
}
