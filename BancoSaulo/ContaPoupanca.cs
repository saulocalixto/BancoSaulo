using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSaulo
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(Cliente cliente, int numeroConta) : base(cliente, numeroConta)
        {
            this.Titular = cliente;
            this.numeroConta = numeroConta;
            this.defineLimite(Titular.GanhoCliente);
        }

        public override bool saque(double valor)
        {
            if (valor <= saldo)
            {
                this.saldo -= (valor + 0.10);
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void deposito(double valor)
        {
            this.saldo += valor;

        }

    }
}
