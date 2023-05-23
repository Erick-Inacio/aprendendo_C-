namespace Soma_e_Multiplicação_de_Arrays
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
            this.btnInput = new System.Windows.Forms.Button();
            this.txtArray1 = new System.Windows.Forms.TextBox();
            this.txtArray2 = new System.Windows.Forms.TextBox();
            this.lblArray1 = new System.Windows.Forms.Label();
            this.lblArray2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(16, 75);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(566, 72);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "InputBox";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtArray1
            // 
            this.txtArray1.Enabled = false;
            this.txtArray1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArray1.Location = new System.Drawing.Point(87, 9);
            this.txtArray1.Name = "txtArray1";
            this.txtArray1.Size = new System.Drawing.Size(495, 29);
            this.txtArray1.TabIndex = 1;
            // 
            // txtArray2
            // 
            this.txtArray2.Enabled = false;
            this.txtArray2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArray2.Location = new System.Drawing.Point(87, 40);
            this.txtArray2.Name = "txtArray2";
            this.txtArray2.Size = new System.Drawing.Size(495, 29);
            this.txtArray2.TabIndex = 1;
            // 
            // lblArray1
            // 
            this.lblArray1.AutoSize = true;
            this.lblArray1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArray1.Location = new System.Drawing.Point(12, 9);
            this.lblArray1.Name = "lblArray1";
            this.lblArray1.Size = new System.Drawing.Size(69, 24);
            this.lblArray1.TabIndex = 2;
            this.lblArray1.Text = "Array1:";
            // 
            // lblArray2
            // 
            this.lblArray2.AutoSize = true;
            this.lblArray2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArray2.Location = new System.Drawing.Point(12, 40);
            this.lblArray2.Name = "lblArray2";
            this.lblArray2.Size = new System.Drawing.Size(69, 24);
            this.lblArray2.TabIndex = 3;
            this.lblArray2.Text = "Array2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 158);
            this.Controls.Add(this.lblArray2);
            this.Controls.Add(this.lblArray1);
            this.Controls.Add(this.txtArray2);
            this.Controls.Add(this.txtArray1);
            this.Controls.Add(this.btnInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox txtArray1;
        private System.Windows.Forms.TextBox txtArray2;
        private System.Windows.Forms.Label lblArray1;
        private System.Windows.Forms.Label lblArray2;
    }
}

