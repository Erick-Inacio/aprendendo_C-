using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra
{
    public partial class Form1 : Form
    {
        double raio, altura, volume;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if((!double.TryParse(txtRaio.Text, out raio)) ||
                    (!double.TryParse(txtAltura.Text, out altura)))
            {
                MessageBox.Show("Valores Inválidos!");
            }
            else if((altura<=0) || (raio <= 0))
            {
                MessageBox.Show("valores não podem ");
            }else
            {
                //txtVolume.Text = (Math.PI * Math.Pow(raio, 2) * altura).ToString();
                volume = Math.PI * Math.Pow(raio, 2) * altura;
                txtVolume.Text = volume.ToString("N2");
            }
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtRaio_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show("Valores inválidos!");
            }
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Altura Inválida!");
            }
            else if (altura <= 0)
            {
                MessageBox.Show("Altura deve ser maior que zero!");
            }
        }
    }
}
