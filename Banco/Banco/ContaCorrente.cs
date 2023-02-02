using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Banco;
public class ContaCorrente
{
    public string nome;
    public int agencia;
    public string conta;
    public double saldo, transferir;
    public double valortranferencia;
    public bool sacar(double valor)
    {
        if (this.saldo >= valor)
        {
            this.saldo -= valor;
            return true;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para o saque.");
            return false;
        }
    }
    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        valortranferencia = valor;
        if (this.saldo >= valor)
        {
            this.saldo -= valor;
            contaDestino.saldo += valor;
            return true;
        }
        else
        {
            Console.WriteLine("Não foi possivel realizar a transferencia. O saldo é insficiente");
            return false;
        }
    }
}