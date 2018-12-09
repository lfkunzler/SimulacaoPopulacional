using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SimulacaoPopulacional {
    class Mosca {
        public Thread tid_Mosca;

        public int ID;
        public int Calorias;

        public Posicao pos;
        public Posicao Desloca;

        public Ambiente Amb { get; protected set; }

        public PictureBox Figura;

        public Mosca(int id, Posicao pos, Ambiente amb, int cal, Thread tid) 
        {
            tid_Mosca = tid;
            ID = id;
            Calorias = cal;

            Random rnd = new Random(id * 1023);
            Desloca = new Posicao(rnd.Next() % 10  - 5, rnd.Next() % 10 - 5);

            this.pos = pos;

            Amb = amb;

            Figura = new PictureBox
            {
                Image = Properties.Resources.mosca,
                Location = new System.Drawing.Point(pos.Linha, pos.Coluna),
                Name = "mosca" + id.ToString(),
                Size = new System.Drawing.Size(50, 50),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabIndex = 0,
                TabStop = false
            };

        }

        public void Movimenta()
        {
            while (true)
            {
                Amb.s_barreira.WaitOne();

                RealizaMovimento();

                Amb.s_mutex.WaitOne(); // down
                Amb.individuos++;

                if (Amb.individuos == Amb.Sapos.Count + Amb.Moscas.Count)
                {
                    Amb.s_ambiente.Release(); // up
                    //Amb.individuos = 0;
                }
                Amb.s_mutex.Release();

                Thread.Sleep(50);
            }
        }

        private delegate void RealizaMovimentoDelegate();
        private void RealizaMovimento()
        {

            if (Figura.InvokeRequired)
            {
                RealizaMovimentoDelegate d = new RealizaMovimentoDelegate(RealizaMovimento);
                Figura.Invoke(d);

            }
            else
            {
                Figura.Top += Desloca.Linha;
                Figura.Left += Desloca.Coluna;

            }

        }
    }
}
