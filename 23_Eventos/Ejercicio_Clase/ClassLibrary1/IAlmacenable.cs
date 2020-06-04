using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Determina una interfaz a implementar por clases que requieran guardar un dato.
    /// </summary>
    /// <typeparam name="U">Dato a guardar. </typeparam>
    public interface IAlmacenable<U>
    {
        string NombreArchivo { get; }
        string RutaDestino { get; }
        U DatoParaAlmacenar { get; }
    }
}
