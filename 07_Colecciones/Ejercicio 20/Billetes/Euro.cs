using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = 1.16;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Pesos(Euro e)
        {
            Pesos p = new Pesos((e.GetCantidad()/Euro.GetCotizacion())*Pesos.GetCotizacion());
            return p;
        }

        public static explicit operator Dolar(Euro e)
        {
            Dolar d = new Dolar(e.GetCantidad()*Euro.GetCotizacion());
            return d;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static implicit operator Euro(double e)
        {
            Euro e1 = new Euro(e);
            return e1;
        }

        public static bool operator !=(Euro e,Dolar d)
        {
            if (d.GetCantidad() == e.GetCantidad() * Euro.GetCotizacion())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return (!(e != d));
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro e1 = (Euro)d;
            e1.cantidad += e.cantidad;
            return e1;
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            Euro e1 = (Euro)p;
            e1.cantidad += e.cantidad;
            return e1;
        }
    }
}
