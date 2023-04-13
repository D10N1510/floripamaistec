
using System;
using Banco.Classes;
using Banco.Classes.Enum;

namespace Banco
{
    public class Program
    {
        static public void Main(String[] args)
        {
            
           ContaBancaria conta=new ContaBancaria("Fulaninho",123456,789456,ETipoConta.POUPANCA);
           conta.ImprimeDados();
           conta.Deposito(1000);            
           conta.ExibeSaldo();

        }
    }
}