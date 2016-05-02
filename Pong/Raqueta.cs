using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pong
{
    class Raqueta
    {
        private bool esKeyUpPresionada;
        private bool esKeyDownPresionada;
        private PictureBox pala;
        private Keys arriba;
        private Keys abajo;
        private Point pos;

        public PictureBox Pala { get { return pala; } }

        public Raqueta(PictureBox pala, Keys arriba, Keys abajo)
        {
            this.pala = pala;
            this.arriba = arriba;
            this.abajo = abajo;
            pos = pala.Location;
        }

        public void KeyDown(Keys key)
        {

            if (key == arriba) esKeyUpPresionada = true; // arriba = tecla para subir la raqueta

            if (key == abajo) esKeyDownPresionada = true; // abajo = tecla para bajarla

        }

        public void KeyUp(Keys key)
        {

            if (key == arriba) esKeyUpPresionada = false;

            if (key == abajo) esKeyDownPresionada = false;

        }

        public void Actualizar()
        {
            if (esKeyDownPresionada) { this.Abajo(); }
            if (esKeyUpPresionada) { this.Arriba(); }
        }

        private void Arriba()
        {
            if (pala.Location.Y >= 20)
            {
                pos.Y -= 5;
                pala.Location = pos;
            }

        }


        private void Abajo()
        {
            if ((pala.Location.Y+pala.Size.Height) < 550)
            {
                pos.Y += 5;
                pala.Location = pos;
            }

        }

    }
}
