using Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Banco
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta2 = new ContaCorrente();
            conta2.agencia = 1812;
            conta2.conta = "51648-5";
            conta2.nome = "Danilo"; conta2.saldo = 4000;
            // Console.WriteLine("O saldo anterior é: R$" + conta2.saldo);
            //if (conta2.sacar(1000))
            // Console.WriteLine("O saldo depois do saque é: " + conta2.saldo); 
           ContaCorrente conta1 = new ContaCorrente();
            conta1.agencia = 5500;
            conta1.conta = "203156-a";
            conta1.nome = "Lucas";
            conta1.saldo = 250;
            Console.WriteLine("SALDO ATUAL DA CONTA QUE IRÁ TRANSFERIR: " + conta2.saldo);
            Console.WriteLine("SALDO ATUAL DA CONTA QUE IRÁ RECEBER: " + conta1.saldo); if (conta2.Transferir(20, conta1))
                Console.WriteLine("SALDO ATUAL APÓS VOCÊ TRANSFERIR: " + conta2.saldo);
            Console.WriteLine("SEU SALDO APOS RECEBER A TRANSFERENCIA " + conta1.saldo);
            Console.WriteLine("O VALOR DA TRANSFERENCIA FOI DE: " + conta2.valortranferencia);
        }
    }
}