using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            List<int> lista = new List<int>();
            Stack<int> pila = new Stack<int>();
            Queue<int> cola = new Queue<int>();
            Random random = new Random();


            //Que cargue 20 numeros positivos y negativos distintos de cero.
            for (int i = 0; i < 20; i++)
            {
                int numero;
                do
                {
                    numero = random.Next(-100,100);
                } while (numero == 0);

                array[i] = numero;
                lista.Add(numero);
                pila.Push(numero);
                cola.Enqueue(numero);
            }

            //Mostrar tal como fue ingresado. 
            Console.WriteLine("SIN ORDENAR");
            Console.WriteLine("\nArray: ");
            foreach (int num in array)
            {
                Console.Write("{0}, ",num);
            }

            Console.WriteLine("\nLista: ");
            foreach (int num in lista)
            {
                Console.Write("{0}, ", num);
            }

            Console.WriteLine("\nPila: ");
            foreach (int num in pila)
            {
                Console.Write("{0}, ", num);
            }

            Console.WriteLine("\nCola: ");
            foreach (int num in cola)
            {
                Console.Write("{0}, ", num);
            }

            Console.ReadKey();
            Console.Clear();
            /*Una expresión Lambda es una función anónima. 
            Con ellas se puede escribir funciones que pueden ser pasadas como argumento 
            o retornadas en una función.
            En el lado izquierda del operador Lambda => se ponen los parámetros de entrada de la función
            en el lado derecha la expresión o lo que devuelve. 

            Se utilizan con LINQ. Una herramienta para consulta de datos del Framework .NET 3.5 
            en adelante mediante expresiones de consulta parecidas a las sentencias SQL. 
            Los métodos Where y OrderBy pertenecen a LINQ. 
            */
            
            int[] arrayPositivos = array.Where(x => x > 0).ToArray();
            
            int[] arrayPositivosOrdenados = arrayPositivos.OrderByDescending(x => x).ToArray();
                                 

            Console.WriteLine("\nArray: ");
            foreach (int num in array)
            {
                Console.Write("{0}, ", num);
            }

            Console.WriteLine("\nArray POSITIVOS: ");
            foreach (int num in arrayPositivos)
            {
                Console.Write("{0}, ", num);
            }

            Console.WriteLine("\nArray positivos ORDENADOS: ");
            foreach (int num in arrayPositivosOrdenados)
            {
                Console.Write("{0}, ", num);
            }

            Console.ReadKey();


            List<int> listaPositivos = lista.Where(x => x > 0).OrderByDescending(x => x).ToList();
            //A las pilas y a las colas se las puede inicializar a partir de cualquier IEnumerable. 
            Queue<int> colaNegativos = new Queue<int>(cola.Where(x => x < 0).OrderBy(x => x).ToList());
            Stack<int> pilaNegativos = new Stack<int>(pila.Where(x => x < 0).OrderBy(x => x).ToList());
            Console.Clear();
            Console.WriteLine("ORDENADOS");
            Console.WriteLine("\nArray: ");
            foreach (int num in arrayPositivosOrdenados)
            {
                Console.Write("{0}, ", num);
            }

            Console.WriteLine("\nLista: ");
            foreach (int num in listaPositivos)
            {
                Console.Write("{0}, ", num);
            }

            Console.WriteLine("\nPila: ");
            foreach (int num in pilaNegativos)
            {
                Console.Write("{0}, ", num);
            }

            Console.WriteLine("\nCola: ");
            foreach (int num in colaNegativos)
            {
                Console.Write("{0}, ", num);
            }

            Console.ReadKey();
        }
    }
}
