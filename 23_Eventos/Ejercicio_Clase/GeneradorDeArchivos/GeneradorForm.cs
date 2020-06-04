using Biblioteca;
using System;
using System.Threading;
using System.Windows.Forms;

namespace GeneradorDeArchivos
{
    public partial class GeneradorForm : Form
    {
        public GeneradorForm()
        {
            InitializeComponent();
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(new ThreadStart(GenerarArchivo));
            hilo.Start();
        }

        private void GenerarArchivo()
        {
            Random random = new Random();
            long longitudTexto = random.Next(int.MaxValue / 2, int.MaxValue);
            GeneradorDeTexto generador = new GeneradorDeTexto(longitudTexto);
            ProgresoForm form = new ProgresoForm();
            generador.Generando += form.ActualizarProgreso;
            Thread thread = new Thread(new ParameterizedThreadStart(MostrarProgreso));
            thread.Start(form);
            Archivador archivador = new Archivador();
            archivador.Guardar(generador);
        }

        private void MostrarProgreso(object form)
        {
            ((ProgresoForm)form).ShowDialog();
        }
    }
}
