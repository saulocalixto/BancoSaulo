using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSaulo
{
    public abstract class Conta
    {
        public string NomeCliente { get; private set; }


        public Cliente Titular { get; set; }
        public int numeroConta { get; protected set; }

        //Construtor da Classe
        public Conta(Cliente cliente, int numeroConta)
        {
            Titular = cliente;
            this.numeroConta = numeroConta;
            defineLimite(Titular.GanhoCliente);
        }

        private double limite;
        public double saldo { get; protected set; }

        public abstract bool saque(double valor);

        public abstract void deposito(double valor);

        public void Transferencia(Conta destino, double valor)
        {
            if(this.saque(valor))
            {
                destino.deposito(valor);
            } else
            {
                //faça algo.
            }
        }

        public void defineLimite(double ganhoCliente)
        {
            limite = ganhoCliente * 0.20;
            saldo = limite;
        }

    }
}
