using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing

namespace Pong
{
    class Pelota
    {
        private PictureBox bola;
        private int velocidadTotal;
        private int velocidadX;
        private int velocidadY;
        private int velocidadBase = 25;
        private byte sentidoX, sentidoY;
        private Random rand;
        private Point pos;

        public Pelota(PictureBox bola)
        {
            rand = new Random();
            this.bola = bola;
            velocidadTotal = velocidadBase;
            velocidadX = rand.Next(velocidadTotal*20/100, velocidadTotal*70/100);
            velocidadY = (int)Math.Sqrt(velocidadTotal*velocidadTotal-velocidadX*velocidadX);
            while (sentidoX == 0) { sentidoX = (byte)rand.Next(-1, 2); }
            while (sentidoY == 0) { sentidoY = (byte)rand.Next(-1, 2); }
            velocidadX *= sentidoX;
            velocidadY *= sentidoY;
        }
       

    }
}
