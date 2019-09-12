using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Pesos()
        {
            cotizRespectoDolar = 38.33;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Pesos p)
        {
            Dolar d = new Dolar(p.GetCantidad()*Pesos.GetCotizacion());
            return d;
        }

        public static explicit operator Euro(Pesos p)
        {
            Euro e = new Euro((p.GetCantidad()*Pesos.GetCotizacion())/Euro.GetCotizacion());
            return e;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static implicit operator Pesos(double p)
        {
            Pesos p1 = new Pesos(p);
            return p1;
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos p1 = (Pesos)d;
            p1.cantidad += p.cantidad;
            return p1;
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos p1 = (Pesos)e;
            p1.cantidad += p.cantidad;
            return p1;
        }
    }
}
