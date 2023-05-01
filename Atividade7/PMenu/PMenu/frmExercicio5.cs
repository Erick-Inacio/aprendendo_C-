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

namespace PMenu
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            int num1, num2;

            if((int.TryParse(txtNumero1.Text, out num1)) &&
                (int.TryParse(txtNumero2.Text, out num2)))
            {
                if(num1 < num2)
                {
                    Random random = new Random();
                    int sorteado = random.Next(num1, num2);
                    txtSorteado.Text = sorteado.ToString();
                }
                else
                {
                    Random random = new Random();
                    int sorteado = random.Next(num2, num1);
                    txtSorteado.Text = sorteado.ToString();
                }
                
            }
            else
            {
                MessageBox.Show("Digite valores válidos");
            }
        }
    }
}
