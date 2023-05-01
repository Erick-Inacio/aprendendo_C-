namespace PMenu
{
    partial class frmExercicio5
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtSorteado = new System.Windows.Forms.TextBox();
            this.lblSorteado = new System.Windows.Forms.Label();
            this.btnSortear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(24, 24);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(71, 24);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Núm 1:";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(24, 68);
            this.lblNum2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(71, 24);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Núm 2:";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(105, 21);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(136, 29);
            this.txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(105, 65);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(136, 29);
            this.txtNumero2.TabIndex = 3;
            // 
            // txtSorteado
            // 
            this.txtSorteado.Location = new System.Drawing.Point(132, 148);
            this.txtSorteado.Name = "txtSorteado";
            this.txtSorteado.Size = new System.Drawing.Size(109, 29);
            this.txtSorteado.TabIndex = 5;
            // 
            // lblSorteado
            // 
            this.lblSorteado.AutoSize = true;
            this.lblSorteado.Location = new System.Drawing.Point(24, 151);
            this.lblSorteado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSorteado.Name = "lblSorteado";
            this.lblSorteado.Size = new System.Drawing.Size(99, 24);
            this.lblSorteado.TabIndex = 4;
            this.lblSorteado.Text = "Núm Sort.:";
            // 
            // btnSortear
            // 
            this.btnSortear.Location = new System.Drawing.Point(247, 21);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(110, 73);
            this.btnSortear.TabIndex = 6;
            this.btnSortear.Text = "button1";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 749);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.txtSorteado);
            this.Controls.Add(this.lblSorteado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtSorteado;
        private System.Windows.Forms.Label lblSorteado;
        private System.Windows.Forms.Button btnSortear;
    }
}