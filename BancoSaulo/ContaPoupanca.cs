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
            if (valor <= saldo)
            {
                this.saldo -= (valor + 0.10);
            }
            else
            {
                throw new Exception("Valor do saque superior ao saldo");
            }
        }

        public override void deposito(double valor)
        {
            this.saldo += valor;

        }

    }
}
