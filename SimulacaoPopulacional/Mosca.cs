using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SimulacaoPopulacional {
    class Mosca {
        public int ID;
        public int Calorias;

        public int DeslocaY { get; set; }
        public int DeslocaX { get; set; }

        public Ambiente Ambiente { get; protected set; }

        public PictureBox Figura;

        public Mosca(Posicao pos, Ambiente amb, int cal) 
        {

        }
    }
}
