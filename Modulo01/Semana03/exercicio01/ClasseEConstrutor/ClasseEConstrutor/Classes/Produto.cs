using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEConstrutor.Classes
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preço { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome,double preco,int quantidade)
        {
            Nome = nome;
            Preço = preco;
            Quantidade = quantidade;
        }

        public Produto() {
            Nome = "Sem nome";
            Preço= 0;
            Quantidade = 0;
        }
    }
}
