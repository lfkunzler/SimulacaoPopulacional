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

        public Posicao pos { get; set; }

        public int cal;

        public PictureBox Figura;
        public Acucar(int id, Posicao pos, Ambiente amb) 
        {
            ID = id;
     
            Ambiente = amb;
            this.pos = pos;
            cal = CAL_ACUCAR;

            Figura = new PictureBox
            {
                Image = Properties.Resources.sugar_PNG33,
                Location = new System.Drawing.Point(pos.Linha, pos.Coluna),
                Name = "acucar" + id.ToString(),
                Size = new System.Drawing.Size(50, 50),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabIndex = 0,
                TabStop = false
            };

        }
        public Posicao consulta()
        {
            Posicao aux = new Posicao(this.Figura.Top,this.Figura.Left);
            return aux;


        }


    }
}
