// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

// comentario

// tipos de dados

int nroInteiro = 10; //var inteira
long nroMaior = 1099999L;
float nroQuebrado = 6.8f;
double nroQuebradoMaior = 101.99999999d;
char letra = 'z';
string texto = "a turma estreito é a melhor";
bool varBooleana = true;
DateTime data = DateTime.Now;
DateTime outraData = new DateTime(2023, 01, 31);
string texto2 = texto.ToUpper();
Console.WriteLine(texto2);


String nomeCompleto;
Console.Write("Digite o seu nome: ");
nomeCompleto = Console.ReadLine();
Console.WriteLine("O seu nome é: " + nomeCompleto);


