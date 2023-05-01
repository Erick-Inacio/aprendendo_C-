using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Cadastro_Inquilinos
{
    

    public partial class Inquilinos : Form
    {
        
        string[] dias = new string[31] {"1","2","3","4","5","6","7","8","9","10","11",
            "12","13","14","15","16","17","18","19","20", "21", "22", "23", "24", "25",
            "26", "27", "28", "29", "30", "31" };
        string[] wanel = new string[14] { "1", "2", "3", "4", "5", "6", "7", "8", "9","10",
            "11", "12", "13", "14" };
        string[] eden = new string[18] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
            "11", "12", "13", "14", "15", "16", "17", "18" };

        public Inquilinos()
        {
            InitializeComponent();
        }

        private void Inquilinos_Load(object sender, EventArgs e)
        {
            cbxDiaPgto.Items.AddRange(dias);
        }

        private void lstboxDiaPgto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxDiaPgto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            double testando = (double.Parse(maskedTextBox1.Text.Replace("R$", "")));

            if (testando/2 == 100)
            {
                MessageBox.Show("Conversão ok:" + testando);
            }
            else
            {
                MessageBox.Show("Conversão com problemas");
            }
            
           
            
           // MessageBox.Show("o valor digitado foi: " + testando);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
