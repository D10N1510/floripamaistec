using System;
using banco_semana04.Classes;
using banco_semana04.Classes.@enum;

namespace banco_semana04
{

    public class Program
    {
        static public void Main(string[] args)
        {

            Cliente c=new Cliente("Fulaninho", DateTime.Now,"engenheiro","Solteiro",ETipoPessoa.FISICA);
            c.ExibeDados();

            ContaBancaria conta = new ContaBancaria(1234, 4444, c);
            conta.ExibirDados();

        }
    }
}