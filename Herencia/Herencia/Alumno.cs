using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Alumno : MiembroFacultad
    {
        private string legajo;
        private double promedio;

        public Alumno(string nombre, string apellido, int edad, string dni)
            :this(nombre,apellido,edad,dni,dni,0)
        {
        }

        public Alumno(string nombre, string apellido, int edad, string dni, string legajo, double promedio) 
            :base(nombre, apellido, edad, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }


        protected override string BuscarAula()
        {
            throw new NotImplementedException();
        }
    }
}
