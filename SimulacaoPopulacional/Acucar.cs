using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacaoPopulacional
{

    class Acucar
    {
        public const int CAL_ACUCAR = 20;

        public int ID;

        public Ambiente Ambiente { get; protected set; }

        public PictureBox Figura;
        public Acucar(Posicao pos, Ambiente amb, int cal) 
        {
         
        }


    }
}
