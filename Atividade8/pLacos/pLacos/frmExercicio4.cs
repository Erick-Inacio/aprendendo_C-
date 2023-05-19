using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pLacos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario, producao, gratif, bruto;


            if (double.TryParse(txtSalario.Text, out salario) &&
                double.TryParse(txtProducao.Text, out producao) &&
                double.TryParse(txtGratificacao.Text, out gratif))
            {
                int b = 0, c = 0, d = 0;

                fTestaProducao(producao, ref b, ref c, ref d);

                bruto = salario + salario * ((0.05 * b) + (0.1 * c) + (0.1 * d)) + gratif;

                if (bruto > 7000)
                {
                    if (!(producao >= 150 && gratif > 0))
                    {
                        bruto = 7000;
                    }
                }

                MessageBox.Show("Nome: " + txtNome.Text + "\n" +
                    "Cargo: " + txtCargo.Text + "\n" +
                    "Matrícula: " + txtMatricula.Text + "\n" +
                    "Produção: " + txtProducao.Text + "\n" +
                    "Salário: " + txtSalario.Text + "\n" +
                    "Gratificação: " + txtGratificacao.Text + "\n" +
                    "Salário Bruto: " + bruto.ToString(), "Segue as informações:", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Digite valores reais nos campos Salario, Produção e Gratificação");
            }


        }

        private void fTestaProducao(double producao, ref int b, ref int c, ref int d)
        {
            if (producao >= 150)
            {
                b = 1; c = 1; d = 1;
            }
            else if (producao >= 120)
            {
                b = 1; c = 1;
            }
            else if (producao >= 100)
            {
                b = 1;
            }
        }
    }
}
