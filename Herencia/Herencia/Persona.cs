using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;
        private int edad;

        /// <summary>
        /// Constructor por defecto. ¿Qué pasa si no está y no invoco explícitamente al constructor de la clase base?
        /// </summary>
        //public Persona()
        //{

        //}

        /// <summary>
        /// Constructor de Persona.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        /// <param name="edad">Edad de la persona.</param>
        /// <param name="dni">DNI de la persona.</param>
        public Persona(string nombre, string apellido, int edad, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        /// <summary>
        /// Devuelve un string con los datos de la persona. 
        /// </summary>
        /// <returns>Datos de la persona en formato string.</returns>
        protected string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("/nNombre: {0}/n", this.nombre);
            sb.AppendFormat("/nApellido: {0}/n", this.apellido);
            sb.AppendFormat("/nEdad: {0}/n", this.edad);
            sb.AppendFormat("/nDNI: {0}/n", this.dni);

            return sb.ToString();
        }
        

    }
}
