using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundoWF
{
    public partial class HolaMundoForm : Form
    {
        public HolaMundoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador del evento click del btnSaludar (botón). Se llamará cuando el usuario haga click. 
        /// </summary>
        /// <param name="sender">Referencia al control que lanza el evento.</param>
        /// <param name="e">Contiene los argumentos del evento.</param>
        private void BtnSaludarOnClick(object sender, EventArgs e)
        {
            //Obtengo el texto ingresado por el usuario en el textbox "txtNombre".
            string nombre = this.txtNombre.Text;
            //Muestro un MessageBox con un mensaje de bienvenida personalizado. 
            DialogResult result = MessageBox.Show(String.Format("¡Hola {0}! Bienvenido.", nombre), "Bienvenido", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            //Cuando el usuario presione aceptar se va a cerrar el form. 
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else //Si apretó cancelar abro una nueva ventana del HolaMundoForm. 
            {
                HolaMundoForm nuevoForm = new HolaMundoForm();
                //nuevoForm.ShowDialog(); //Muestra el formulario de forma modal, es decir, no se podrá interactuar con el padre. 
                nuevoForm.Show(); //Muestra el formulario de forma no-modal, es decir, se puede interactuar con el padre. 
            }
        }
    }
}
