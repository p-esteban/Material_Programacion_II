using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Sobrecarga_Constructores
{
    class Sobrecarga
    {
        private string mensaje;
        private int n;
        private int x;

        public Sobrecarga()
        {
            this.mensaje = "Sobrecarga";
            this.n = 5;
            this.x = 6;
        }

        public Sobrecarga(int n) : this()
        {
            this.n = n;
        }

        public Sobrecarga(int n, int x) : this(n)
        {
            this.x = x;
        }

        public Sobrecarga(int n, int x, string mensaje) : this(n, x)
        {
            this.mensaje = mensaje;
        }
    }
}
