using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        #region Atributos
        private Producto[] productos;
        private int ubicacionEstante;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="capacidad">Capacidad del estante.</param>
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="capacidad">Capacidad del estante.</param>
        /// <param name="ubicacion">Ubicación del estante.</param>
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Getter de productos.
        /// </summary>
        /// <returns>Array con los productos del estante.</returns>
        public Producto[] GetProductos()
        {
            return this.productos;
        }

        /// <summary>
        /// Muestra los datos de un estante, incluyendo sus productos.
        /// </summary>
        /// <param name="estante">Estante.</param>
        /// <returns>String con los datos del estante.</returns>
        public static string MostrarEstante(Estante estante)
        {
            string retorno = string.Empty;
            retorno += String.Format("Estante. Ubicación: {0}\n", estante.ubicacionEstante);
            retorno += "\nProductos: \n";

            foreach (Producto producto in estante.GetProductos())
            {
                if (!(producto is null))
                {
                    retorno += Producto.MostrarProducto(producto) + "\n";
                }
            }

            return retorno;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Evalúa si el producto ya se encuentra en el estante. 
        /// </summary>
        /// <param name="e">Estante</param>
        /// <param name="p">Producto</param>
        /// <returns>
        /// retornará true, si es que el producto ya se encuentra 
        /// en el estante, false, caso contrario
        /// </returns>
        public static bool operator ==(Estante e, Producto p)
        {
            foreach (Producto producto in e.GetProductos())
            {
                if (!(producto is null) && producto == p)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Evalúa si el producto NO se encuentra en el estante. 
        /// </summary>
        /// <param name="e">Estante</param>
        /// <param name="p">Producto</param>
        /// <returns>
        /// retornará true, si es que el producto NO se encuentra 
        /// en el estante, false, caso contrario
        /// </returns>
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        /// <summary>
        /// Agrega un nuevo producto al estante.
        /// </summary>
        /// <param name="e">Estante</param>
        /// <param name="p">Producto</param>
        /// <returns>
        /// Retornará true y agregará el producto si el estante 
        /// posee capacidad de almacenar al menos un producto más y
        /// dicho producto no se encuentra en él; 
        /// false, caso contrario.
        /// </returns>
        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;

            // Si no se encuentra en el estante
            if (e != p)
            {
                Producto[] productos = e.GetProductos();

                for (int i = 0; i < e.GetProductos().Length; i++)
                {
                    // Si es null queda espacio.
                    if (productos[i] is null)
                    {
                        productos[i] = p;
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        /// <summary>
        /// Elimina un producto del estante.
        /// </summary>
        /// <param name="e">Estante</param>
        /// <param name="p">Producto</param>
        /// <returns>
        /// Retornará true y agregará el producto si el estante 
        /// posee capacidad de almacenar al menos un producto más y
        /// dicho producto no se encuentra en él; 
        /// false, caso contrario.
        /// </returns>
        public static Estante operator -(Estante e, Producto p)
        {
            // Si se encuentra en el estante
            if (e == p)
            {
                Producto[] productos = e.GetProductos();

                for (int i = 0; i < e.GetProductos().Length; i++)
                {
                    // Si es el producto a eliminar
                    if (productos[i] == p)
                    {
                        productos[i] = null;
                        break;
                    }
                }
            }

            return e;
        }
        #endregion
    }
}
