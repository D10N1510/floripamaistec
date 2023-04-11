/*
 Faça um programa que receba o nome e média final de cinco alunos. 
Armazene em um array ou list os nomes e em outra as médias. Ao final, 
exiba o nome de cada aluno e a mensagem “APROVADO” para quem tiver média acima de 6 e “REPROVADO” para quem não.
*/


using System;

namespace media_aprovacao
{
    public class Program
    {
        static public void Main(string[] args)
        {
            const int MAX_ALUMNOS = 5;
            List<string> nomes = new List<string>();
            List<float> medias = new List<float>();

            Console.WriteLine("\n*** Você deve digitar o nome e média de {0} alumnos ***\n", MAX_ALUMNOS);
            for(int i = 0; i < MAX_ALUMNOS; i++)
            {
                Console.Write("Digite o nome do {0}° alumno: ",i+1);
                nomes.Add(Console.ReadLine());
                Console.Write("Digite a média final do {0}° alumno: ",i+1);
                medias.Add(float.Parse(Console.ReadLine()));
            }

            Console.WriteLine("\n*** Resultados ***");
            for(int i = 0; i < MAX_ALUMNOS; i++)
            {
                if (medias[i] > 6.0) 
                    Console.WriteLine("{0}.- Alumno: {1} - APROVADO", i + 1, nomes[i]);
                else Console.WriteLine("{0}.- Alumno: {1} - REPROVADO", i + 1, nomes[i]);
            }
        }
    }
}