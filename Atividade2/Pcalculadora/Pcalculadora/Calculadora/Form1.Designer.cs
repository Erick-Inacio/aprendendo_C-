namespace Calculadora
{
    partial class frmCalculadora
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número 2";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(99, 9);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(221, 20);
            this.txtNum1.TabIndex = 3;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            this.txtNum1.Validated += new System.EventHandler(this.txtNum1_Validated);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(99, 45);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(221, 20);
            this.txtNum2.TabIndex = 4;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            this.txtNum2.Validated += new System.EventHandler(this.txtNum2_Validated);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(335, 9);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 38);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(335, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(11, 124);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(101, 38);
            this.btnMais.TabIndex = 7;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click_1);
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(118, 124);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(101, 38);
            this.btnMenos.TabIndex = 8;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(228, 124);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(101, 38);
            this.btnMulti.TabIndex = 9;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(335, 124);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(101, 38);
            this.btnDivisao.TabIndex = 10;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtResultado.Enabled = false;
            this.txtResultado.ForeColor = System.Drawing.Color.Black;
            this.txtResultado.Location = new System.Drawing.Point(99, 88);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(221, 20);
            this.txtResultado.TabIndex = 12;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Resultado";
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 174);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label1;
    }
}

