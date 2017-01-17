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
        private static int totalContas = 100;

        //Construtor da Classe
        public Conta(Cliente cliente)
        {
            totalContas++;
            numeroConta = totalContas;
        }

        public static int proximaConta()
        {
            return totalContas + 1;
        }

        private double limite;
        public double saldo { get; protected set; }

        public abstract void saque(double valor);

        public abstract void deposito(double valor);

        public void Transferencia(Conta destino, double valor)
        {
            try
            {
                this.saque(valor);
                destino.deposito(valor);
            } catch (Exception ex)
            {
                throw new Exception("Valor do saque superior ao saldo");
            }
            
        }

        public void defineLimite(double ganhoCliente)
        {
            limite = ganhoCliente * 0.20;
            saldo = limite;
        }
    }
}
