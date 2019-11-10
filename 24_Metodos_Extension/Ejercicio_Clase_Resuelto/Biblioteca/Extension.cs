using System;

namespace Biblioteca
{
    public enum Estaciones
    {
        Verano,
        Otonio,
        Invierno,
        Primavera
    }
    public static class Extension
    {
        public static string ObtenerPlacaCronica(this DateTime fechaInicial, Estaciones estacion)
        {
            int diaEstacion = 21;
            int mesEstacion = default(int);

            switch (estacion)
            {
                case Estaciones.Verano:
                    mesEstacion = 12;
                    break;
                case Estaciones.Otonio:
                    mesEstacion = 3;
                    break;
                case Estaciones.Invierno:
                    mesEstacion = 6;
                    break;
                case Estaciones.Primavera:
                    mesEstacion = 9;
                    break;
            }

            DateTime fechaEstacion = new DateTime(fechaInicial.Year, mesEstacion, diaEstacion);

            if (fechaEstacion < fechaInicial)
            {
                fechaEstacion = fechaEstacion.AddYears(1);
            }

            TimeSpan tiempoRestante = fechaEstacion - fechaInicial;
            int diasRestantes = (int)tiempoRestante.TotalDays;

            return String.Format("Faltan {0} días para el {1}", diasRestantes, Enum.GetName(typeof(Estaciones), estacion));
        }
    }
}