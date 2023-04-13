using System;
using banco_semana04.Classes;
using banco_semana04.Classes.@enum;

namespace banco_semana04
{

    public class Program
    {
        static public void Main(string[] args)
        {
            /*Cliente cjuridico = new Cliente("Empresa", DateTime.Now, "empresario", "Solteiro", ETipoPessoa.JURIDICA);
            ContaEmpresarial ce = new ContaEmpresarial(9999,1111,cjuridico,500,10,"ABCDEFG");
            ce.Depositar(1000);
            ce.ExibirDados();

            ce.FazerEmprestimo(300);
            ce.ExibirSaldo();
            ce.PagarEmprestimo();
            ce.ExibirSaldo();
            */

            Cliente cfisico = new Cliente("Fulaninho", DateTime.Now, "Engenheiro", "Casado", ETipoPessoa.FISICA);
            Cliente cjuridico = new Cliente("Empresa", DateTime.Now, "empresario", "Solteiro", ETipoPessoa.JURIDICA);

            ContaCorrente cc=new ContaCorrente(1111,2222,cfisico);
            cc.Depositar(2000);
            cc.ExibirSaldo(); 
            cc.Sacar(100);
            cc.ExibirSaldo();

            ContaEmpresarial ce = new ContaEmpresarial(3333,4444,cjuridico,5000,20,"ABCFDFDFD-2023");
            ce.Depositar(10000);
            ce.ExibirSaldo(); 
            ce.Sacar(300);
            ce.ExibirSaldo();

        }
    }
}