using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInstanciar_Click(object sender, EventArgs e)
        {
            //classe abstrata n permite criar objetos
            //Empregado obj1 = new Empregado();

            Horista objHorista = new Horista();

            //set
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtEntradaEmpresa.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalario.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumHora.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasFalta.Text);

            if (rbtnSim.Checked)
            {
                objHorista.HomeOffice = 'S';
            }
            else
            {
                objHorista.HomeOffice = 'N';
            }

            //get
            MessageBox.Show("Matrícula: " + objHorista.Matricula + "\n" +
                "Nome: " + objHorista.NomeEmpregado + "\n" +
                "Data Entrada: " + objHorista.DataEntradaEmpresa.ToShortDateString() +
                "\n" + "Salario Bruto: " + objHorista.SalarioBruto().ToString("N2") +
                "\n" + "Tempo Empresa (DIAS): " +
                objHorista.TempoTrabalho() +
                '\n' + objHorista.VerificaHome());
        }

        private void frmHorista_Load(object sender, EventArgs e)
        {

        }
    }
}
