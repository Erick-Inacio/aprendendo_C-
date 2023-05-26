namespace PSalario
{
    partial class frmCalculo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblDescIrpf = new System.Windows.Forms.Label();
            this.lblAliquitaInss = new System.Windows.Forms.Label();
            this.lblAliquitaIrpf = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.lblDescInss = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.txtAliquotaInss = new System.Windows.Forms.TextBox();
            this.txtAliquotaIrpf = new System.Windows.Forms.TextBox();
            this.txtSalFamilia = new System.Windows.Forms.TextBox();
            this.txtDescIrpf = new System.Windows.Forms.TextBox();
            this.txtDescInss = new System.Windows.Forms.TextBox();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.gbxGenero = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.nudNumFilhos = new System.Windows.Forms.NumericUpDown();
            this.gbxEstCivil = new System.Windows.Forms.GroupBox();
            this.rbtnDivorciado = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.rbtnSolteiro = new System.Windows.Forms.RadioButton();
            this.btnVerificarDesc = new System.Windows.Forms.Button();
            this.mskbxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.gbxGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumFilhos)).BeginInit();
            this.gbxEstCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFunc.Location = new System.Drawing.Point(22, 37);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(178, 24);
            this.lblNomeFunc.TabIndex = 0;
            this.lblNomeFunc.Text = "Nome Funcionário: ";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalBruto.Location = new System.Drawing.Point(22, 75);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(121, 24);
            this.lblSalBruto.TabIndex = 1;
            this.lblSalBruto.Text = "Salário Bruto:";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFilhos.Location = new System.Drawing.Point(22, 113);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(167, 24);
            this.lblNumFilhos.TabIndex = 2;
            this.lblNumFilhos.Text = "Número de Filhos:";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(22, 209);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(105, 24);
            this.lblMensagem.TabIndex = 3;
            this.lblMensagem.Text = "Mensagem";
            // 
            // lblDescIrpf
            // 
            this.lblDescIrpf.AutoSize = true;
            this.lblDescIrpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescIrpf.Location = new System.Drawing.Point(433, 301);
            this.lblDescIrpf.Name = "lblDescIrpf";
            this.lblDescIrpf.Size = new System.Drawing.Size(141, 24);
            this.lblDescIrpf.TabIndex = 4;
            this.lblDescIrpf.Text = "Desconto IRPF:";
            // 
            // lblAliquitaInss
            // 
            this.lblAliquitaInss.AutoSize = true;
            this.lblAliquitaInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliquitaInss.Location = new System.Drawing.Point(22, 271);
            this.lblAliquitaInss.Name = "lblAliquitaInss";
            this.lblAliquitaInss.Size = new System.Drawing.Size(123, 24);
            this.lblAliquitaInss.TabIndex = 5;
            this.lblAliquitaInss.Text = "Alíquita INSS:";
            // 
            // lblAliquitaIrpf
            // 
            this.lblAliquitaIrpf.AutoSize = true;
            this.lblAliquitaIrpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliquitaIrpf.Location = new System.Drawing.Point(22, 309);
            this.lblAliquitaIrpf.Name = "lblAliquitaIrpf";
            this.lblAliquitaIrpf.Size = new System.Drawing.Size(129, 24);
            this.lblAliquitaIrpf.TabIndex = 6;
            this.lblAliquitaIrpf.Text = "Alíquota IRPF:";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalFamilia.Location = new System.Drawing.Point(22, 347);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(137, 24);
            this.lblSalFamilia.TabIndex = 7;
            this.lblSalFamilia.Text = "Salário Família:";
            // 
            // lblSalLiquido
            // 
            this.lblSalLiquido.AutoSize = true;
            this.lblSalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalLiquido.Location = new System.Drawing.Point(22, 385);
            this.lblSalLiquido.Name = "lblSalLiquido";
            this.lblSalLiquido.Size = new System.Drawing.Size(139, 24);
            this.lblSalLiquido.TabIndex = 8;
            this.lblSalLiquido.Text = "Salário Liquído:";
            // 
            // lblDescInss
            // 
            this.lblDescInss.AutoSize = true;
            this.lblDescInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescInss.Location = new System.Drawing.Point(433, 268);
            this.lblDescInss.Name = "lblDescInss";
            this.lblDescInss.Size = new System.Drawing.Size(142, 24);
            this.lblDescInss.TabIndex = 9;
            this.lblDescInss.Text = "Desconto INSS:";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFunc.Location = new System.Drawing.Point(206, 34);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(200, 29);
            this.txtNomeFunc.TabIndex = 10;
            this.txtNomeFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAliquotaInss
            // 
            this.txtAliquotaInss.Enabled = false;
            this.txtAliquotaInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliquotaInss.Location = new System.Drawing.Point(206, 268);
            this.txtAliquotaInss.Name = "txtAliquotaInss";
            this.txtAliquotaInss.Size = new System.Drawing.Size(200, 29);
            this.txtAliquotaInss.TabIndex = 11;
            this.txtAliquotaInss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAliquotaIrpf
            // 
            this.txtAliquotaIrpf.Enabled = false;
            this.txtAliquotaIrpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliquotaIrpf.Location = new System.Drawing.Point(206, 306);
            this.txtAliquotaIrpf.Name = "txtAliquotaIrpf";
            this.txtAliquotaIrpf.Size = new System.Drawing.Size(200, 29);
            this.txtAliquotaIrpf.TabIndex = 12;
            this.txtAliquotaIrpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Enabled = false;
            this.txtSalFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalFamilia.Location = new System.Drawing.Point(206, 344);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.Size = new System.Drawing.Size(200, 29);
            this.txtSalFamilia.TabIndex = 13;
            this.txtSalFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescIrpf
            // 
            this.txtDescIrpf.Enabled = false;
            this.txtDescIrpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescIrpf.Location = new System.Drawing.Point(580, 303);
            this.txtDescIrpf.Name = "txtDescIrpf";
            this.txtDescIrpf.Size = new System.Drawing.Size(200, 29);
            this.txtDescIrpf.TabIndex = 14;
            this.txtDescIrpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescInss
            // 
            this.txtDescInss.Enabled = false;
            this.txtDescInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescInss.Location = new System.Drawing.Point(581, 268);
            this.txtDescInss.Name = "txtDescInss";
            this.txtDescInss.Size = new System.Drawing.Size(200, 29);
            this.txtDescInss.TabIndex = 15;
            this.txtDescInss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Enabled = false;
            this.txtSalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalLiquido.Location = new System.Drawing.Point(206, 382);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.Size = new System.Drawing.Size(200, 29);
            this.txtSalLiquido.TabIndex = 16;
            this.txtSalLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbxGenero
            // 
            this.gbxGenero.Controls.Add(this.rbtnMasculino);
            this.gbxGenero.Controls.Add(this.rbtnFeminino);
            this.gbxGenero.Location = new System.Drawing.Point(462, 37);
            this.gbxGenero.Name = "gbxGenero";
            this.gbxGenero.Size = new System.Drawing.Size(137, 100);
            this.gbxGenero.TabIndex = 17;
            this.gbxGenero.TabStop = false;
            this.gbxGenero.Text = "Gênero";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(6, 61);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Checked = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(6, 22);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtnFeminino.TabIndex = 0;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // nudNumFilhos
            // 
            this.nudNumFilhos.Location = new System.Drawing.Point(206, 117);
            this.nudNumFilhos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumFilhos.Name = "nudNumFilhos";
            this.nudNumFilhos.Size = new System.Drawing.Size(200, 20);
            this.nudNumFilhos.TabIndex = 18;
            this.nudNumFilhos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbxEstCivil
            // 
            this.gbxEstCivil.Controls.Add(this.rbtnDivorciado);
            this.gbxEstCivil.Controls.Add(this.rbtnCasado);
            this.gbxEstCivil.Controls.Add(this.rbtnSolteiro);
            this.gbxEstCivil.Location = new System.Drawing.Point(616, 37);
            this.gbxEstCivil.Name = "gbxEstCivil";
            this.gbxEstCivil.Size = new System.Drawing.Size(138, 100);
            this.gbxEstCivil.TabIndex = 19;
            this.gbxEstCivil.TabStop = false;
            this.gbxEstCivil.Text = "Estado Civíl";
            // 
            // rbtnDivorciado
            // 
            this.rbtnDivorciado.AutoSize = true;
            this.rbtnDivorciado.Location = new System.Drawing.Point(6, 65);
            this.rbtnDivorciado.Name = "rbtnDivorciado";
            this.rbtnDivorciado.Size = new System.Drawing.Size(76, 17);
            this.rbtnDivorciado.TabIndex = 5;
            this.rbtnDivorciado.Text = "Divorciado";
            this.rbtnDivorciado.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Location = new System.Drawing.Point(6, 42);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(61, 17);
            this.rbtnCasado.TabIndex = 4;
            this.rbtnCasado.Text = "Casado";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // rbtnSolteiro
            // 
            this.rbtnSolteiro.AutoSize = true;
            this.rbtnSolteiro.Checked = true;
            this.rbtnSolteiro.Location = new System.Drawing.Point(6, 19);
            this.rbtnSolteiro.Name = "rbtnSolteiro";
            this.rbtnSolteiro.Size = new System.Drawing.Size(60, 17);
            this.rbtnSolteiro.TabIndex = 3;
            this.rbtnSolteiro.TabStop = true;
            this.rbtnSolteiro.Text = "Solteiro";
            this.rbtnSolteiro.UseVisualStyleBackColor = true;
            // 
            // btnVerificarDesc
            // 
            this.btnVerificarDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarDesc.Location = new System.Drawing.Point(206, 166);
            this.btnVerificarDesc.Name = "btnVerificarDesc";
            this.btnVerificarDesc.Size = new System.Drawing.Size(200, 35);
            this.btnVerificarDesc.TabIndex = 20;
            this.btnVerificarDesc.Text = "Verificar Descontos";
            this.btnVerificarDesc.UseVisualStyleBackColor = true;
            this.btnVerificarDesc.Click += new System.EventHandler(this.btnVerificarDesc_Click);
            // 
            // mskbxSalBruto
            // 
            this.mskbxSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalBruto.Location = new System.Drawing.Point(206, 78);
            this.mskbxSalBruto.Mask = "##000.00";
            this.mskbxSalBruto.Name = "mskbxSalBruto";
            this.mskbxSalBruto.Size = new System.Drawing.Size(200, 29);
            this.mskbxSalBruto.TabIndex = 21;
            this.mskbxSalBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.mskbxSalBruto);
            this.Controls.Add(this.btnVerificarDesc);
            this.Controls.Add(this.gbxEstCivil);
            this.Controls.Add(this.nudNumFilhos);
            this.Controls.Add(this.gbxGenero);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.txtDescInss);
            this.Controls.Add(this.txtDescIrpf);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.txtAliquotaIrpf);
            this.Controls.Add(this.txtAliquotaInss);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.lblDescInss);
            this.Controls.Add(this.lblSalLiquido);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblAliquitaIrpf);
            this.Controls.Add(this.lblAliquitaInss);
            this.Controls.Add(this.lblDescIrpf);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNomeFunc);
            this.Name = "frmCalculo";
            this.Text = "Cálculo";
            this.Load += new System.EventHandler(this.frmCalculo_Load);
            this.gbxGenero.ResumeLayout(false);
            this.gbxGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumFilhos)).EndInit();
            this.gbxEstCivil.ResumeLayout(false);
            this.gbxEstCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblDescIrpf;
        private System.Windows.Forms.Label lblAliquitaInss;
        private System.Windows.Forms.Label lblAliquitaIrpf;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblSalLiquido;
        private System.Windows.Forms.Label lblDescInss;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.TextBox txtAliquotaInss;
        private System.Windows.Forms.TextBox txtAliquotaIrpf;
        private System.Windows.Forms.TextBox txtSalFamilia;
        private System.Windows.Forms.TextBox txtDescIrpf;
        private System.Windows.Forms.TextBox txtDescInss;
        private System.Windows.Forms.TextBox txtSalLiquido;
        private System.Windows.Forms.GroupBox gbxGenero;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.NumericUpDown nudNumFilhos;
        private System.Windows.Forms.GroupBox gbxEstCivil;
        private System.Windows.Forms.RadioButton rbtnDivorciado;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.RadioButton rbtnSolteiro;
        private System.Windows.Forms.Button btnVerificarDesc;
        private System.Windows.Forms.MaskedTextBox mskbxSalBruto;
    }
}

