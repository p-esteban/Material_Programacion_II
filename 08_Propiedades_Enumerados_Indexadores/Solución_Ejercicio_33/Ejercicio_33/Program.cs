using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            string pagina;

            // bucle for agrega 5 páginas
            for (int i = 0; i < 5; i++)
            {
                libro[i] = String.Format("Página {0:0#}", i);
            }

            // Intento leer una página en el índice 8 (no existe).
            // Devuelve string vacìo.
            Console.WriteLine("\nIntento leer una página en el índice 8 (no existe). Devuelve string vacìo.");
            pagina = libro[8];
            Console.WriteLine("\nIndice: {0}. Resultado: {1}", 8, pagina);

            Console.ReadKey();
            Console.Clear();

            // Intento leer una página en el índice 3 (existe).
            Console.WriteLine("\nIntento leer una página en el índice 3 (existe).");
            pagina = libro[3];
            Console.WriteLine("\nIndice: {0}. Resultado: {1}", 3, pagina);

            Console.ReadKey();
            Console.Clear();

            // Intento agregar una página en un índice no existente. 
            // La agregará en el siguiente índice no ocupado (el 5).
            Console.WriteLine("\nIntento agregar una página en un índice no existente. La agregará en el siguiente índice no ocupado (el 5).");
            libro[8] = "Pagina de prueba poniendo indice 8";
            pagina = libro[5];
            Console.WriteLine("\nIndice: {0}. Resultado: {1}", 5, pagina);

            Console.ReadKey();
            Console.Clear();

            // Intento agregar una página en un índice existente. La modifica.
            Console.WriteLine("\nIntento agregar una página en un índice existente. La modifica.");
            libro[3] = "Modifiqué la página en el índice 03";
            pagina = libro[3];
            Console.WriteLine("\nIndice: {0}. Resultado: {1}", 3, pagina);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
