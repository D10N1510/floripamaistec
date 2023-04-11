
using System;
using Banco.Classes;

namespace Banco
{
    public class Program
    {
        static public void Main(String[] args)
        {

            ContaBancaria conta = new ContaBancaria();

            conta.saldo = 100;
            Console.WriteLine(conta.saldo);

            conta.Deposito(1000);
            Console.WriteLine(conta.saldo);

            conta.Saque(500);
            Console.WriteLine(conta.saldo);

            conta.Saque(0);
            Console.WriteLine(conta.saldo);

            conta.Saque(-1);
            Console.WriteLine(conta.saldo);

            conta.Saque(5000);
            Console.WriteLine(conta.saldo);

        }
    }
}