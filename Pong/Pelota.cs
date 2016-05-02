using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pong
{
    class Pelota
    {
        private PictureBox bola;
        private int velocidadTotal;
        private int velocidadX;
        private int velocidadY;
        private int velocidadBase = 5;
        private int sentidoX, sentidoY;
        private Random rand;
        private Point pos;
        
        public Point Pos { get { return pos; } }
 
        public Pelota(PictureBox bola)
        {
            rand = new Random();
            this.bola = bola;
            velocidadTotal = velocidadBase;
            velocidadX = rand.Next(velocidadTotal*3/10, velocidadTotal*7/10);
            velocidadY = (int)Math.Sqrt(velocidadTotal*velocidadTotal-velocidadX*velocidadX);
            while (sentidoX == 0) { sentidoX = (byte)rand.Next(-1, 2); }
            while (sentidoY == 0) { sentidoY = (byte)rand.Next(-1, 2); }
            velocidadX *= sentidoX;
            velocidadY *= sentidoY;
            pos = bola.Location;
        }

        public void Choque(int Y)
        {
            //mira si choca. Si cierto, cambia la velocidad
            if (((pos.X <= 24 && pos.X >= 12) || (pos.X >= 760 && pos.X <= 772)) && (pos.Y >= Y || pos.Y <= Y + 50))
            {
                sentidoX *= -1;
                velocidadTotal += 1;
                velocidadX = rand.Next(velocidadTotal * 3 / 10, velocidadTotal * 7 / 10);
                velocidadY = (int)Math.Sqrt(velocidadTotal * velocidadTotal - velocidadX * velocidadX);
                velocidadX *= sentidoX;
                velocidadY *= sentidoY;
            }
        }
        
        public void Mover()
        {
            if (pos.Y + 10 >= 580 || pos.Y <= 0)
            {
                sentidoY = -sentidoY;
                velocidadY *= sentidoY;
            }

            pos.X += velocidadX;
            pos.Y += velocidadY;
            bola.Location = pos;
        }


    }
}
