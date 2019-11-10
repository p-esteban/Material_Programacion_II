namespace WindowsFormsApp2
{
    partial class HilosForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEscribir = new System.Windows.Forms.Button();
            this.labelContador = new System.Windows.Forms.Label();
            this.richTextBoxTexto = new System.Windows.Forms.RichTextBox();
            this.textBoxEscribir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEscribir
            // 
            this.buttonEscribir.Location = new System.Drawing.Point(13, 158);
            this.buttonEscribir.Name = "buttonEscribir";
            this.buttonEscribir.Size = new System.Drawing.Size(75, 23);
            this.buttonEscribir.TabIndex = 0;
            this.buttonEscribir.Text = "Escribir";
            this.buttonEscribir.UseVisualStyleBackColor = true;
            this.buttonEscribir.Click += new System.EventHandler(this.buttonEscribir_Click);
            // 
            // labelContador
            // 
            this.labelContador.AutoSize = true;
            this.labelContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContador.Location = new System.Drawing.Point(13, 22);
            this.labelContador.Name = "labelContador";
            this.labelContador.Size = new System.Drawing.Size(69, 73);
            this.labelContador.TabIndex = 1;
            this.labelContador.Text = "0";
            // 
            // richTextBoxTexto
            // 
            this.richTextBoxTexto.Location = new System.Drawing.Point(173, 12);
            this.richTextBoxTexto.Name = "richTextBoxTexto";
            this.richTextBoxTexto.Size = new System.Drawing.Size(323, 169);
            this.richTextBoxTexto.TabIndex = 2;
            this.richTextBoxTexto.Text = "";
            // 
            // textBoxEscribir
            // 
            this.textBoxEscribir.Location = new System.Drawing.Point(12, 132);
            this.textBoxEscribir.Name = "textBoxEscribir";
            this.textBoxEscribir.Size = new System.Drawing.Size(147, 20);
            this.textBoxEscribir.TabIndex = 3;
            // 
            // HilosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 193);
            this.Controls.Add(this.textBoxEscribir);
            this.Controls.Add(this.richTextBoxTexto);
            this.Controls.Add(this.labelContador);
            this.Controls.Add(this.buttonEscribir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HilosForm";
            this.Text = "Ejemplo Hilos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HilosForm_FormClosing);
            this.Load += new System.EventHandler(this.HilosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEscribir;
        private System.Windows.Forms.Label labelContador;
        private System.Windows.Forms.RichTextBox richTextBoxTexto;
        private System.Windows.Forms.TextBox textBoxEscribir;
    }
}

