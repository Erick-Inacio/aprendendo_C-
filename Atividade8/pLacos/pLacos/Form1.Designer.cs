namespace pLacos
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eX1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eX2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eX3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eX4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eX1ToolStripMenuItem,
            this.eX2ToolStripMenuItem,
            this.eX3ToolStripMenuItem,
            this.eX4ToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eX1ToolStripMenuItem
            // 
            this.eX1ToolStripMenuItem.Name = "eX1ToolStripMenuItem";
            this.eX1ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.eX1ToolStripMenuItem.Text = "EX.1";
            this.eX1ToolStripMenuItem.Click += new System.EventHandler(this.eX1ToolStripMenuItem_Click);
            // 
            // eX2ToolStripMenuItem
            // 
            this.eX2ToolStripMenuItem.Name = "eX2ToolStripMenuItem";
            this.eX2ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.eX2ToolStripMenuItem.Text = "EX.2";
            this.eX2ToolStripMenuItem.Click += new System.EventHandler(this.eX2ToolStripMenuItem_Click);
            // 
            // eX3ToolStripMenuItem
            // 
            this.eX3ToolStripMenuItem.Name = "eX3ToolStripMenuItem";
            this.eX3ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.eX3ToolStripMenuItem.Text = "EX.3";
            this.eX3ToolStripMenuItem.Click += new System.EventHandler(this.eX3ToolStripMenuItem_Click);
            // 
            // eX4ToolStripMenuItem
            // 
            this.eX4ToolStripMenuItem.Name = "eX4ToolStripMenuItem";
            this.eX4ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.eX4ToolStripMenuItem.Text = "EX.4";
            this.eX4ToolStripMenuItem.Click += new System.EventHandler(this.eX4ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eX1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eX2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eX3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eX4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

