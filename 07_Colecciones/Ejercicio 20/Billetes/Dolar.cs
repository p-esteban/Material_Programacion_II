using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro e = new Euro(d.GetCantidad());
            return e;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos e = new Pesos(d.GetCantidad());
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

        public static implicit operator Dolar(double d)
        {
            Dolar d1 = new Dolar(d);
            return d1;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            if (d.GetCantidad() == e.GetCantidad()*Euro.GetCotizacion())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return (!(d != e));
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            if (d.GetCantidad() == p.GetCantidad() * Pesos.GetCotizacion())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return (!(d != p));
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            if (d1.GetCantidad() == d2.GetCantidad())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (!(d1 != d2));
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar d1 = (Dolar)e;
            d1.cantidad += d.cantidad;
            return d1;
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar d1 = (Dolar)p;
            d1.cantidad += d.cantidad;
            return d1;
        }        
    }
}
