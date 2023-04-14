using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresAcesso.Classes
{
    internal class ProdutoFinanceiro:Produto
    {

        public void acesso()
        {
            ProdutoFinanceiro pf=new ProdutoFinanceiro();
            pf.nome = "exemplo produto financeiro";
            pf.cor = "cor do produto";
            Console.WriteLine("Nome: " + pf.nome + "\nCor: " + pf.cor);
            pf.vender();
            pf.verificarEstoque();
            pf.alteraAtributosPrivados(99, 100.0);
        }
    }
}
