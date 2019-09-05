namespace Entidades
{
    public class Producto
    {
        #region Atributos
        private string codigoDeBarra;
        private string marca;
        private float precio;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="codigo">Código de barra del producto.</param>
        /// <param name="marca">Marca del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        public Producto(string codigo, string marca, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Getter de atributo marca.
        /// </summary>
        /// <returns>Marca del producto.</returns>
        public string GetMarca()
        {
            return this.marca;
        }

        /// <summary>
        /// Getter de atributo precio.
        /// </summary>
        /// <returns>Precio del producto.</returns>
        public float GetPrecio()
        {
            return this.precio;
        }

        /// <summary>
        /// Devuelve los datos de un producto.
        /// </summary>
        /// <param name="p">Producto del cual se desean ver los datos.</param>
        /// <returns>String con los datos del producto.</returns>
        public static string MostrarProducto(Producto p)
        {
            string retorno = string.Empty;
            retorno += string.Format("Codigo: {0} \n", p.codigoDeBarra);
            retorno += string.Format("Marca: {0} \n", p.GetMarca());
            retorno += string.Format("Precio: {0:#.00} \n", p.GetPrecio());
            
            return retorno;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Conversión de un producto a su código de barras. 
        /// </summary>
        /// <param name="p">Producto a convertir.</param>
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        /// <summary>
        /// Evalúa si son el mismo producto.
        /// </summary>
        /// <param name="p1">Primer producto.</param>
        /// <param name="p2">Segundo producto.</param>
        /// <returns>
        /// Retornará true, si las marcas y códigos de barras 
        /// son iguales, false, caso contrario.
        /// </returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.codigoDeBarra == p2.codigoDeBarra && p1 == p2.marca);
        }

        /// <summary>
        /// Evalúa si son el mismo producto.
        /// </summary>
        /// <param name="p1">Primer producto.</param>
        /// <param name="p2">Segundo producto.</param>
        /// <returns>
        /// Retornará false, si las marcas y códigos de barras 
        /// son iguales, true, caso contrario.
        /// </returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Evalúa si la marca coincide con la del producto.
        /// </summary>
        /// <param name="p">Producto</param>
        /// <param name="marca">Marca</param>
        /// <returns>
        /// Retornará true, si la marca del producto coincide 
        /// con la cadena pasada por parámetro, false,
        /// caso contrario.
        /// </returns>
        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca;
        }

        /// <summary>
        /// Evalúa si la marca NO coincide con la del producto.
        /// </summary>
        /// <param name="p">Producto</param>
        /// <param name="marca">Marca</param>
        /// <returns>
        /// Retornará true, si la marca del producto NO coincide 
        /// con la cadena pasada por parámetro, false,
        /// caso contrario.
        /// </returns>
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
        #endregion
    }
}
