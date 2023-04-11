/*
 * Faça um programa que receba do usuário dez números inteiros e execute os seguintes passos:

1) Separe em duas listas sendo um somente números ímpares e o outro números pares.
2) Coloque os números de cada lista em ordem crescente.
3) Exiba como resultado o número de elementos em cada lista e a soma dos valores de cada um.
Ex: “A lista de números ímpares possui 5 números e a soma deles é igual a 47”
 */


using System;

namespace separador_numeros
{
    public class Program
    {
        static public void Main(string[] args)
        {
            const int MAX_NUM = 10;
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();
            int num = 0;

            Console.WriteLine("\n *** Você deve digitar {0} números inteiros ***", MAX_NUM);
            for (int i = 0; i<MAX_NUM;i++)
            {
                Console.Write("Digite o {0}° número inteiro: ",i+1);
                num=int.Parse(Console.ReadLine());
                if(num%2==0)
                    pares.Add(num);
                else impares.Add(num);

            }

            pares.Sort();
            impares.Sort();

            Console.WriteLine("\n*** Resultados Lista números Pares ***\n");
            Console.WriteLine("- A lista de numeros pares em ordem crescente é:");
            foreach (int p in pares) Console.WriteLine(p);
            Console.WriteLine("\n - A lista de números pares possui {0} números e a soma deles é igual a {1}", pares.Count(), pares.Sum());
            
            Console.WriteLine("\n\n- A lista de numeros ímpares em ordem crescente é:");
            foreach (int ip in impares) Console.WriteLine(ip);
            Console.WriteLine("\n - A lista de números ímpares possui {0} números e a soma deles é igual a {1}", impares.Count(), impares.Sum());

        }
    }
}