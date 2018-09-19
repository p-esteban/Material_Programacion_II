using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public abstract class MiembroFacultad : Persona
    {
        /// <summary>
        /// Constructor que sirve como pasamanos entre las clases derivadas de MiembroFacultad y la clase Persona. 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        public MiembroFacultad(string nombre, string apellido, int edad, string dni) 
            : base(nombre, apellido, edad, dni)
        {
        }

        /// <summary>
        /// Deberá ser implementado por las clases derivadas. 
        /// </summary>
        /// <returns>Aula</returns>
        protected abstract string BuscarAula();
    }
}
