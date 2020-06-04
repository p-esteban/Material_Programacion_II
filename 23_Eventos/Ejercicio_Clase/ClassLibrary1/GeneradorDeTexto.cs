using System;
using System.IO;

namespace Biblioteca
{
    public class GeneradorDeTexto : IAlmacenablePlano
    {
        private static int contadorArchivos;
        private static char[] caracteres;
        private long longitud;
        public event GenerandoHandler Generando;
        public delegate void GenerandoHandler(int progreso);

        public bool Anexar
        {
            get
            {
                return false;
            }
        }

        public string NombreArchivo
        {
            get
            {
                string nombre = "archivo" + GeneradorDeTexto.contadorArchivos.ToString();
                if (File.Exists(this.RutaDestino+nombre))
                {
                    GeneradorDeTexto.contadorArchivos++;
                    nombre = "archivo" + GeneradorDeTexto.contadorArchivos.ToString();
                }

                return nombre;
            }
        }

        public string RutaDestino
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            }
        }

        public string DatoParaAlmacenar
        {
            get
            {
                return this.GenerarTexto();
            }
        }

        static GeneradorDeTexto()
        {
            GeneradorDeTexto.contadorArchivos = 0;
            GeneradorDeTexto.caracteres = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz1234567890!@#$%&/()==?¡¡¿/*-+ _:;-,.ñÑ".ToCharArray();
        }

        public GeneradorDeTexto(long longitud)
        {
            this.longitud = longitud;
        }

        private string GenerarTexto()
        {
            Random random = new Random();
            int cantCaracteres = GeneradorDeTexto.caracteres.Length;
            string texto = string.Empty;

            for(int i = 0; i < this.longitud; i++)
            {
                if (i%10 == 0)
                {
                    this.Generando(i * 100 / (int)this.longitud);
                }
                texto += GeneradorDeTexto.caracteres[random.Next(0, cantCaracteres)];
            }

            return texto;
        }
    }
}
