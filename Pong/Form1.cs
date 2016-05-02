using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Pong
{
    public partial class Pong : Form
    {
        private Marcador puntuación;
        private Raqueta jugIzquierda;
        private Raqueta jugDerecha;
        private Pelota bola;
        private System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        

        public Pong()
        {

            InitializeComponent();
            puntuación = new Marcador(PuntuaciónJugadores);
            jugIzquierda = new Raqueta(JugadorIzq, Keys.W, Keys.S);
            jugDerecha = new Raqueta(JugadorDer, Keys.Up, Keys.Down);
            bola = new Pelota(Pelota);
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 33;
            myTimer.Start();


        }


        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            jugIzquierda.KeyDown(e.KeyCode);
            jugDerecha.KeyDown(e.KeyCode);
            
         
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            jugIzquierda.KeyUp(e.KeyCode);
            jugDerecha.KeyUp(e.KeyCode);

        }

        private void Pong_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            jugIzquierda.Actualizar();
            jugDerecha.Actualizar();
            bola.Mover();
            bola.Choque(jugDerecha.Pala.Location.Y);
            bola.Choque(jugIzquierda.Pala.Location.Y);
        }


        private void Pong_Paint(object sender, PaintEventArgs e)
        {

            
        }
    }
}
