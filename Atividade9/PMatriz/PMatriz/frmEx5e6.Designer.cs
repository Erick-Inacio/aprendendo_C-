namespace PMatriz
{
    partial class frmEx5e6
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
            this.btnListaAluno = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.lstbxSaida = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListaAluno
            // 
            this.btnListaAluno.Location = new System.Drawing.Point(26, 230);
            this.btnListaAluno.Name = "btnListaAluno";
            this.btnListaAluno.Size = new System.Drawing.Size(252, 163);
            this.btnListaAluno.TabIndex = 4;
            this.btnListaAluno.Text = "6.Lista Aluno";
            this.btnListaAluno.UseVisualStyleBackColor = true;
            this.btnListaAluno.Click += new System.EventHandler(this.btnListaAluno_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(26, 38);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(252, 163);
            this.btnMedia.TabIndex = 3;
            this.btnMedia.Text = "5.Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // lstbxSaida
            // 
            this.lstbxSaida.FormattingEnabled = true;
            this.lstbxSaida.Location = new System.Drawing.Point(347, 38);
            this.lstbxSaida.Name = "lstbxSaida";
            this.lstbxSaida.Size = new System.Drawing.Size(389, 355);
            this.lstbxSaida.TabIndex = 5;
            // 
            // frmEx5e6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbxSaida);
            this.Controls.Add(this.btnListaAluno);
            this.Controls.Add(this.btnMedia);
            this.Name = "frmEx5e6";
            this.Text = "frmEx5e6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaAluno;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.ListBox lstbxSaida;
    }
}