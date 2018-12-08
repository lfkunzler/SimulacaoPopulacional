using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacaoPopulacional.Views
{
    public partial class frmTelaInicial : Form
    {
        private frmSimulacao frmSimulacao;
        private Simulacao simulacao;

        public frmTelaInicial(Simulacao simulacao)
        {
            this.simulacao = simulacao;
            InitializeComponent();
        }

        private void tbQtdeSapos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbQtdeMoscas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbQtdeAcucar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void tbQtdeCal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void tbQtdeCalRepMoscas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void tbQtdeCalAcucar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btIniciarSimulacao_Click(object sender, EventArgs e)
        {
            int.TryParse(tbQtdeSapos.Text, out int qtdeSapos);
            int.TryParse(tbQtdeMoscas.Text, out int qtdeMoscas);
            int.TryParse(tbQtdeAcucar.Text, out int qtdeAcucar);
            int.TryParse(tbQtdeCalRepMoscas.Text, out int qtdeRepMoscas);
            int.TryParse(tbQtdeCal.Text, out int qtdeCalIni);

            frmSimulacao = new frmSimulacao(qtdeSapos, qtdeMoscas, qtdeAcucar, qtdeCalIni, qtdeRepMoscas);
            frmSimulacao.Show();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
