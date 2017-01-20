using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSaulo
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(Cliente cliente) : base(cliente)
        {
            this.Titular = cliente;
            this.defineLimite(Titular.GanhoCliente);
        }

        public override void saque(double valor)
        {

            if(valor < 0)
            {
                throw new ArgumentException();
            }

            if (valor <= saldo)
            {
                this.saldo -= (valor + 0.10);
            }
            else
            {
                throw new SaldoInsuficienteException();
            }
        }

        public override void deposito(double valor)
        {
            this.saldo += valor;

        }

    }
}
