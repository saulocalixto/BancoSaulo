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
            FormClosing += form_FormClosing;
        }

        private List<Conta> contas;
        private Dictionary<string, Conta> dicionario;
        int numeroDeContas = 0;
        Conta selecionada;
        Conta transferenciaConta;
        private double somaSaldo;

        public void AdicionaConta(Conta conta)
        {
            this.dicionario.Add(conta.Titular.NomeCliente, conta);
            this.contas.Add(conta);
            this.numeroDeContas++;
            somaSaldo = contas.Sum(c => c.saldo);
            comboContas.Items.Add(conta);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.contas = new List<Conta>();
            this.dicionario = new Dictionary<string, Conta>();
            TotalizadorDeContas t = new TotalizadorDeContas();
            LerDados.lerArquivo(this);

        }

        private void depositar_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorDepositar = Convert.ToDouble(valorDigitado);

            selecionada.deposito(valorDepositar);

            textoSaldo.Text = Convert.ToString(selecionada.saldo);

            MessageBox.Show("Depósito Realizado com Sucesso!", "Sucesso");

            zerarValor();
        }

        private void sacar_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorSacar = Convert.ToDouble(valorDigitado);

            try
            {
                selecionada.saque(valorSacar);
                textoSaldo.Text = Convert.ToString(selecionada.saldo);
                MessageBox.Show("Saque Realizado com Sucesso!", "Sucesso");
                zerarValor();
            }
            catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show("Sem saldo suficiente!", "Erro!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Valor de saque menor não pode ser negativo!", "Erro!");
            }
        }

        private void zerarValor()
        {
            textoValor.Text = "0";

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            transferenciabox.Items.Clear();
            selecionada = (Conta)comboContas.SelectedItem;

            textoTitular.Text = selecionada.Titular.NomeCliente;

            textoNumero.Text = selecionada.numeroConta.ToString();

            textoSaldo.Text = Convert.ToString(selecionada.saldo);

            foreach(Conta conta in contas)
            {
                if ( !(conta.Equals(selecionada)) )
                {
                    transferenciabox.Items.Add(conta);
                }
            }

            
        }

        private void transferenciabox_SelectedIndexChanged(object sender, EventArgs e)
        {
            transferenciaConta = (Conta)transferenciabox.SelectedItem;
        }

        private void transferir_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorTransferir = Convert.ToDouble(valorDigitado);

            try
            {
                selecionada.Transferencia(transferenciaConta, valorTransferir);
            } catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show("Sem saldo suficiente!", "Erro!");
            } catch (ArgumentException)
            {
                MessageBox.Show("Valor de saque menor não pode ser negativo!", "Erro!");
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
            if (selecionada is ContaCorrente)
            {
                ITributavel t = (ContaCorrente) selecionada;
                MessageBox.Show("O Imposto da conta é: " + t.calculaTributos(), "Impostos");
            } else
            {
                MessageBox.Show("Essa conta não sofre tributação!", "Impostos");
            }

            
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string buscaTitular = textoBuscaNome.Text.ToString();

                Conta contaBusca = dicionario[buscaTitular];

                textoTitular.Text = contaBusca.Titular.NomeCliente;

                textoNumero.Text = contaBusca.numeroConta.ToString();

                textoSaldo.Text = Convert.ToString(contaBusca.saldo);

                comboContas.SelectedItem = contaBusca;
            }
            catch(KeyNotFoundException ex)
            {
                MessageBox.Show("Conta não encontrada!", "Erro!");
            }
        }

        private void botaoRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorios form = new FormRelatorios(contas);
            form.ShowDialog();
        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                GravarDados.escreverDados(contas);
            }
        }
    }
}
