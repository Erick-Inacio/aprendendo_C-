namespace PMatriz
{
    partial class Form1
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
            this.btnInverte = new System.Windows.Forms.Button();
            this.btnArmazen = new System.Windows.Forms.Button();
            this.btnListaAluno = new System.Windows.Forms.Button();
            this.btnEx5e6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInverte
            // 
            this.btnInverte.Location = new System.Drawing.Point(35, 30);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(252, 163);
            this.btnInverte.TabIndex = 0;
            this.btnInverte.Text = "1.Inverte";
            this.btnInverte.UseVisualStyleBackColor = true;
            this.btnInverte.Click += new System.EventHandler(this.btnInverte_Click);
            // 
            // btnArmazen
            // 
            this.btnArmazen.Location = new System.Drawing.Point(329, 30);
            this.btnArmazen.Name = "btnArmazen";
            this.btnArmazen.Size = new System.Drawing.Size(252, 163);
            this.btnArmazen.TabIndex = 1;
            this.btnArmazen.Text = "2.Armazém";
            this.btnArmazen.UseVisualStyleBackColor = true;
            this.btnArmazen.Click += new System.EventHandler(this.btnArmazen_Click);
            // 
            // btnListaAluno
            // 
            this.btnListaAluno.Location = new System.Drawing.Point(35, 229);
            this.btnListaAluno.Name = "btnListaAluno";
            this.btnListaAluno.Size = new System.Drawing.Size(252, 163);
            this.btnListaAluno.TabIndex = 2;
            this.btnListaAluno.Text = "4.Lista Aluno";
            this.btnListaAluno.UseVisualStyleBackColor = true;
            this.btnListaAluno.Click += new System.EventHandler(this.btnListaAluno_Click);
            // 
            // btnEx5e6
            // 
            this.btnEx5e6.Location = new System.Drawing.Point(329, 229);
            this.btnEx5e6.Name = "btnEx5e6";
            this.btnEx5e6.Size = new System.Drawing.Size(252, 163);
            this.btnEx5e6.TabIndex = 3;
            this.btnEx5e6.Text = "Exerc. 5 e 6";
            this.btnEx5e6.UseVisualStyleBackColor = true;
            this.btnEx5e6.Click += new System.EventHandler(this.btnEx5e6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.btnEx5e6);
            this.Controls.Add(this.btnListaAluno);
            this.Controls.Add(this.btnArmazen);
            this.Controls.Add(this.btnInverte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInverte;
        private System.Windows.Forms.Button btnArmazen;
        private System.Windows.Forms.Button btnListaAluno;
        private System.Windows.Forms.Button btnEx5e6;
    }
}

