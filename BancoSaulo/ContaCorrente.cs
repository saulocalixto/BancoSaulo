﻿using System;

namespace BancoSaulo
{
    internal class ContaCorrente : Conta, ITributavel
    {

        public ContaCorrente(Cliente cliente) : base(cliente)
        {
            Titular = cliente;
            defineLimite(Titular.GanhoCliente);
        }

        public override void saque(double valor)
        {

            if(valor < 0)
            {
                throw new ArgumentException();
            }

            if (valor <= saldo)
            {
                this.saldo -= (valor + 0.05);
            }
            else
            {
                throw new SaldoInsuficienteException();
            }
        }

        public override void deposito(double valor)
        {
            this.saldo += valor;
            this.saldo -= (0.10);
        }

        public double calculaTributos()
        {
            return this.saldo * 0.05;
        }
    }
}