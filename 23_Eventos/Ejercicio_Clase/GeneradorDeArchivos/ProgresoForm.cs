using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorDeArchivos
{
    public partial class ProgresoForm : Form
    {
        public ProgresoForm()
        {
            InitializeComponent();
        }

        private void ProgresoForm_Load(object sender, EventArgs e)
        {
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = 100;
        }

        public void ActualizarProgreso(int progreso)
        {
            this.progressBar1.Increment(progreso);
        }
    }
}
