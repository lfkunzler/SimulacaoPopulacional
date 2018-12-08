using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacaoPopulacional {
    class Sapo {
        public int ID;
        public int Calorias;

        public int DeslocaY { get; set; }
        public int DeslocaX { get; set; }

        public Ambiente Ambiente { get; protected set; }

        public PictureBox Figura;

        public Sapo(int id, Posicao pos, Ambiente amb, int cal)
        {        
            ID = id;
            Calorias = cal;

            DeslocaX = 0;
            DeslocaY = 0;

            Ambiente = amb;

            Figura = new PictureBox {
                Image = Properties.Resources.sapo,
                Location = new System.Drawing.Point(pos.Linha, pos.Coluna),
                Name = "sapo" + id.ToString(),
                Size = new System.Drawing.Size(50, 50),
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                TabIndex = 0,
                TabStop = false
            };            
        }

        private void RealizaMovimento()
        {
            Figura.Top += DeslocaY;
            Figura.Left += DeslocaX;
        }

    }
}
