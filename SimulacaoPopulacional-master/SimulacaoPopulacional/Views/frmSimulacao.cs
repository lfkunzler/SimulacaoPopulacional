using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacaoPopulacional.Views
{
    public partial class frmSimulacao : Form
    {
        Ambiente ambiente;
        int tempo;

        public frmSimulacao(int qtdeSapos, int qtdeMoscas, int qtdeAcucar, int qtdeCalIni, int qtdeRepMoscas)
        {
            InitializeComponent();

            ambiente = new Ambiente(
                qtdeSapos,
                qtdeMoscas,
                qtdeAcucar,
                Screen.PrimaryScreen.Bounds.Width - 50,
                Screen.PrimaryScreen.Bounds.Height - 100,
                qtdeCalIni,
                qtdeRepMoscas,
                this);
        }

        private void Simulacao_Load(object sender, EventArgs e)
        {
            foreach (Sapo aux in ambiente.Sapos)
            {
                Controls.Add(aux.Figura);

                aux.tid_Sapo.Start();
            }
            foreach (Mosca aux in ambiente.Moscas)
            {
                Controls.Add(aux.Figura);

                aux.tid_Mosca.Start();
            }
            foreach (Acucar aux in ambiente.Acucares)
            {
                Controls.Add(aux.Figura);
            }
            ambiente.s_ambiente.Release();
        }

        private delegate void AdicionaAcucarDelegate(PictureBox acucar);
        private void AdicionaAcucar(PictureBox acucar)
        {
            if (InvokeRequired)
            {
                AdicionaAcucarDelegate d = new AdicionaAcucarDelegate(AdicionaAcucar);
                Invoke(d, new object[] { acucar });
            }
            else
            {
                Controls.Add(acucar);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tempo++;
            if (tempo % 5 == 0)
            {
                Random rnd = new Random();
                Posicao pos = new Posicao(rnd.Next(0, ambiente.largura), rnd.Next(0, ambiente.altura));
                Acucar auxacucar = new Acucar(ambiente.Acucares.Count, pos, ambiente);
                ambiente.Acucares.Add(auxacucar);
                AdicionaAcucar(auxacucar.Figura);
            }
            TimeSpan valor = TimeSpan.FromSeconds(tempo);
            Tempo.Text = "Tempo: " + valor.Hours.ToString("D2") + ":" + valor.Minutes.ToString("D2") + ":" + valor.Seconds.ToString("D2");
            QtdeAcucar.Text = "Açucar: " + ambiente.Acucares.Count.ToString("D2");
            QtdeMoscas.Text = "Moscas: " + ambiente.Moscas.Count.ToString("D2");
            QtdeSapos.Text = "Sapos: " + ambiente.Sapos.Count.ToString("D2");
            foreach (Mosca aux in ambiente.Moscas)
            {
                aux.Calorias--;
            }
            foreach (Sapo aux in ambiente.Sapos)
            {
                aux.Calorias--;
            }

        }

        private void frmSimulacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Sapo aux in ambiente.Sapos)
            {
                aux.tid_Sapo.Abort();
                aux.Figura.Dispose();
            }
            foreach (Mosca aux in ambiente.Moscas)
            {
                aux.tid_Mosca.Abort();
                aux.Figura.Dispose();
            }
            ambiente.tid_amb.Abort();

        }

    }

}
