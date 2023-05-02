using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triângulos
{
    public partial class frmTriangulos : Form
    {
        double ladoA, ladoB, ladoC;
        public frmTriangulos()
        {
            InitializeComponent();
        }

        private void frmTriangulos_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtLadoA.Text, out ladoA) &&
                double.TryParse(txtLadoB.Text, out ladoB) &&
                double.TryParse(txtLadoC.Text, out ladoC))
            {
                if ((ladoA < (ladoB + ladoC) && ladoA > Math.Abs(ladoB - ladoC)) &&
                (ladoB < (ladoA + ladoC) && ladoB > Math.Abs(ladoA - ladoC)) &&
                (ladoC < (ladoA + ladoC) && ladoC > Math.Abs(ladoA - ladoB)))
                {
                    if ((ladoA == ladoB) && (ladoB == ladoC))
                    {
                        MessageBox.Show("Triângulo Equilátero");
                    }
                    else if ((ladoA == ladoB) || (ladoB == ladoC) || (ladoA == ladoC))
                    {
                        MessageBox.Show("Triângulo Isósceles");
                    }
                    else
                    {
                        MessageBox.Show("Triângulo Escaleno");
                    }
                }
                else
                {
                    MessageBox.Show("Não forma um triângulo");
                }
            }
            else
            {
                MessageBox.Show("Valor inválido");
            }
        }
    }
}
