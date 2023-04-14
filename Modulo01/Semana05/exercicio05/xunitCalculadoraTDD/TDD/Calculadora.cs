using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    /*
     Usando os conceitos de TDD e o framework NUnit, crie sobrecargas para os métodos da classe Calculadora que deverá possibilitar fazer operações com dados do tipo double, float, decimal e long.

        Exemplo de assinaturas do método soma:

        soma(int a, int b)
        soma(double a, double b)
        soma(float a, float b)
        soma(decimal a, decimal b)
        soma(long a, long b)
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


        public static double Soma(double a, double b)
        {
            return a + b;
        }

        public static double Subtracao(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicacao(double a, double b)
        {
            return a * b;
        }

        public static double Divisao(double a, double b)
        {
            return a / b;
        }


        public static float Soma(float a, float b)
        {
            return a + b;
        }

        public static float Subtracao(float a, float b)
        {
            return a - b;
        }

        public static float Multiplicacao(float a, float b)
        {
            return a * b;
        }

        public static float Divisao(float a, float b)
        {
            return a / b;
        }


        public static decimal Soma(decimal a, decimal b)
        {
            return a + b;
        }

        public static decimal Subtracao(decimal a, decimal b)
        {
            return a - b;
        }

        public static decimal Multiplicacao(decimal a, decimal b)
        {
            return a * b;
        }

        public static decimal Divisao(decimal a, decimal b)
        {
            return a / b;
        }

        public static long Soma(long a, long b)
        {
            return a + b;
        }

        public static long Subtracao(long a, long b)
        {
            return a - b;
        }

        public static long Multiplicacao(long a, long b)
        {
            return a * b;
        }

        public static long Divisao(long a, long b)
        {
            return a / b;
        }
    }
}
