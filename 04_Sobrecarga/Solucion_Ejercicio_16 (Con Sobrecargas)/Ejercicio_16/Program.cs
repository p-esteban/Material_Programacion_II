using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancio e inicializo los objetos Alumno.
            Alumno alumno1 = new Alumno("Matias", "Palmieri", 1111);
            Alumno alumno2 = new Alumno("Elian", "Rojas", 2222);
            Alumno alumno3 = new Alumno("Cintia", "Zanoni", 3333);

            // Cargo las notas con el mètodo Estudiar
            alumno1.Estudiar(3, 8);
            alumno2.Estudiar(4, 6);
            alumno3.Estudiar(4, 6);

            // Genero la nota final
            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            // Mostrar los datos
            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());
            Console.ReadKey();
        }
    }
}
