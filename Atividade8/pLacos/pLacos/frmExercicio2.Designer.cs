namespace pLacos
{
    partial class frmExercicio2
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.gbxExercicio2 = new System.Windows.Forms.GroupBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.gbxExercicio2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(231, 207);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 69);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(10, 60);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(168, 24);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "Digite um Número:";
            // 
            // gbxExercicio2
            // 
            this.gbxExercicio2.Controls.Add(this.btnCalcular);
            this.gbxExercicio2.Controls.Add(this.txtEntrada);
            this.gbxExercicio2.Controls.Add(this.txtResposta);
            this.gbxExercicio2.Controls.Add(this.lblResposta);
            this.gbxExercicio2.Controls.Add(this.lblNum);
            this.gbxExercicio2.Location = new System.Drawing.Point(108, 68);
            this.gbxExercicio2.Name = "gbxExercicio2";
            this.gbxExercicio2.Size = new System.Drawing.Size(584, 314);
            this.gbxExercicio2.TabIndex = 8;
            this.gbxExercicio2.TabStop = false;
            this.gbxExercicio2.Text = "Exercício 2";
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
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxExercicio2);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.gbxExercicio2.ResumeLayout(false);
            this.gbxExercicio2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.GroupBox gbxExercicio2;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txtEntrada;
    }
}