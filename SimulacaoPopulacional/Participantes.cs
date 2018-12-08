using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacaoPopulacional {
    abstract class Participantes {

        public int ID;
        public int Calorias;

        public int DeslocaY { get; set; }
        public int DeslocaX { get; set; }

        public Ambiente Ambiente { get; protected set; }
        public PictureBox Figura;

        public Participantes(Posicao pos, Ambiente amb, int cal)
        {
            Ambiente = amb;
            Calorias = cal;
        }

        private void RealizaMovimento()
        {
            Figura.Top += DeslocaY;
            Figura.Left += DeslocaX;
        }
    }
}
