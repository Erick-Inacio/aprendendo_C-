namespace PMenu
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
            this.btnInverte = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInverte
            // 
            this.btnInverte.Location = new System.Drawing.Point(444, 155);
            this.btnInverte.Margin = new System.Windows.Forms.Padding(6);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(187, 87);
            this.btnInverte.TabIndex = 13;
            this.btnInverte.Text = "Inverte palavra 1";
            this.btnInverte.UseVisualStyleBackColor = true;
            this.btnInverte.Click += new System.EventHandler(this.btnInverte_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(240, 155);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(6);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(187, 87);
            this.btnReplace.TabIndex = 12;
            this.btnReplace.Text = "Remove ocorrências 1º no 2º - replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(32, 96);
            this.lblPalavra2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(81, 24);
            this.lblPalavra2.TabIndex = 11;
            this.lblPalavra2.Text = "Palavra2";
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(32, 33);
            this.lblPalavra1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(81, 24);
            this.lblPalavra1.TabIndex = 10;
            this.lblPalavra1.Text = "Palavra1";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(36, 155);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(187, 87);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove ocorrências 1º no 2º";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(188, 90);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(6);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(180, 29);
            this.txtPalavra2.TabIndex = 8;
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(188, 22);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(6);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(180, 29);
            this.txtPalavra1.TabIndex = 7;
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnInverte);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.Load += new System.EventHandler(this.frmExercicio3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInverte;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
    }
}