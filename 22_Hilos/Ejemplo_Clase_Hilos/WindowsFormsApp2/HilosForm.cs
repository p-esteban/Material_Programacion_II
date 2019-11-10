using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class HilosForm : Form
    {
        private delegate void Callback();
        private delegate void CallbackConParam(object o);
        public int cantidadVueltas;

        private Thread hilo;

        public HilosForm()
        {
            InitializeComponent();
        }

        private void buttonEscribir_Click(object sender, EventArgs e)
        {
            this.richTextBoxTexto.Text += this.textBoxEscribir.Text + "\n";
            this.textBoxEscribir.Clear();
        }

        private void HilosForm_Load(object sender, EventArgs e)
        {
            //this.hilo = new Thread(new ThreadStart(Contar));
            //hilo.Start();
            this.hilo = new Thread(new ParameterizedThreadStart(this.ContarASaltos));
            hilo.Start(10);
        }

        private void Contar()
        {
            while(true)
            {
                this.ActualizarLabel();
                Thread.Sleep(1000);
            }
        }

        private void ActualizarLabel()
        {
            this.ActualizarLabel(1);
        }

        
        private void HilosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.hilo != null && this.hilo.IsAlive)
            {
                this.hilo.Abort();
            }
        }

        private void ContarASaltos(object cantidadASaltar)
        {
            while (true)
            {
                this.ActualizarLabel(cantidadASaltar);
                Thread.Sleep(1000);
            }
        }

        private void ActualizarLabel(object cantidadASaltar)
        {
            // Verifica si se està llamando al control desde el hilo que lo creó. Da true si está en un hilo diferente.
            if (this.labelContador.InvokeRequired)
            {
                // Array de parametros del método a invocar
                object[] parametros = new object[] { cantidadASaltar };
                // Método invoke del control, llamará al método desde el hilo que lo creó. 
                this.labelContador.Invoke(new CallbackConParam(this.ActualizarLabel), parametros);
            }
            else
            {
                this.labelContador.Text = (Convert.ToInt32(this.labelContador.Text) + (int)cantidadASaltar).ToString();
            }
        }
    }
}
