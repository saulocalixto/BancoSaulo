using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSaulo
{
    public partial class FormCadastroConta : Form
    {
        private Banco formPrincipal;

        public FormCadastroConta(Banco formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void cadastrarBotao_Click(object sender, EventArgs e)
        {
            string titular = textoTitular.Text.ToString();
            int numeroConta = Convert.ToInt32(textoNumero.Text);

            Cliente cliente = new Cliente(titular);
            cliente.GanhoCliente = Convert.ToDouble(textoGanho.Text);

            Conta novaConta = new ContaCorrente(cliente, numeroConta);

            this.formPrincipal.AdicionaConta(novaConta);
            limparCampos();
        }

        private void limparCampos()
        {
            textoTitular.Text = "";
            textoNumero.Text = "";
            textoGanho.Text = "";
        }
    }
}
