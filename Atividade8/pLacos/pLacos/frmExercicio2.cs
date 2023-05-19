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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double h = 0;
            int n;

            if(int.TryParse(txtEntrada.Text, out n) && n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    h += (1.0 / i);
                }
            }
            else
            {
                MessageBox.Show("Digite apenas número maior que zero");
            }
            txtResposta.Text = h.ToString("N5");
        }
    }
}
