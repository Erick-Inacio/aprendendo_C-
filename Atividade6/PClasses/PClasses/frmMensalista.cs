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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void btnInstanciar_Click(object sender, EventArgs e)
        {
            //classe abstrata n permite criar objetos
            //Empregado obj1 = new Empregado();

            Mensalista objMensalista = new Mensalista();

            //set
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtEntradaEmpresa.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalarioMensal.Text);

            if(rbtnSim.Checked)
            {
                objMensalista.HomeOffice = 'S';
            }
            else
            {
                objMensalista.HomeOffice = 'N';
            }

            //get
            MessageBox.Show("Matrícula: " + objMensalista.Matricula + "\n" +
                "Nome: " + objMensalista.NomeEmpregado + "\n" + 
                "Data Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() +
                "\n" + "Salario Bruto: " + objMensalista.SalarioBruto().ToString("N2") +
                "\n" + "Tempo Empresa (DIAS): " + 
                objMensalista.TempoTrabalho() + 
                '\n' + objMensalista.VerificaHome());
        }

        private void btnInstanciarParametros_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(
                Convert.ToInt32(txtMatricula.Text),
                txtNome.Text,
                Convert.ToDateTime(txtEntradaEmpresa.Text),
                Convert.ToDouble(txtSalarioMensal.Text));

            //get
            MessageBox.Show("Matrícula: " + objMensalista.Matricula + "\n" +
                "Nome: " + objMensalista.NomeEmpregado + "\n" +
                "Data Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() +
                "\n" + "Salario Bruto: " + objMensalista.SalarioBruto().ToString("N2") +
                "\n" + "Tempo Empresa (DIAS): " +
                objMensalista.TempoTrabalho() +
                '\n' + objMensalista.VerificaHome());

        }
    }
}
