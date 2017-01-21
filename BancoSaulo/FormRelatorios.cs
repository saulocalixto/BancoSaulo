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
    public partial class FormRelatorios : Form
    {

        private List<Conta> contas;

        public FormRelatorios(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void botaoFiltroSaldo_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var resultado = contas.Where(c => c.saldo > 5000);
            foreach(Conta c in resultado)
            {
                listaResultado.Items.Add(c);
            }

            try
            {
                double somaSaldo = resultado.Sum(conta => conta.saldo);
                double maiorSaldo = resultado.Max(conta => conta.saldo);


                labelSaldo.Text = Convert.ToString(somaSaldo);
                labelMaior.Text = Convert.ToString(maiorSaldo);
            } catch (Exception ex)
            {
                MessageBox.Show("Não tem!");
            }
        }

        private void botaoCC_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var resultado = contas.Where(c => c is ContaCorrente);
            foreach(Conta c in resultado)
            {
                listaResultado.Items.Add(c);
            }

            double somaSaldo = resultado.Sum(conta => conta.saldo);
            double maiorSaldo = resultado.Max(conta => conta.saldo);

            labelSaldo.Text = Convert.ToString(somaSaldo);
            labelMaior.Text = Convert.ToString(maiorSaldo);
        }
    }
}
