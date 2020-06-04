namespace Biblioteca
{
    /// <summary>
    /// Extensión de la interfaz IAlmacenable para datos que se guardan en texto plano.
    /// </summary>
    public interface IAlmacenablePlano : IAlmacenable<string>
    {
        bool Anexar { get; }
    }
}
