using System;
using banco_semana04.Classes;
using banco_semana04.Classes.@enum;

namespace banco_semana04
{

    public class Program
    {
        static public void Main(string[] args)
        {
            Cliente cjuridico = new Cliente("Empresa", DateTime.Now, "empresario", "Solteiro", ETipoPessoa.JURIDICA);
            ContaEmpresarial ce = new ContaEmpresarial(9999,1111,cjuridico,500,10,"ABCDEFG");
            ce.Depositar(1000);
            ce.ExibirDados();

            ce.FazerEmprestimo(300);
            ce.ExibirSaldo();
            ce.PagarEmprestimo();
            ce.ExibirSaldo();
            
        }
    }
}