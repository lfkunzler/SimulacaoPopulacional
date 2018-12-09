namespace SimulacaoPopulacional.Views
{
    partial class frmSimulacao
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
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Tempo = new System.Windows.Forms.Label();
            this.QtdeSapos = new System.Windows.Forms.Label();
            this.QtdeMoscas = new System.Windows.Forms.Label();
            this.QtdeAcucar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Tempo
            // 
            this.Tempo.AutoSize = true;
            this.Tempo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tempo.Location = new System.Drawing.Point(715, 9);
            this.Tempo.Name = "Tempo";
            this.Tempo.Size = new System.Drawing.Size(71, 20);
            this.Tempo.TabIndex = 0;
            this.Tempo.Text = "Tempo:";
            // 
            // QtdeSapos
            // 
            this.QtdeSapos.AutoSize = true;
            this.QtdeSapos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtdeSapos.Location = new System.Drawing.Point(12, 9);
            this.QtdeSapos.Name = "QtdeSapos";
            this.QtdeSapos.Size = new System.Drawing.Size(65, 20);
            this.QtdeSapos.TabIndex = 1;
            this.QtdeSapos.Text = "Sapos:";
            // 
            // QtdeMoscas
            // 
            this.QtdeMoscas.AutoSize = true;
            this.QtdeMoscas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtdeMoscas.Location = new System.Drawing.Point(240, 9);
            this.QtdeMoscas.Name = "QtdeMoscas";
            this.QtdeMoscas.Size = new System.Drawing.Size(76, 20);
            this.QtdeMoscas.TabIndex = 2;
            this.QtdeMoscas.Text = "Moscas:";
            // 
            // QtdeAcucar
            // 
            this.QtdeAcucar.AutoSize = true;
            this.QtdeAcucar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtdeAcucar.Location = new System.Drawing.Point(479, 9);
            this.QtdeAcucar.Name = "QtdeAcucar";
            this.QtdeAcucar.Size = new System.Drawing.Size(73, 20);
            this.QtdeAcucar.TabIndex = 3;
            this.QtdeAcucar.Text = "Açucar:";
            // 
            // frmSimulacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QtdeAcucar);
            this.Controls.Add(this.QtdeMoscas);
            this.Controls.Add(this.QtdeSapos);
            this.Controls.Add(this.Tempo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSimulacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSimulacao_FormClosing);
            this.Load += new System.EventHandler(this.Simulacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label Tempo;
        private System.Windows.Forms.Label QtdeSapos;
        private System.Windows.Forms.Label QtdeMoscas;
        private System.Windows.Forms.Label QtdeAcucar;
    }
}