using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        double numero1, numero2, resultado;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMais_Click_1(object sender, EventArgs e)
        {
            if((Double.TryParse(txtNum1.Text, out numero1)) &&
                    (Double.TryParse(txtNum2.Text, out numero2)))
                    {
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Números Inválidos");
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if(Double.TryParse(txtNum1.Text, out numero1) && Double.TryParse(txtNum2.Text, out numero2))
            {
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Número Inválido!");
            }
        }

        private void txtNum1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNum1.Text, out numero1))
            {
                MessageBox.Show("Número Inválido");
            }
        }

        private void txtNum2_Validated(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if(Double.TryParse(txtNum1.Text, out numero1) && (Double.TryParse(txtNum2.Text, out numero2)))
            {
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Número Inválido");
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if(Double.TryParse(txtNum1.Text, out numero1) &&  Double.TryParse(txtNum2.Text,out numero2)
                && (numero2 != 0))
            {
                resultado = numero1 / numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Número inválido ou número 2 = 0");
            }
        }
    }
}
