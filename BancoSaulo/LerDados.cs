using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSaulo
{
    static class LerDados
    {
        static private Conta conta;
        

        static public void lerArquivo(Banco formPrincipal)
        {
            if(File.Exists("saida.txt"))
            {
                using (Stream arquivo = File.Open("saida.txt", FileMode.Open))
                using (StreamReader leitor = new StreamReader(arquivo))
                {
                    string linha = leitor.ReadLine();
                    while (linha != null)
                    {

                        char[] separatingChars = { '¬' };
                        string[] separar = new string[linha.Length];
                        separar = linha.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);

                        Cliente cliente = new Cliente(separar[0]);
                        cliente.GanhoCliente = Convert.ToDouble(separar[1]);

                        if (Convert.ToInt32(separar[2]) == 0)
                        {
                            conta = new ContaCorrente(cliente);
                        }
                        else
                        {
                            conta = new ContaPoupanca(cliente);
                        }

                        formPrincipal.AdicionaConta(conta);
                        linha = leitor.ReadLine();
                    }
                }
            }
            
        }
    }
}
