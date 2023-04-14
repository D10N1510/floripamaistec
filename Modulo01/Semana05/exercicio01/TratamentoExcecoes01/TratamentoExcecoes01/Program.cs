/* [M1S05] Ex 1 - Solicite dois números 
 Crie um programa que solicite ao usuário que insira dois números decimais.
Em seguida, divida o primeiro número pelo segundo número;
Se a divisão for bem-sucedida, exiba o resultado da divisão;
Se a divisão não for bem-sucedida por meio do tratamento de exceções, faça:
Caso o usuário digite um valor 0, exiba uma mensagem de erro informando que não é possível dividir por zero 
(DivideByZeroException);
Caso o usuário digite letras, exiba uma mensagem de erro informando que letras não podem ser informadas (FormatException);
Caso aconteça algo inesperado, exiba uma mensagem de erro informando que ocorreu um erro (Exception);
Adicione o finally e dentro desse bloco de instruções, atribua o valor 0 para as duas variáveis utilizadas para 
armazenador os números que o usuário digitou;
 */

using System;

namespace TratamentoExcecoes01
{
    public class Program
    {
        static public void Main(string[] args)
        {
            decimal n1, n2,resultado;
            try
            {
                Console.WriteLine("\n*** Insira 02 números decimais:");
                Console.WriteLine("Digite o 1° número decimal:");             
                n1 = decimal.Parse(Console.ReadLine());             
                Console.WriteLine("Digite 2° número decimal:");        
                n2 = decimal.Parse(Console.ReadLine()); 
                resultado = n1 / n2;
                Console.WriteLine(resultado);   
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Erro específico identificado: {e}.");
                Console.WriteLine("Não é possível dividir por zero."); 
            }
            catch (FormatException e)           
            {
                Console.WriteLine($"Erro específico identificado: {e}.");
                Console.WriteLine("Letras não podem ser informadas. Digite apenas números.");  
            }
            catch (Exception e) 
            {
                Console.WriteLine($"Ocorreu um erro: {e}.");
            }
            finally
            {
                n1 = 0;    
                n2 = 0;
                Console.WriteLine("Zerando os valores solicitados ao usuário.");
            }

        }
    }
}