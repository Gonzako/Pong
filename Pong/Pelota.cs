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
        private float velocidadTotal;
        private float velocidadX;
        private float velocidadY;
        private int velocidadBase = 5;
        private int sentidoX = 0, sentidoY = 0;
        private Random rand;
        private Point pos;
        
        public Point Pos { get { return pos; } }
 
        public Pelota(PictureBox bola)
        {
            sentidoX = 0;
            sentidoY = 0;
            rand = new Random();
            this.bola = bola;
            velocidadTotal = velocidadBase;
            velocidadX = rand.Next(((int)velocidadTotal*5/10), ((int)velocidadTotal*9/10));
            velocidadY = (int)Math.Sqrt(velocidadTotal*velocidadTotal-velocidadX*velocidadX);
            while (sentidoX == 0)sentidoX = rand.Next(-1, 2);
            while (sentidoY==0)sentidoY = rand.Next(-1, 2);
            velocidadX *= sentidoX;
            velocidadY *= sentidoY;
            pos = bola.Location;
        }

        public void Choque(int Y, Jugadores jugador)
        {
            //mira si choca. Si cierto, cambia la velocidad
            bool lado;
            if (jugador == Jugadores.Derecha) lado = pos.X >= 755 && pos.X <= 767;
            else lado = pos.X <= 24 && pos.X >= 12;

            if ( lado && (pos.Y+10 >= Y && pos.Y <= Y + 50))
            {
                velocidadTotal += 1;
                
                velocidadX = rand.Next((int)velocidadTotal * 5 / 10, (int)velocidadTotal * 9 / 10);
                velocidadY = (int)Math.Sqrt(velocidadTotal * velocidadTotal - velocidadX * velocidadX);
                if (pos.X >= 755 && pos.X <= 767)
                {
                    velocidadX *= -1;
                    sentidoX = -1;
                }
                else sentidoX = 1;
                velocidadY *= sentidoY;

            }
        }
        
        public void reset()
        {
            pos = new Point(385, 295);
            bola.Location = pos;
            velocidadTotal = velocidadBase;
            velocidadX = rand.Next((int)velocidadTotal * 5 / 10, (int)velocidadTotal * 9 / 10);
            velocidadY = (int)Math.Sqrt(velocidadTotal * velocidadTotal - velocidadX * velocidadX);
            sentidoX *= -1;
            sentidoY *= -1;
            velocidadX *= sentidoX;
            while (sentidoY == 0) sentidoY = rand.Next(-1, 2);
            pos = bola.Location;
        }

        public void Mover()
        {
            if (pos.Y + 10 >= 565 && velocidadY>0)
            {
                sentidoY = -sentidoY;
                velocidadY *= -1;
            } else if (pos.Y <= 2 && velocidadY < 0)
            {
                sentidoY = -sentidoY;
                velocidadY *= -1;
            }

            pos.X += (int)velocidadX;
            pos.Y += (int)velocidadY;
            bola.Location = pos;
        }


    }
}
 