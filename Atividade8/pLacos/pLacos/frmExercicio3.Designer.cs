namespace pLacos
{
    partial class frmExercicio3
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
            this.gbxExercicio3 = new System.Windows.Forms.GroupBox();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.gbxExercicio3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxExercicio3
            // 
            this.gbxExercicio3.Controls.Add(this.btnAnalizar);
            this.gbxExercicio3.Controls.Add(this.txtEntrada);
            this.gbxExercicio3.Controls.Add(this.txtResposta);
            this.gbxExercicio3.Controls.Add(this.lblResposta);
            this.gbxExercicio3.Controls.Add(this.lblNum);
            this.gbxExercicio3.Location = new System.Drawing.Point(108, 68);
            this.gbxExercicio3.Name = "gbxExercicio3";
            this.gbxExercicio3.Size = new System.Drawing.Size(584, 314);
            this.gbxExercicio3.TabIndex = 9;
            this.gbxExercicio3.TabStop = false;
            this.gbxExercicio3.Text = "Exercício 3";
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizar.Location = new System.Drawing.Point(231, 207);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(118, 69);
            this.btnAnalizar.TabIndex = 7;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(184, 60);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(367, 29);
            this.txtEntrada.TabIndex = 4;
            this.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(10, 60);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(157, 24);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "Digite uma Frase:";
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxExercicio3);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.gbxExercicio3.ResumeLayout(false);
            this.gbxExercicio3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxExercicio3;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblNum;
    }
}