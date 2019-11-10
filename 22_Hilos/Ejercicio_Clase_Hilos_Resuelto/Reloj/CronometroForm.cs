using System;
using System.Threading;
using System.Windows.Forms;

namespace Reloj
{
    public partial class CronometroForm : Form
    {
        private Thread hilo;
        private int horas;
        private int minutos;
        private int segundos;
        private const string INICIAR = "Iniciar";
        private const string DETENER = "Detener";
        private delegate void Callback();

        public CronometroForm()
        {
            InitializeComponent();
        }

        private void Reiniciar()
        {
            this.horas = 0;
            this.minutos = 0;
            this.segundos = 0;
            this.buttonIniciar.Text = INICIAR;
            this.ActualizarLabel();
        }

        private void ButtonIniciar_Click(object sender, EventArgs e)
        {            
            if (this.hilo == null || !this.hilo.IsAlive)
            {
                this.hilo = new Thread(ActualizarCronometro);
                this.hilo.Start();
                this.buttonIniciar.Text = DETENER;
            }
            else
            {
                this.hilo.Abort();
                this.buttonIniciar.Text = INICIAR;
            }
        }

        private void ActualizarCronometro()
        {
            while(true)
            {
                segundos++;
                if (segundos == 60)
                {
                    segundos = 0;
                    minutos++;

                    if (minutos == 60)
                    {
                        minutos = 0;
                        horas++;
                    }
                }
                this.ActualizarLabel();
                Thread.Sleep(1000);
            }
        }

        private void ActualizarLabel()
        {
            // InvokeRequired verifica si el control se encuentra en un hilo distinto a desde donde se llama. 
            // Si se está llamando desde un hilo distinto, devuelve true porque se requiere invocación. 
            if (this.labelCronometro.InvokeRequired)
            {
                //Invoke invoca al método/s referenciado por el delegado desde el hilo al que pertenece el control. 
                this.labelCronometro.Invoke(new Callback(this.ActualizarLabel), new object[] { }); //Lista de argumentos. 
            }
            else
            {
                this.labelCronometro.Text = String.Format("{0:00} : {1:00} : {2:00}", this.horas, this.minutos, this.segundos);
            }            
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            this.AbortarHilo();
            this.Reiniciar();
        }

        private void CronometroForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.AbortarHilo();
        }

        private void AbortarHilo()
        {
            if (this.hilo != null && this.hilo.IsAlive)
            {
                this.hilo.Abort();
            }
        }
    }
}
