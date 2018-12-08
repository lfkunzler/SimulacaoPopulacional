using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacaoPopulacional.Views {
    public partial class frmSimulacao : Form {
        Ambiente ambiente;

        public frmSimulacao(int qtdeSapos, int qtdeMoscas, int qtdeAcucar, int qtdeCalIni, int qtdeRepMoscas)
        {
            InitializeComponent();

            ambiente = new Ambiente(
                qtdeSapos,
                qtdeMoscas,
                qtdeAcucar,
                Screen.PrimaryScreen.Bounds.Width,
                Screen.PrimaryScreen.Bounds.Height,
                qtdeCalIni,
                qtdeRepMoscas);
        }

        private void Simulacao_Load(object sender, EventArgs e)
        {
            foreach (Sapo aux in ambiente.Sapos) {
                Controls.Add(aux.Figura);
            }
        }
    }
}
