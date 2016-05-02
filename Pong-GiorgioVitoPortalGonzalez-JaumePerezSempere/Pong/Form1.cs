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

        public Pong()
        {
            InitializeComponent();
            puntuación = new Marcador(PuntuaciónJugadores);

        }

        
    }
}
