namespace Triângulos
{
    partial class frmTriangulos
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
            this.btnTeste = new System.Windows.Forms.Button();
            this.lblLadoA = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(19, 165);
            this.btnTeste.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(77, 42);
            this.btnTeste.TabIndex = 0;
            this.btnTeste.Text = "Testar";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Location = new System.Drawing.Point(15, 21);
            this.lblLadoA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(80, 24);
            this.lblLadoA.TabIndex = 1;
            this.lblLadoA.Text = "Lado A: ";
            // 
            // lblNum3
            // 
            this.lblNum3.AutoSize = true;
            this.lblNum3.Location = new System.Drawing.Point(15, 124);
            this.lblNum3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(80, 24);
            this.lblNum3.TabIndex = 2;
            this.lblNum3.Text = "Lado C: ";
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Location = new System.Drawing.Point(15, 72);
            this.lblLadoB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(79, 24);
            this.lblLadoB.TabIndex = 3;
            this.lblLadoB.Text = "Lado B: ";
            // 
            // txtLadoA
            // 
            this.txtLadoA.Location = new System.Drawing.Point(116, 18);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(157, 29);
            this.txtLadoA.TabIndex = 4;
            //this.txtLadoA.Validated += new System.EventHandler(this.txtLadoA_Validated);
            // 
            // txtLadoB
            // 
            this.txtLadoB.Location = new System.Drawing.Point(116, 69);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(157, 29);
            this.txtLadoB.TabIndex = 5;
            //this.txtLadoB.Validated += new System.EventHandler(this.txtLadoB_Validated);
            // 
            // txtLadoC
            // 
            this.txtLadoC.Location = new System.Drawing.Point(116, 120);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(157, 29);
            this.txtLadoC.TabIndex = 6;
            //this.txtLadoC.Validated += new System.EventHandler(this.txtLadoC_Validated);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(196, 165);
            this.btnSair.Margin = new System.Windows.Forms.Padding(6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 42);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(107, 165);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(6);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(77, 42);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmTriangulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 222);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.lblLadoA);
            this.Controls.Add(this.btnTeste);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmTriangulos";
            this.Text = "Triângulos";
            this.Load += new System.EventHandler(this.frmTriangulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
    }
}

