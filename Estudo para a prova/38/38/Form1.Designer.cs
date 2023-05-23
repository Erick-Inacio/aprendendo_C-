namespace _38
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
            this.btnValoresDias = new System.Windows.Forms.Button();
            this.lsbxSaida = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnValoresDias
            // 
            this.btnValoresDias.Location = new System.Drawing.Point(107, 149);
            this.btnValoresDias.Name = "btnValoresDias";
            this.btnValoresDias.Size = new System.Drawing.Size(216, 103);
            this.btnValoresDias.TabIndex = 0;
            this.btnValoresDias.Text = "Inserir Valores por Dia";
            this.btnValoresDias.UseVisualStyleBackColor = true;
            this.btnValoresDias.Click += new System.EventHandler(this.btnValoresDias_Click);
            // 
            // lsbxSaida
            // 
            this.lsbxSaida.FormattingEnabled = true;
            this.lsbxSaida.Location = new System.Drawing.Point(408, 78);
            this.lsbxSaida.Name = "lsbxSaida";
            this.lsbxSaida.Size = new System.Drawing.Size(307, 238);
            this.lsbxSaida.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbxSaida);
            this.Controls.Add(this.btnValoresDias);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValoresDias;
        private System.Windows.Forms.ListBox lsbxSaida;
    }
}

