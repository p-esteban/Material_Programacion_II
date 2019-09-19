using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro
    {
        private List<string> paginas;

        /// <summary>
        /// Constructor. 
        /// Instancia la lista de páginas del libro.
        /// </summary>
        public Libro()
        {
            this.paginas = new List<string>();
        }

        /// <summary>
        /// Indexador del libro.
        /// </summary>
        /// <param name="indice">Indice de la página</param>
        /// <returns></returns>
        public string this[int indice] {
            get
            {
                /* Si el índice es mayor o igual a cero 
                 * y menor a la cantidad de elementos de la lista. 
                 * Entonces, existe.
                 * Lo retorno.                
                 */
                if (indice >= 0 && indice < this.paginas.Count)
                {
                    return this.paginas[indice];
                }
                else 
                {
                    /* Sino, estoy tratando de acceder 
                     * a un índice que no existe.
                     * Retorno una cadena vacía.
                     */
                    return string.Empty;
                }
            }

            set
            {
                // Si el índice es válido.
                if (indice >= 0)
                {
                    /* Si el índice es mayor o igual a cero 
                     * y menor a la cantidad de elementos de la lista. 
                     * Entonces, existe.
                     * Lo modifico.             
                     */
                    if (indice < this.paginas.Count)
                    {
                        this.paginas[indice] = value;
                    }
                    else
                    {
                        /* Si supera o iguala 
                         * a la cantidad de elementos,
                         * Lo agrego.                        
                        */
                        this.paginas.Add(value);
                    }
                }
            }
        } 

    }
}
