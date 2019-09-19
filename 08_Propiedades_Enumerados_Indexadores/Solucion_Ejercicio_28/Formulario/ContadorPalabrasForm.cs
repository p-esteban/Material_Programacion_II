using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formulario
{
    public partial class ContadorPalabrasForm : Form
    {
        public ContadorPalabrasForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador del evento OnClick del botón calcular.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalcular_OnClick(object sender, EventArgs e)
        {
            // Declaro un atributo que almacenará mi diccionario (contador de palabras)
            Dictionary<string, int> contadorPalabras;

            // Las colecciones son objetos, hay que instanciarlos.
            contadorPalabras = new Dictionary<string, int>();

            string[] palabras = this.richTxtPalabras.Text.Split(' ');

            foreach (string palabra in palabras)
            {
                string palabraAux = palabra.ToLower();

                if (contadorPalabras.ContainsKey(palabraAux))
                {
                    contadorPalabras[palabraAux]++;
                }
                else
                {
                    contadorPalabras.Add(palabraAux, 1);
                }
            }
            this.InformarMasRepetidas(contadorPalabras, 3);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>
        /// Less than zero	This instance precedes value.
        /// Zero This instance has the same position in the sort order as value.
        /// Greater than zero This instance follows value. -or- value is null.
        /// </returns>
        private int Compare(KeyValuePair<string, int> x, KeyValuePair<string, int> y)
        {
            return y.Value - x.Value;
        }

        private void InformarMasRepetidas(Dictionary<string, int> contadorPalabras, int cantidadAMostrar)
        {
            //Ordenar de forma descendente(mayor a menor).
          
            // OPCION 1: Usando el método Sort de las listas.
            // Paso el diccionario a lista para ordenar.
            List<KeyValuePair<string, int>> lista = contadorPalabras.ToList();
            lista.Sort(Compare);

            // Versión Lambda del método Compare:
            //lista.Sort((x, y) => y.Value - x.Value);

            // OPCION 2: Ordenar usando LINQ y funciones lambda
            // Directamente sobre el diccionario.
            //contadorPalabras.OrderByDescending(keyValuePair => keyValuePair.Value);

            // Mostrar.
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PALABRAS MAS REPETIDAS:");

            
            for (int i = 0, j = 0; i < lista.Count && j < cantidadAMostrar; i++)
            {
                sb.AppendFormat("<<Puesto {0:0#}>> {1}, {2} repeticiones.\n", i + 1, lista[i].Key, lista[i].Value);

                if(lista[i].Value != lista[i+1].Value)
                {
                    j++;
                }
            }

            MessageBox.Show(sb.ToString(), "Palabras más repetidas", MessageBoxButtons.OK);        
            

        }

        /*
            Caso de prueba:
            
            "Prueba Test Prueba PRUEBA Hola hola test test gato gato prueba casa perro hola gato esto es laboratorio y programación 2 casa"
            
            Resultado
            prueba 04
            test 03
            hola 03
            gato 03
            casa 02         
         */
    }
}
