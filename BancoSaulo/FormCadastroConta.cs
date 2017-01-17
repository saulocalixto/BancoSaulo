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

        int tipoConta;

        public FormCadastroConta(Banco formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void cadastrarBotao_Click(object sender, EventArgs e)
        {
            string titular = textoTitular.Text.ToString();

            Cliente cliente = new Cliente(titular);
            cliente.GanhoCliente = Convert.ToDouble(textoGanho.Text);
            Conta novaConta;
            if (tipoConta == 0)
            {
               novaConta  = new ContaCorrente(cliente);
            } else
            {
                novaConta = new ContaPoupanca(cliente);
            }

            this.formPrincipal.AdicionaConta(novaConta);
            limparCampos();
            textoNumero.Text = Conta.proximaConta().ToString();
        }

        private void limparCampos()
        {
            textoTitular.Text = "";
            textoNumero.Text = "";
            textoGanho.Text = "";
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            textoNumero.Text = Conta.proximaConta().ToString();
            boxTipoConta.Items.Add("Conta Corrente");
            boxTipoConta.Items.Add("Conta Poupança");
        }

        private void boxTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoConta = boxTipoConta.SelectedIndex;
        }
    }
}
