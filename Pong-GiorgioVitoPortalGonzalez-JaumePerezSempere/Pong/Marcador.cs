using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pong
{
    class Marcador
    {
        private byte puntIzq = 0;
        private byte puntDer = 0;
        private Label puntuador;

        public Marcador(Label Puntuador)
        {
            puntuador = Puntuador;
            puntuador.Text = puntIzq + " : " + puntDer;
            puntuador.ForeColor = Color.White;

        }

        public bool Aumentador(Jugadores ganador)
        {
            bool resultado = false;
            if (ganador == Jugadores.Izquierda)
            {
                puntIzq++;
                if (puntIzq == 5)
                {
                    resultado = true;
                }
            } else
            {
                puntDer++;
                if (puntDer == 5)
                {
                    resultado = true;
                }
            }
            puntuador.Text = puntIzq + " : " + puntDer;
            return resultado;
        }

    }
}
