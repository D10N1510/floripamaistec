
using System;
using Banco.Classes;

namespace Banco
{
    public class Program
    {
        static public void Main(String[] args)
        {

            ContaBancaria conta=new ContaBancaria();

            conta.saldo = 100;
            Console.WriteLine(conta.saldo);


        }
    }
}