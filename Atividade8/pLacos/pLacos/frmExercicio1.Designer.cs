namespace pLacos
{
    partial class frmExercicio1
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.lblFrase = new System.Windows.Forms.Label();
            this.btnEspacoBranco = new System.Windows.Forms.Button();
            this.btnNumR = new System.Windows.Forms.Button();
            this.btnParChar = new System.Windows.Forms.Button();
            this.gbxExercicio1 = new System.Windows.Forms.GroupBox();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.gbxExercicio1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(184, 35);
            this.rchtxtFrase.MaxLength = 100;
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(367, 75);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.Location = new System.Drawing.Point(131, 110);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(149, 24);
            this.lblFrase.TabIndex = 1;
            this.lblFrase.Text = "Digite uma frase:";
            // 
            // btnEspacoBranco
            // 
            this.btnEspacoBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspacoBranco.Location = new System.Drawing.Point(135, 273);
            this.btnEspacoBranco.Name = "btnEspacoBranco";
            this.btnEspacoBranco.Size = new System.Drawing.Size(118, 69);
            this.btnEspacoBranco.TabIndex = 2;
            this.btnEspacoBranco.Text = "Espaço em Branco";
            this.btnEspacoBranco.UseVisualStyleBackColor = true;
            this.btnEspacoBranco.Click += new System.EventHandler(this.btnEspacoBranco_Click);
            // 
            // btnNumR
            // 
            this.btnNumR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumR.Location = new System.Drawing.Point(335, 273);
            this.btnNumR.Name = "btnNumR";
            this.btnNumR.Size = new System.Drawing.Size(118, 69);
            this.btnNumR.TabIndex = 2;
            this.btnNumR.Text = "Qtde de \"R\"";
            this.btnNumR.UseVisualStyleBackColor = true;
            this.btnNumR.Click += new System.EventHandler(this.btnNumR_Click);
            // 
            // btnParChar
            // 
            this.btnParChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParChar.Location = new System.Drawing.Point(535, 273);
            this.btnParChar.Name = "btnParChar";
            this.btnParChar.Size = new System.Drawing.Size(118, 69);
            this.btnParChar.TabIndex = 2;
            this.btnParChar.Text = "Qtde Par de Letras Iguais";
            this.btnParChar.UseVisualStyleBackColor = true;
            this.btnParChar.Click += new System.EventHandler(this.btnParChar_Click);
            // 
            // gbxExercicio1
            // 
            this.gbxExercicio1.Controls.Add(this.txtResposta);
            this.gbxExercicio1.Controls.Add(this.lblResposta);
            this.gbxExercicio1.Controls.Add(this.rchtxtFrase);
            this.gbxExercicio1.Location = new System.Drawing.Point(102, 50);
            this.gbxExercicio1.Name = "gbxExercicio1";
            this.gbxExercicio1.Size = new System.Drawing.Size(584, 314);
            this.gbxExercicio1.TabIndex = 3;
            this.gbxExercicio1.TabStop = false;
            this.gbxExercicio1.Text = "Exercício 1";
            // 
            // txtResposta
            // 
            this.txtResposta.Enabled = false;
            this.txtResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResposta.Location = new System.Drawing.Point(184, 146);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(367, 29);
            this.txtResposta.TabIndex = 3;
            this.txtResposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(85, 149);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(93, 24);
            this.lblResposta.TabIndex = 2;
            this.lblResposta.Text = "Resposta:";
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParChar);
            this.Controls.Add(this.btnNumR);
            this.Controls.Add(this.btnEspacoBranco);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.gbxExercicio1);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.gbxExercicio1.ResumeLayout(false);
            this.gbxExercicio1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.Button btnEspacoBranco;
        private System.Windows.Forms.Button btnNumR;
        private System.Windows.Forms.Button btnParChar;
        private System.Windows.Forms.GroupBox gbxExercicio1;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txtResposta;
    }
}