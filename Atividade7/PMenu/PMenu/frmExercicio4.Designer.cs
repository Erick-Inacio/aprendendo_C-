namespace PMenu
{
    partial class frmExercicio4
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
            this.btnQtdeNum = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnQtdeLetras = new System.Windows.Forms.Button();
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQtdeNum
            // 
            this.btnQtdeNum.Location = new System.Drawing.Point(512, 37);
            this.btnQtdeNum.Margin = new System.Windows.Forms.Padding(11);
            this.btnQtdeNum.Name = "btnQtdeNum";
            this.btnQtdeNum.Size = new System.Drawing.Size(203, 42);
            this.btnQtdeNum.TabIndex = 20;
            this.btnQtdeNum.Text = "Qtde Num";
            this.btnQtdeNum.UseVisualStyleBackColor = true;
            this.btnQtdeNum.Click += new System.EventHandler(this.btnQtdeNum_Click);
            // 
            // btnSpace
            // 
            this.btnSpace.Location = new System.Drawing.Point(512, 132);
            this.btnSpace.Margin = new System.Windows.Forms.Padding(11);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(203, 42);
            this.btnSpace.TabIndex = 19;
            this.btnSpace.Text = "Posição 1º Space";
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(20, 37);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(63, 24);
            this.lblTexto.TabIndex = 17;
            this.lblTexto.Text = "Texto:";
            // 
            // btnQtdeLetras
            // 
            this.btnQtdeLetras.Location = new System.Drawing.Point(512, 227);
            this.btnQtdeLetras.Margin = new System.Windows.Forms.Padding(11);
            this.btnQtdeLetras.Name = "btnQtdeLetras";
            this.btnQtdeLetras.Size = new System.Drawing.Size(203, 42);
            this.btnQtdeLetras.TabIndex = 16;
            this.btnQtdeLetras.Text = "Qtde Letras";
            this.btnQtdeLetras.UseVisualStyleBackColor = true;
            this.btnQtdeLetras.Click += new System.EventHandler(this.btnQtdeLetras_Click);
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(87, 37);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(411, 329);
            this.rchtxtTexto.TabIndex = 21;
            this.rchtxtTexto.Text = "";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(20, 386);
            this.lblResposta.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(93, 24);
            this.lblResposta.TabIndex = 22;
            this.lblResposta.Text = "Resposta:";
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(127, 383);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(159, 29);
            this.txtResposta.TabIndex = 23;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(512, 322);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(11);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(203, 42);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 749);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.rchtxtTexto);
            this.Controls.Add(this.btnQtdeNum);
            this.Controls.Add(this.btnSpace);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnQtdeLetras);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.Load += new System.EventHandler(this.frmExercicio4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQtdeNum;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnQtdeLetras;
        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Button btnLimpar;
    }
}