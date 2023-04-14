using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Usando os conceitos de TDD e o framework NUnit, crie uma classe estática chamada ValidadorDeNumeros 
 *e crie os seguintes métodos:

EhNumeroPrimo → valida se o número é primo

ParOuImpar → valida se o número é par ou ímpar

EhDivisivelPor → recebe dois números como parâmetro: o primeiro é o número a ser validado e o segundo é 
o número que será verificado a divisão. Exemplo: EhDivisivelPor(15, 5) → valida se 15 é divisível por 5. 
 * 
 * 
 * */

namespace TDD
{
    public static class ValidadorDeNumeros
    {
        public static bool ENumeroPrimo(int n)
        {
            int contador = 0;
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    contador++;
                
            if (contador == 2)
                return true;
                        
            return false;            
        }


        public static string ParOuImpar(int n)
        {
            if (n % 2 ==0)
                return "Par";
            
            return "Impar";            
        }



        public static bool EDivisivelPor(int dividendo, int divisor)
        {
            if (dividendo % divisor == 0)
                return true;
                        
            return false;
        }

    }
}
