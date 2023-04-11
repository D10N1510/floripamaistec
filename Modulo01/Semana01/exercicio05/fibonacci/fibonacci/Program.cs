/*
 Faça um algoritmo que receba um número inteiro que será a quantidade de números 
calculados pela sequência de Fibonacci. Em seguida, exiba a sequência no terminal. 
Ex: Se receber o número 7, você irá exibir a sequência “1 2 3 5 8 13 21” que contém ao todo 7 números.

*/

using System;

namespace fibonacci
{
    public class Program
    {
        static public void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("\n - Digite um número inteiro que representa o tamanho da serie de Fibonacci:");
            n=int.Parse(Console.ReadLine());

            List<int> fib=new List<int>();

            switch (n){
                case 1:
                        fib.Add(1);
                        break;
                case 2: 
                        fib.Add(1);
                        fib.Add(2);
                        break;
                default:
                    if (n <= 0)
                        Console.WriteLine("Nao tem série de fibonacci.");
                    else
                    {
                        fib.Add(1);
                        fib.Add(2);
                        for (int i = 2; i < n; i++)
                            fib.Add(fib[i - 2] + fib[i - 1]);
                    }
                    break;
                       } 

            if(n>0) Console.WriteLine("A série de Fibonacci é: ");
            foreach (int f in fib) Console.Write(" {0}",f);
        }
    }
}