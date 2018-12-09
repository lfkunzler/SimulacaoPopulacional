namespace SimulacaoPopulacional.Views
{
    partial class frmTelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbQtdeSapos = new System.Windows.Forms.Label();
            this.lbQtdeMoscas = new System.Windows.Forms.Label();
            this.btIniciarSimulacao = new System.Windows.Forms.Button();
            this.tbQtdeSapos = new System.Windows.Forms.TextBox();
            this.tbQtdeMoscas = new System.Windows.Forms.TextBox();
            this.tbQtdeCal = new System.Windows.Forms.TextBox();
            this.tbQtdeAcucar = new System.Windows.Forms.TextBox();
            this.lbQtdeCal = new System.Windows.Forms.Label();
            this.lbQtdeAcucar = new System.Windows.Forms.Label();
            this.lbQtdeCalAcucar = new System.Windows.Forms.Label();
            this.tbQtdeCalRepMoscas = new System.Windows.Forms.TextBox();
            this.lbQtdeCalRepMoscas = new System.Windows.Forms.Label();
            this.tbCalAcucar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbQtdeSapos
            // 
            this.lbQtdeSapos.AutoSize = true;
            this.lbQtdeSapos.Location = new System.Drawing.Point(9, 14);
            this.lbQtdeSapos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQtdeSapos.Name = "lbQtdeSapos";
            this.lbQtdeSapos.Size = new System.Drawing.Size(180, 13);
            this.lbQtdeSapos.TabIndex = 0;
            this.lbQtdeSapos.Text = "Qtde da População de Sapos Inicial:";
            // 
            // lbQtdeMoscas
            // 
            this.lbQtdeMoscas.AutoSize = true;
            this.lbQtdeMoscas.Location = new System.Drawing.Point(9, 54);
            this.lbQtdeMoscas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQtdeMoscas.Name = "lbQtdeMoscas";
            this.lbQtdeMoscas.Size = new System.Drawing.Size(187, 13);
            this.lbQtdeMoscas.TabIndex = 1;
            this.lbQtdeMoscas.Text = "Qtde da População de Moscas Inicial:";
            // 
            // btIniciarSimulacao
            // 
            this.btIniciarSimulacao.Location = new System.Drawing.Point(113, 268);
            this.btIniciarSimulacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btIniciarSimulacao.Name = "btIniciarSimulacao";
            this.btIniciarSimulacao.Size = new System.Drawing.Size(109, 32);
            this.btIniciarSimulacao.TabIndex = 2;
            this.btIniciarSimulacao.Text = "Iniciar Simulação";
            this.btIniciarSimulacao.UseVisualStyleBackColor = true;
            this.btIniciarSimulacao.Click += new System.EventHandler(this.btIniciarSimulacao_Click);
            // 
            // tbQtdeSapos
            // 
            this.tbQtdeSapos.Location = new System.Drawing.Point(234, 11);
            this.tbQtdeSapos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQtdeSapos.Name = "tbQtdeSapos";
            this.tbQtdeSapos.Size = new System.Drawing.Size(76, 20);
            this.tbQtdeSapos.TabIndex = 3;
            this.tbQtdeSapos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtdeSapos_KeyPress);
            // 
            // tbQtdeMoscas
            // 
            this.tbQtdeMoscas.Location = new System.Drawing.Point(234, 51);
            this.tbQtdeMoscas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQtdeMoscas.Name = "tbQtdeMoscas";
            this.tbQtdeMoscas.Size = new System.Drawing.Size(76, 20);
            this.tbQtdeMoscas.TabIndex = 4;
            this.tbQtdeMoscas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtdeMoscas_KeyPress);
            // 
            // tbQtdeCal
            // 
            this.tbQtdeCal.Location = new System.Drawing.Point(234, 131);
            this.tbQtdeCal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQtdeCal.Name = "tbQtdeCal";
            this.tbQtdeCal.Size = new System.Drawing.Size(76, 20);
            this.tbQtdeCal.TabIndex = 8;
            this.tbQtdeCal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtdeCal_KeyPress);
            // 
            // tbQtdeAcucar
            // 
            this.tbQtdeAcucar.Location = new System.Drawing.Point(234, 91);
            this.tbQtdeAcucar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQtdeAcucar.Name = "tbQtdeAcucar";
            this.tbQtdeAcucar.Size = new System.Drawing.Size(76, 20);
            this.tbQtdeAcucar.TabIndex = 7;
            this.tbQtdeAcucar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtdeAcucar_KeyPress);
            // 
            // lbQtdeCal
            // 
            this.lbQtdeCal.AutoSize = true;
            this.lbQtdeCal.Location = new System.Drawing.Point(9, 133);
            this.lbQtdeCal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQtdeCal.Name = "lbQtdeCal";
            this.lbQtdeCal.Size = new System.Drawing.Size(197, 13);
            this.lbQtdeCal.TabIndex = 6;
            this.lbQtdeCal.Text = "Qtde de Calorias Inicial dos Seres Vivos:";
            // 
            // lbQtdeAcucar
            // 
            this.lbQtdeAcucar.AutoSize = true;
            this.lbQtdeAcucar.Location = new System.Drawing.Point(9, 93);
            this.lbQtdeAcucar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQtdeAcucar.Name = "lbQtdeAcucar";
            this.lbQtdeAcucar.Size = new System.Drawing.Size(126, 13);
            this.lbQtdeAcucar.TabIndex = 5;
            this.lbQtdeAcucar.Text = "Qtde de Açúcares Inicial:";
            // 
            // lbQtdeCalAcucar
            // 
            this.lbQtdeCalAcucar.AutoSize = true;
            this.lbQtdeCalAcucar.Location = new System.Drawing.Point(9, 213);
            this.lbQtdeCalAcucar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQtdeCalAcucar.Name = "lbQtdeCalAcucar";
            this.lbQtdeCalAcucar.Size = new System.Drawing.Size(173, 13);
            this.lbQtdeCalAcucar.TabIndex = 9;
            this.lbQtdeCalAcucar.Text = "Capacidade Energética do Açúcar:";
            // 
            // tbQtdeCalRepMoscas
            // 
            this.tbQtdeCalRepMoscas.Location = new System.Drawing.Point(234, 171);
            this.tbQtdeCalRepMoscas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQtdeCalRepMoscas.Name = "tbQtdeCalRepMoscas";
            this.tbQtdeCalRepMoscas.Size = new System.Drawing.Size(76, 20);
            this.tbQtdeCalRepMoscas.TabIndex = 12;
            this.tbQtdeCalRepMoscas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtdeCalRepMoscas_KeyPress);
            // 
            // lbQtdeCalRepMoscas
            // 
            this.lbQtdeCalRepMoscas.AutoSize = true;
            this.lbQtdeCalRepMoscas.Location = new System.Drawing.Point(9, 173);
            this.lbQtdeCalRepMoscas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQtdeCalRepMoscas.Name = "lbQtdeCalRepMoscas";
            this.lbQtdeCalRepMoscas.Size = new System.Drawing.Size(216, 13);
            this.lbQtdeCalRepMoscas.TabIndex = 11;
            this.lbQtdeCalRepMoscas.Text = "Qtde de Calorias p/ Reprodução de Moscas";
            this.lbQtdeCalRepMoscas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbCalAcucar
            // 
            this.tbCalAcucar.Location = new System.Drawing.Point(234, 210);
            this.tbCalAcucar.Name = "tbCalAcucar";
            this.tbCalAcucar.Size = new System.Drawing.Size(76, 20);
            this.tbCalAcucar.TabIndex = 13;
            this.tbCalAcucar.Text = "20 kCal";
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 312);
            this.Controls.Add(this.tbCalAcucar);
            this.Controls.Add(this.tbQtdeCalRepMoscas);
            this.Controls.Add(this.lbQtdeCalRepMoscas);
            this.Controls.Add(this.lbQtdeCalAcucar);
            this.Controls.Add(this.tbQtdeCal);
            this.Controls.Add(this.tbQtdeAcucar);
            this.Controls.Add(this.lbQtdeCal);
            this.Controls.Add(this.lbQtdeAcucar);
            this.Controls.Add(this.tbQtdeMoscas);
            this.Controls.Add(this.tbQtdeSapos);
            this.Controls.Add(this.btIniciarSimulacao);
            this.Controls.Add(this.lbQtdeMoscas);
            this.Controls.Add(this.lbQtdeSapos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTelaInicial";
            this.Text = "Menu de Simulação";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQtdeSapos;
        private System.Windows.Forms.Label lbQtdeMoscas;
        private System.Windows.Forms.Button btIniciarSimulacao;
        private System.Windows.Forms.TextBox tbQtdeSapos;
        private System.Windows.Forms.TextBox tbQtdeMoscas;
        private System.Windows.Forms.TextBox tbQtdeCal;
        private System.Windows.Forms.TextBox tbQtdeAcucar;
        private System.Windows.Forms.Label lbQtdeCal;
        private System.Windows.Forms.Label lbQtdeAcucar;
        private System.Windows.Forms.Label lbQtdeCalAcucar;
        private System.Windows.Forms.TextBox tbQtdeCalRepMoscas;
        private System.Windows.Forms.Label lbQtdeCalRepMoscas;
        private System.Windows.Forms.TextBox tbCalAcucar;
    }
}