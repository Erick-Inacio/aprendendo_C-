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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void eX1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio1>().Count() > 0)
            {
                Application.OpenForms["frmExercicio1"].BringToFront();
            }
            else
            {
                frmExercicio1 objEx1 = new frmExercicio1();
                objEx1.MdiParent = this;
                objEx1.WindowState = FormWindowState.Maximized;
                objEx1.Show();
            }
            
        }

        private void eX2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                Application.OpenForms["frmExercicio2"].BringToFront();
            }
            else
            {
                frmExercicio2 objEx2 = new frmExercicio2();
                objEx2.MdiParent = this;
                objEx2.WindowState = FormWindowState.Maximized;
                objEx2.Show();
            }
        }

        private void eX3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio3>().Count() > 0)
            {
                Application.OpenForms["frmExercicio3"].BringToFront();
            }
            else
            {
                frmExercicio3 objEx3 = new frmExercicio3();
                objEx3.MdiParent = this;
                objEx3.WindowState = FormWindowState.Maximized;
                objEx3.Show();
            }
        }

        private void eX4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                Application.OpenForms["frmExercicio4"].BringToFront();
            }
            else
            {
                frmExercicio4 objEx4 = new frmExercicio4();
                objEx4.MdiParent = this;
                objEx4.WindowState = FormWindowState.Maximized;
                objEx4.Show();
            }
        }

        //private int FfrmAberto(object aux)
        //{
        //    int i = 0;
        //    if (Application.OpenForms.OfType<aux>().Count() > 0)
        //    {
        //        //MessageBox.Show("Form já existe");
        //        Application.OpenForms[aux.ToString()].BringToFront();
        //        i= 1;
        //    }
        //    else
        //    {
        //        i = 0;
        //    }

        //    return i;
        //}
    }
}
