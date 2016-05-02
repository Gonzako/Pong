namespace Pong
{
    partial class Pong
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
            this.PuntuaciónJugadores = new System.Windows.Forms.Label();
            this.JugadorDer = new System.Windows.Forms.PictureBox();
            this.JugadorIzq = new System.Windows.Forms.PictureBox();
            this.Pelota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.JugadorDer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JugadorIzq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pelota)).BeginInit();
            this.SuspendLayout();
            // 
            // PuntuaciónJugadores
            // 
            this.PuntuaciónJugadores.AutoSize = true;
            this.PuntuaciónJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuntuaciónJugadores.Location = new System.Drawing.Point(305, 9);
            this.PuntuaciónJugadores.Name = "PuntuaciónJugadores";
            this.PuntuaciónJugadores.Size = new System.Drawing.Size(210, 73);
            this.PuntuaciónJugadores.TabIndex = 0;
            this.PuntuaciónJugadores.Text = "label1";
            this.PuntuaciónJugadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JugadorDer
            // 
            this.JugadorDer.BackColor = System.Drawing.Color.LimeGreen;
            this.JugadorDer.Location = new System.Drawing.Point(760, 275);
            this.JugadorDer.Name = "JugadorDer";
            this.JugadorDer.Size = new System.Drawing.Size(12, 50);
            this.JugadorDer.TabIndex = 2;
            this.JugadorDer.TabStop = false;
            // 
            // JugadorIzq
            // 
            this.JugadorIzq.BackColor = System.Drawing.Color.LimeGreen;
            this.JugadorIzq.Location = new System.Drawing.Point(12, 275);
            this.JugadorIzq.Name = "JugadorIzq";
            this.JugadorIzq.Size = new System.Drawing.Size(12, 50);
            this.JugadorIzq.TabIndex = 3;
            this.JugadorIzq.TabStop = false;
            // 
            // Pelota
            // 
            this.Pelota.BackColor = System.Drawing.Color.Red;
            this.Pelota.Location = new System.Drawing.Point(385, 295);
            this.Pelota.Name = "Pelota";
            this.Pelota.Size = new System.Drawing.Size(10, 10);
            this.Pelota.TabIndex = 4;
            this.Pelota.TabStop = false;
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Pelota);
            this.Controls.Add(this.JugadorIzq);
            this.Controls.Add(this.JugadorDer);
            this.Controls.Add(this.PuntuaciónJugadores);
            this.MaximizeBox = false;
            this.Name = "Pong";
            this.Text = "Pong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pong_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Pong_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.JugadorDer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JugadorIzq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pelota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PuntuaciónJugadores;
        private System.Windows.Forms.PictureBox JugadorDer;
        private System.Windows.Forms.PictureBox JugadorIzq;
        private System.Windows.Forms.PictureBox Pelota;
    }
}

