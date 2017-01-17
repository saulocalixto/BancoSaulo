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
    public partial class Banco : Form
    {
        public Banco()
        {
            InitializeComponent();
        }

        private Conta[] contas;
        int indice = 0;
        int indiceTransferencia = 0;
        int numeroDeContas = 0;

        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            transferenciabox.Items.Add(conta.Titular.NomeCliente);
            comboContas.Items.Add(conta.Titular.NomeCliente);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            contas = new Conta[10];

            TotalizadorDeContas t = new TotalizadorDeContas();

        }

        private void depositar_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorDepositar = Convert.ToDouble(valorDigitado);

            this.contas[indice].deposito(valorDepositar);

            textoSaldo.Text = Convert.ToString(contas[indice].saldo);

            MessageBox.Show("Depósito Realizado com Sucesso!", "Sucesso");

            zerarValor();
        }

        private void sacar_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorSacar = Convert.ToDouble(valorDigitado);

            try
            {
                contas[indice].saque(valorSacar);
                textoSaldo.Text = Convert.ToString(contas[indice].saldo);
                MessageBox.Show("Saque Realizado com Sucesso!", "Sucesso");
                zerarValor();
            } catch (Exception ex)
            {
                MessageBox.Show("Você não possui saldo suficiente!", "Falha");
                zerarValor();
            }
        }

        private void zerarValor()
        {
            textoValor.Text = "0";

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = comboContas.SelectedIndex;

            textoTitular.Text = contas[indice].Titular.NomeCliente;

            textoNumero.Text = contas[indice].numeroConta.ToString();

            textoSaldo.Text = Convert.ToString(contas[indice].saldo);
        }

        private void transferenciabox_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceTransferencia = transferenciabox.SelectedIndex;
        }

        private void transferir_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorTransferir = Convert.ToDouble(valorDigitado);

            try
            {
                this.contas[indice].Transferencia(contas[indiceTransferencia], valorTransferir);
            } catch (Exception ex)
            {
                MessageBox.Show("Sem saldo suficiente!", "Erro!");
            }

            zerarValor();
        }

        private void novaContaBotao_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog(this);
        }

        private void botaoImposto_Click(object sender, EventArgs e)
        {
            if (contas[indice] is ContaCorrente)
            {
                ITributavel t = (ContaCorrente) contas[indice];
                MessageBox.Show("O Imposto da conta é: " + t.calculaTributos(), "Impostos");
            } else
            {
                MessageBox.Show("Essa conta não sofre tributação!", "Impostos");
            }

            
        }
    }
}
