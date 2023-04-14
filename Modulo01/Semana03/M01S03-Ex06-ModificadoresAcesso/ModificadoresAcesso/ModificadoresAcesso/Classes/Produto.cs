using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ModificadoresAcesso.Classes
{
    internal class Produto
    {
        public string nome;
        protected string cor;
        private double peso, preço;

        public void verificarEstoque() {
            Console.WriteLine("Verificando estoque, acessando o método da classe produto");
        }

        protected void vender() {
            Console.WriteLine("Vendendo produto, acessando método vender da classe produto");
        }

        private void descartar() {
            Console.WriteLine("Descartando o produto, acessando o método da classe produto");
        }

        protected void alteraAtributosPrivados(double peso2, double preco) {
            peso = peso2;
            Console.WriteLine("Variável peso de escopo da classe: " + peso);
        } 



    }
}
