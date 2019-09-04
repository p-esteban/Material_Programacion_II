using System;

namespace Entidades
{
    public class Alumno
    {
        #region Atributos
        private byte nota1;
        private byte nota2;
        private byte nota3;
        private float notaFinal;
        private string nombre;
        private string apellido;
        private string segundoNombre;
        private int legajo;
        #endregion

        #region Constructores
        /// <summary>
        /// Instancia un nuevo alumno.
        /// </summary>
        /// <param name="nombre">Nombre del alumno.</param>
        /// <param name="apellido">Apellido del alumno.</param>
        /// <param name="legajo">Legajo del alumno.</param>
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public Alumno(string nombre, string apellido, 
            int legajo, string segundoNombre) :this(nombre,apellido, legajo)
        {
            this.segundoNombre = segundoNombre;
        }
        #endregion

        #region Metodos
        public void CalcularFinal()
        {
            Random random = new Random();
            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = random.Next(1, 11);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        /// <summary>
        /// Carga la nota del alumno.
        /// </summary>
        /// <param name="notaUno">Nota del primer parcial.</param>
        /// <param name="notaDos">Nota del segundo parcial.</param>
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void Estudiar(string notaUno, string notaDos)
        {
            this.Estudiar(Convert.ToByte(notaUno), Convert.ToByte(notaDos));
        }

        public void Estudiar(byte notaUno, byte notaDos, byte notaTres)
        {
            this.nota3 = notaTres;
            this.Estudiar(notaUno, notaDos);
        }

        public string Mostrar()
        {
            string mostrar = string.Empty;
            mostrar += String.Format("Nombre: {0}\n", this.nombre);
            mostrar += String.Format("Apellido: {0}\n", this.apellido);
            mostrar += String.Format("Nota Final: {0}", this.notaFinal);

            return mostrar;
        }
        #endregion



    }
}
