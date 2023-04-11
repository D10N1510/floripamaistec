/* Crie um programa que receba do usuário uma lista de frutas com no máximo 15 itens. 
 * Organize as frutas em ordem alfabética e exiba a lista.
 */

using System;

namespace organiza_frutas
{
    public class Program
    {
        static public void Main(string[] args)
        {
            const int MAX_FRUTAS = 15;
            string[] frutas = new string[MAX_FRUTAS];

            Console.WriteLine("\n\n*** Você deve digitar o nome de {0} frutas ***\n", MAX_FRUTAS);
            for(int i=0;i<MAX_FRUTAS;i++)
            {
                Console.Write("Digite o nome da {0}° fruta: ",i+1);
                frutas[i] = Console.ReadLine();
            }

            Array.Sort(frutas);
            Console.WriteLine("\n\n*** A lista de frutas organizadas pelo nome é:");
            for (int i = 0; i < MAX_FRUTAS; i++)
                Console.WriteLine(frutas[i]);               

        }
    }
}