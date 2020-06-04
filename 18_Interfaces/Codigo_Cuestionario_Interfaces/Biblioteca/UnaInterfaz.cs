namespace Biblioteca
{
    public interface OtraInterfaz<T> where T : struct
    {
        void OtroMetodo(T parametro, int parametro2);
    }

    public class ClaseImplementadora<Z> : OtraInterfaz<Z> where Z : struct
    {
        public void OtroMetodo(Z parametro, int otro) {

        }
    }
}