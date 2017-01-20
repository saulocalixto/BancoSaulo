namespace BancoSaulo
{
    public class Cliente
    {

        public string NomeCliente { get; set; }

        public double GanhoCliente { get; set; }

        public Cliente(string nome)
        {
            this.NomeCliente = nome;
        }
    }
}