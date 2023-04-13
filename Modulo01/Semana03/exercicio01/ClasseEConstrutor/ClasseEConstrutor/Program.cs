/*
1) Crie uma classe "Produto" que possui as seguintes propriedades:

Nome (string)
Preço (double)
Quantidade (int)

1.1) Crie um construtor que inicializa as propriedades "Nome", "Preço" e "Quantidade". 
Crie um construtor padrão que inicializa o nome como "Sem Nome", o preço como 0 e a quantidade como 0.

2) Em seguida, crie uma classe "Program":

2.1)dentro dela crie um método Main()
2.2) instancia dois objetos da classe "Produto":
2.2.1) Um usando o construtor com argumentos e...
2.2.2) Outro usando o construtor padrão.
2.3) Imprima os valores das propriedades de cada objeto no terminal.
*/


using System;
using ClasseEConstrutor.Classes;

namespace ClasseEConstrutor
{
    public class Program
    {
        static public void Main(string[] args)
        {

            Produto p1= new Produto("Notebook",5000.99,50);
            Produto p2= new Produto();

            Console.WriteLine("Dados do Produto 1 (construtor com argumentos):");
            Console.WriteLine(" Nome: {0}\n Preço: {1}\n Quantidade: {2}\n", p1.Nome, p1.Preço, p1.Quantidade);

            Console.WriteLine("Dados do Produto 2 (construtor padrão):");
            Console.WriteLine(" Nome: {0}\n Preço: {1}\n Quantidade: {2}", p2.Nome, p2.Preço, p2.Quantidade);
        }
    }
}