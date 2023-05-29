namespace PClasses
{
    partial class frmHorista
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
            this.btnInstanciar = new System.Windows.Forms.Button();
            this.gbxHomeOffice = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.txtEntradaEmpresa = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSalarioHora = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtNumHora = new System.Windows.Forms.TextBox();
            this.lblNumeroHora = new System.Windows.Forms.Label();
            this.txtDiasFalta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxHomeOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInstanciar
            // 
            this.btnInstanciar.Location = new System.Drawing.Point(36, 310);
            this.btnInstanciar.Margin = new System.Windows.Forms.Padding(6);
            this.btnInstanciar.Name = "btnInstanciar";
            this.btnInstanciar.Size = new System.Drawing.Size(745, 73);
            this.btnInstanciar.TabIndex = 20;
            this.btnInstanciar.Text = "Instanciar Horista";
            this.btnInstanciar.UseVisualStyleBackColor = true;
            this.btnInstanciar.Click += new System.EventHandler(this.btnInstanciar_Click);
            // 
            // gbxHomeOffice
            // 
            this.gbxHomeOffice.Controls.Add(this.rbtnNao);
            this.gbxHomeOffice.Controls.Add(this.rbtnSim);
            this.gbxHomeOffice.Location = new System.Drawing.Point(600, 28);
            this.gbxHomeOffice.Margin = new System.Windows.Forms.Padding(6);
            this.gbxHomeOffice.Name = "gbxHomeOffice";
            this.gbxHomeOffice.Padding = new System.Windows.Forms.Padding(6);
            this.gbxHomeOffice.Size = new System.Drawing.Size(181, 174);
            this.gbxHomeOffice.TabIndex = 19;
            this.gbxHomeOffice.TabStop = false;
            this.gbxHomeOffice.Text = "Trabalha em Home Office";
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(12, 113);
            this.rbtnNao.Margin = new System.Windows.Forms.Padding(6);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(63, 28);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "Não";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Checked = true;
            this.rbtnSim.Location = new System.Drawing.Point(12, 73);
            this.rbtnSim.Margin = new System.Windows.Forms.Padding(6);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(60, 28);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // txtEntradaEmpresa
            // 
            this.txtEntradaEmpresa.Location = new System.Drawing.Point(278, 162);
            this.txtEntradaEmpresa.Margin = new System.Windows.Forms.Padding(6);
            this.txtEntradaEmpresa.Name = "txtEntradaEmpresa";
            this.txtEntradaEmpresa.Size = new System.Drawing.Size(279, 29);
            this.txtEntradaEmpresa.TabIndex = 18;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(278, 71);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(279, 29);
            this.txtNome.TabIndex = 17;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(278, 114);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(6);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(279, 29);
            this.txtSalario.TabIndex = 16;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(278, 28);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(6);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(279, 29);
            this.txtMatricula.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data Entrada na Empresa:";
            // 
            // lblSalarioHora
            // 
            this.lblSalarioHora.AutoSize = true;
            this.lblSalarioHora.Location = new System.Drawing.Point(32, 114);
            this.lblSalarioHora.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.lblSalarioHora.Name = "lblSalarioHora";
            this.lblSalarioHora.Size = new System.Drawing.Size(118, 24);
            this.lblSalarioHora.TabIndex = 13;
            this.lblSalarioHora.Text = "Salário Hora:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(32, 71);
            this.lblNome.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 24);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(32, 28);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(90, 24);
            this.lblMatricula.TabIndex = 11;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // txtNumHora
            // 
            this.txtNumHora.Location = new System.Drawing.Point(278, 207);
            this.txtNumHora.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumHora.Name = "txtNumHora";
            this.txtNumHora.Size = new System.Drawing.Size(279, 29);
            this.txtNumHora.TabIndex = 23;
            // 
            // lblNumeroHora
            // 
            this.lblNumeroHora.AutoSize = true;
            this.lblNumeroHora.Location = new System.Drawing.Point(32, 207);
            this.lblNumeroHora.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.lblNumeroHora.Name = "lblNumeroHora";
            this.lblNumeroHora.Size = new System.Drawing.Size(130, 24);
            this.lblNumeroHora.TabIndex = 22;
            this.lblNumeroHora.Text = "Número Hora:";
            this.lblNumeroHora.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDiasFalta
            // 
            this.txtDiasFalta.Location = new System.Drawing.Point(278, 248);
            this.txtDiasFalta.Margin = new System.Windows.Forms.Padding(6);
            this.txtDiasFalta.Name = "txtDiasFalta";
            this.txtDiasFalta.Size = new System.Drawing.Size(279, 29);
            this.txtDiasFalta.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Dias Falta:";
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtDiasFalta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumHora);
            this.Controls.Add(this.lblNumeroHora);
            this.Controls.Add(this.btnInstanciar);
            this.Controls.Add(this.gbxHomeOffice);
            this.Controls.Add(this.txtEntradaEmpresa);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSalarioHora);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.Load += new System.EventHandler(this.frmHorista_Load);
            this.gbxHomeOffice.ResumeLayout(false);
            this.gbxHomeOffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInstanciar;
        private System.Windows.Forms.GroupBox gbxHomeOffice;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.TextBox txtEntradaEmpresa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSalarioHora;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtNumHora;
        private System.Windows.Forms.Label lblNumeroHora;
        private System.Windows.Forms.TextBox txtDiasFalta;
        private System.Windows.Forms.Label label2;
    }
}