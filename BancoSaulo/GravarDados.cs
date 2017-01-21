using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSaulo
{
    static class GravarDados
    {

        public static void escreverDados(List<Conta> contas)
        {
            using(Stream saida = File.Open("saida.txt", FileMode.Create))
            using(StreamWriter escritor = new StreamWriter(saida)) {

                string nomeCliente;
                double ganhoCliente;
                int tipoConta;

                foreach (Conta c in contas)
                {
                    string gravar;
                    nomeCliente = c.Titular.NomeCliente;
                    gravar = nomeCliente + "¬";
                    ganhoCliente = c.Titular.GanhoCliente;
                    gravar += ganhoCliente + "¬";
                    if (c is ContaCorrente)
                    {
                        tipoConta = 0;
                        gravar += tipoConta;
                    }
                    else
                    {
                        tipoConta = 1;
                        gravar += tipoConta;
                    }

                    escritor.WriteLine(gravar);
                }
            }
        }
    }
}
