using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Pong : Form
    {
        private Marcador puntuación;
        private Raqueta jugIzquierda;
        private Raqueta jugDerecha;

        public Pong()
        {

            InitializeComponent();
            puntuación = new Marcador(PuntuaciónJugadores);
            jugIzquierda = new Raqueta(JugadorIzq, Keys.W, Keys.S);
            jugDerecha = new Raqueta(JugadorDer, Keys.Up, Keys.Down);

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

        private void Pong_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
