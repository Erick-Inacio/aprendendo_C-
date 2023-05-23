using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pLacos
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {/////

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void eX1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmExercicio1>("frmExercicio1");
        }

        private void eX2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmExercicio2>("frmExercicio2");
        }

        private void eX3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmExercicio3>("frmExercicio3");
        }

        private void eX4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmExercicio4>("frmExercicio4");
        }

        private void AbrirFormulario<T>(string formularioName) where T : Form, new()
        {
            var formulario = Application.OpenForms.OfType<T>().FirstOrDefault();
            if (formulario != null)
            {
                formulario.BringToFront();
            }
            else
            {
                formulario = new T();
                formulario.MdiParent = this;
                formulario.WindowState = FormWindowState.Maximized;
                formulario.Show();
            }
        }
    }
}
