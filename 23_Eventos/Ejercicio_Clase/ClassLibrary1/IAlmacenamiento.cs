namespace Biblioteca
{
    public delegate void AlmacenadoHandler(object sender, AlmacenadoEventArgs args);

    public interface IAlmacenamiento<T>
    {
        event AlmacenadoHandler Almacenado;
        void Guardar(T objetoAGuardar);
        T Leer(string rutaOrigen);
    }
}
