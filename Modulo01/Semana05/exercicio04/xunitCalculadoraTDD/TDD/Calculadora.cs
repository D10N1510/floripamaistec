using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    /*
     Usando os conceitos de TDD e o framework NUnit, crie uma classe estática chamada Calculadora que deverá 
     conter os seguintes métodos:
        soma
        subtração
        multiplicação
        divisão
        Neste primeiro exercício considere apenas operações utilizando números inteiros
     */
    public static class Calculadora
    {
        public static int Soma(int a, int b)
        {
            return a + b;
        }

        public static int Subtracao(int a, int b)
        {
            return a - b;
        }

        public static int Multiplicacao(int a, int b)
        {
            return a * b;
        }

        public static int Divisao(int a, int b)
        {
            return a / b;
        }

    }
}
