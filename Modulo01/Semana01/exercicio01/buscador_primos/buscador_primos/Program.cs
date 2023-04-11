/*
 * Faça um programa que receba do usuário dez números inteiros e os armazene em um array ou list,
 * e ao final, exiba os números primos e suas respectivas posições.
 */

using System;

namespace buscador_primos
{
    public class Program
    { 
        static void Main(string[] args)
        {
            const int MAX_NUM = 10;
            int[] numeros = new int[MAX_NUM];
            int cont = 0;

            Console.WriteLine("\n\n*** Você deve digitar {0} números inteiros ***\n", MAX_NUM);
            for (int i=0;i< MAX_NUM; i++)
            {
                Console.Write("Digite o {0}° número inteiro: ",i+1);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n\n*** Resultados ***\n");
            int total= 0;
            for (int i=0;i< MAX_NUM;i++)
            {
                cont = 0;
                //ja sabemos que todo numero é divisivel por 1 e por ele mesmo
                // entao tiramos essa divisao para diminuir nmero de operacoes
                for (int j = 2; j < numeros[i]; j++)
                {       
                    if (numeros[i] % j == 0)
                        cont++;
                }

                if (cont == 0) // se for divisivel somente por 1 e ele mesmo, entao é primo
                {
                    total++;
                    Console.WriteLine("{0} é um numero primo e está {1}° posicao.", numeros[i], i+1);
                }
            }
            if (total == 0)
                Console.WriteLine("Não foram identificados numeros primos.");

        }
    }


}