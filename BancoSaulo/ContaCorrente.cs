namespace BancoSaulo
{
    internal class ContaCorrente : Conta, ITributavel
    {
        public ContaCorrente(Cliente cliente, int numeroConta) : base(cliente, numeroConta)
        {
            Titular = cliente;
            this.numeroConta = numeroConta;
            defineLimite(Titular.GanhoCliente);
        }

        public override bool saque(double valor)
        {
            if (valor <= saldo)
            {
                this.saldo -= (valor + 0.05);
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
            this.saldo -= (0.10);
        }

        public double calculaTributos()
        {
            return this.saldo * 0.05;
        }
    }
}