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

namespace PSalario
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }
        private void frmCalculo_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificarDesc_Click(object sender, EventArgs e)
        {
            GroupBox objGenero = new GroupBox();
            objGenero = gbxGenero;

            GroupBox objEstadoCivil = new GroupBox();
            objEstadoCivil = gbxEstCivil;

            int numFilho = int.Parse(nudNumFilhos.Value.ToString());
            string genero = DadosGbx(objGenero);
            string estadoCivil = DadosGbx(objEstadoCivil);

            string nome = txtNomeFunc.Text;

            if (!string.IsNullOrEmpty(nome) && nome.Length > 3)
            {
                if (double.TryParse(mskbxSalBruto.Text, out double salario))
                {
                    Funcionario objFunc = new Funcionario(nome, salario, numFilho,
                        genero, estadoCivil);

                    txtAliquotaInss.Text = objFunc.CalcInss();
                    txtDescInss.Text = objFunc.Inss.ToString("N2");

                    txtAliquotaIrpf.Text = objFunc.CalcIrpf();
                    txtDescIrpf.Text = objFunc.Irpf.ToString("N2");

                    txtSalFamilia.Text = $"{objFunc.CalcFamilia()}";

                    txtSalLiquido.Text = objFunc.CalSalLiquido().ToString("N2");

                    lblMensagem.Visible = true;
                    lblMensagem.Text = objFunc.ToString();
                }
                else
                {
                    MessageBox.Show("Digite um salário bruto válido e maior que 0!");
                    mskbxSalBruto.Focus();
                }
            }
            else
            {
                MessageBox.Show("Digite um nome válido!");
                txtNomeFunc.Focus();
            }
        }

        public static string DadosGbx(GroupBox gbx)
        {
            string aux = null;

            foreach (Control radio in gbx.Controls)
            {
                if (radio is RadioButton radioButton && radioButton.Checked)
                {
                    aux = radioButton.Text;
                }
            }
            return aux;
        }
    }
}
