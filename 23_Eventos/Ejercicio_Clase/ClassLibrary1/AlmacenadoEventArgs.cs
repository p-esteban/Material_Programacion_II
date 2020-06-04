namespace Biblioteca
{
    public class AlmacenadoEventArgs
    {
        private string nombreArchivo;

        public string NombreArchivo
        {
            get
            {
                return this.nombreArchivo;
            }
        }

        public AlmacenadoEventArgs(string nombreArchivo)
        {
            this.nombreArchivo = nombreArchivo;
        }
    }
}
