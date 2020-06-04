using System;

namespace Biblioteca
{
    public class SmartHub
    {
        public static string EncenderDispositivo(ISmart dispositivo)
        {
            string retorno = dispositivo.Encender();

            return retorno;
        }
    }
}