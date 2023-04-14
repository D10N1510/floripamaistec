/* [M1S03] Ex 6 - Crie um exemplo de Console App utilizando os modificadores de acesso
 Crie um exemplo de Console App utilizando os modificadores de acesso: Internal (classes), Private, 
Protected e Private (atributos e métodos)

Sendo o mesmo exemplo codificado durante a aula…

Crie um classe Produto com o modificadores de acesso internal;
Dentro dessa classe Produto, coloque os atributos com os modificadores de acesso:
public string nome, protected string cor, private double peso e preço;
Ainda dentro da classe produto crie 3 métodos, sendo:
public verificarEstoque(){…};
Imprima uma mensagem em tela, dentro desse método. Exemplo de mensagem: “Verificando estoque, acessando o método da 
classe produto“;
protected vender(){…};
Imprima uma mensagem em tela, dentro desse método. Exemplo de mensagem: “Vendendo produto, acessando método vender 
da classe produto“;
private descartar(){…}
Imprima uma mensagem em tela, dentro desse método. Exemplo de mensagem: “Descartando o produto, acessando o método 
da classe produto“;
protected void alteraAtributosPrivados(double peso2, double preco){…}
Alterar o valor da variável privada peso de escopo da classe Produto conforme o valor da variável peso2 que será 
enviado via parâmetro;
Abaixo, imprima no terminal a mensagem:
Console.WriteLine("Variável peso de escopo da classe: " + peso);
Crie outra classe em sua aplicação chamada ProdutoFinanceiro:
Faça essa classe ser uma classe filha da classe Produto;
Crie um método chamado acesso() com modificador de acesso público. Dentro deste método:
Instancie um objeto;
Atribua um valor para nome e cor desse objeto;
Imprima em tela esses valores:
Exemplo: Console.WriteLine("Nome: " + PF1.nome + "Cor: " + PF1.cor);
Invoque os métodos:
PF1.vender();
PF1.verificarEstoque();
PF1.alteraAtributosPrivados(99, 100.0);
Por fim, na classe Program.cs:
Instancie um objeto de produto:
Produto produto1 = new Produto();
Atribua valores neste objeto e invoque os métodos que tenha permissão de acessar:
produto1.nome = "Calculadora";
produto1.verificarEstoque();
Console.WriteLine("O nome do produto é: " + produto1.nome);
Depois, instancie um objeto da classe ProdutoFinanceiro
ProdutoFinanceiro classeFilha = new ProdutoFinanceiro();
Atribua valores aos atributos com permisão e invoque os métodos que a classe Program tenha permissão:
classeFilha.nome = "Produto Financeiro";
classeFilha.verificarEstoque();
classeFilha.acesso();
Desta forma, você utilizou os moficicadores de acesso Public, Internal, Private e Protected. 
Anexe o link da pasta deste exercício do seu github;
 */


using System;
using System.Net.NetworkInformation;
using ModificadoresAcesso.Classes;

namespace ModificadoresAcesso
{
    public class Program
    {
        static public void Main(string[] args)
        {
            Produto produto1 = new Produto();

            produto1.nome = "Calculadora";
            produto1.verificarEstoque();
            Console.WriteLine("O nome do produto é: " + produto1.nome);

            ProdutoFinanceiro classeFilha = new ProdutoFinanceiro();
            classeFilha.nome = "Produto Financeiro";
            classeFilha.verificarEstoque();
            classeFilha.acesso();
        }
    }
}