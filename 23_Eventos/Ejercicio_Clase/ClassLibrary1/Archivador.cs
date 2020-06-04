using System.IO;

namespace Biblioteca
{
    public class Archivador : IAlmacenamiento<IAlmacenablePlano>
    {
        public event AlmacenadoHandler Almacenado;

        public void Guardar(IAlmacenablePlano objetoAGuardar)
        {
            using(StreamWriter writer = new StreamWriter())
        }
        
        public IAlmacenablePlano Leer(string rutaOrigen)
        {
            throw new System.NotImplementedException();
        }
    }
}
