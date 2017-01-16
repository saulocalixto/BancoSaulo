namespace BancoSaulo
{
    internal class TotalizadorDeContas
    {

        public double valorTotal { get; private set; }

        /*
        * Polimorfismo, independente da conta passada, se corrente ou poupança,
        * esse método irá funcionar sem problemas! Isso acontece porque o saldo
        * sempre estará em conta, independente se for corrente ou poupança.
        */
        public void Soma(Conta conta)
        {
            valorTotal += conta.saldo;
        }
    }
}