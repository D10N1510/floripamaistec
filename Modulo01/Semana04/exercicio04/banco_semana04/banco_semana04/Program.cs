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


            /* [M1S04] Ex 3 - Criação classes filhas ContaCorrente, ContaPoupanca e ContaEmpresarial
             Defina três classes sendo chamadas de ContaCorrente, ContaPoupanca e ContaEmpresarial, respectivamente, 
            que herdem da classe base ContaBancaria e implementem o seu construtor enviando os atributos recebidos 
            como parâmetro para o construtor base.

                Obs: Só pode ser criadas contas correntes ou poupança de cliente com tipoPessoa com valor FISICA. 
            Da mesma forma que só podem ser criadas contas empresariais para clientes com tipoPessoa com valor JURIDICA.
             */
            ContaCorrente cc = new ContaCorrente(5555,6666,c);
            cc.ExibirDados();
            ContaPoupanca cp = new ContaPoupanca(7777, 8888, c);
            cp.ExibirDados();

            Cliente cjuridico = new Cliente("Empresa", DateTime.Now, "empresario", "Solteiro", ETipoPessoa.JURIDICA);
            ContaEmpresarial ce = new ContaEmpresarial(9999,1111,cjuridico,500,10,"ABCDEFG");
            ce.ExibirDados();
                       
            ContaEmpresarial ce2 = new ContaEmpresarial(9999, 1111, c, 500, 10, "ABCDEFG");
            
        }
    }
}