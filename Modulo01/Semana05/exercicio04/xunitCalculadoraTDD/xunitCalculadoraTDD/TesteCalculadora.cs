using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD;
using Xunit;

namespace TDD_test
{
    public class TesteCalculadora
    {
        [Fact]
        [Trait("Categoria", "Soma")]
        public void TestMetodoSomarInt()
        {
            int resultado = Calculadora.Soma(2, 2);
            int esperado = 4;
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Subtração")]
        public void TestMetodoSubtrairInt()
        {
            int resultado = Calculadora.Subtracao(8, 5);
            int esperado = 3;
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Multiplicacao")]
        public void TestMetodoMultiplicacaoInt()
        {
            int resultado = Calculadora.Multiplicacao(3, 5);
            int esperado = 15;
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Divisao")]
        public void TestMetodoDivisaoInt()
        {
            int resultado = Calculadora.Divisao(15, 5);
            int esperado = 3;
            Assert.Equal(esperado, resultado);
        }
    }
}
