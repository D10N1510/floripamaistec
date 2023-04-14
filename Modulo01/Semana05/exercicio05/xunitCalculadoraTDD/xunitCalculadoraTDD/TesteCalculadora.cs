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
            Assert.Equal(4, Calculadora.Soma(2, 2));
        }

        [Fact]
        [Trait("Categoria", "Soma")]
        public void TestMetodoSomarDouble(){
            Assert.Equal(15.98, Calculadora.Soma(10.5, 5.48));
        }

        [Fact]
        [Trait("Categoria", "Soma")]
        public void TestMetodoSomarFloat(){
            Assert.Equal(20.98f, Calculadora.Soma(15.5f, 5.48f));
        }

        [Fact]
        [Trait("Categoria", "Soma")]
        public void TestMetodoSomarDecimal(){
            Assert.Equal(30.98M, Calculadora.Soma(5.5M, 25.48M));
        }

        [Fact]
        [Trait("Categoria", "Soma")]
        public void TestMetodoSomarLong(){
            Assert.Equal(90000, Calculadora.Soma(70000, 20000));
        }

        [Fact]
        [Trait("Categoria", "Subtração")]
        public void TestMetodoSubtrairInt()
        {
            Assert.Equal(3, Calculadora.Subtracao(8, 5));
        }

        [Fact]
        [Trait("Categoria", "Subtração")]
        public void TestMetodoSubtrairDouble()
        {
            Assert.Equal(3.0, Calculadora.Subtracao(5.0, 2.0));
        }

        [Fact]
        [Trait("Categoria", "Subtração")]
        public void TestMetodoSubtrairFloat()
        {
            Assert.Equal(-1.0f, Calculadora.Subtracao(3.0f, 4.0f));
        }

        [Fact]
        [Trait("Categoria", "Subtração")]
        public void TestMetodoSubtrairDecimal()
        {
            Assert.Equal(0.02M, Calculadora.Subtracao(5.5M, 5.48M));
        }

        [Fact]
        [Trait("Categoria", "Subtração")]
        public void TestMetodoSubtrairLong()
        {
            Assert.Equal(50000, Calculadora.Subtracao(70000, 20000));
        }


        [Fact]
        [Trait("Categoria", "Multiplicacao")]
        public void TestMetodoMultiplicacaoInt()
        {
            Assert.Equal(15, Calculadora.Multiplicacao(3, 5));
        }

        [Fact]
        [Trait("Categoria", "Multiplicacao")]
        public void TestMetodoMultiplicacaoDouble()
        {
            Assert.Equal(30.14, Calculadora.Multiplicacao(5.5, 5.48));
        }

        [Fact]
        [Trait("Categoria", "Multiplicacao")]
        public void TestMetodoMultiplicacaoFloat()
        {
            Assert.Equal(30.14f, Calculadora.Multiplicacao(5.5f, 5.48f));
        }

        [Fact]
        [Trait("Categoria", "Multiplicacao")]
        public void TestMetodoMultiplicacaoDecimal()
        {
            Assert.Equal(30.14M, Calculadora.Multiplicacao(5.5M, 5.48M));
        }

        [Fact]
        [Trait("Categoria", "Multiplicacao")]
        public void TestMetodoMultiplicacaoLong()
        {
            Assert.Equal(6000000000L, Calculadora.Multiplicacao(120000L, 50000L));
        }



        [Fact]
        [Trait("Categoria", "Divisao")]
        public void TestMetodoDivisaoInt()
        {
            Assert.Equal(3, Calculadora.Divisao(15, 5));
        }

        [Fact]
        [Trait("Categoria", "Divisao")]
        public void TestMetodoDivisaoDouble()
        {
            Assert.Equal(4.1, Calculadora.Divisao(20.5, 5.00));
        }

        [Fact]
        [Trait("Categoria", "Divisao")]
        public void TestMetodoDivisaoFloat()
        {
            Assert.Equal(4.1f, Calculadora.Divisao(20.5f, 5.00f));
        }

        [Fact]
        [Trait("Categoria", "Divisao")]
        public void TestMetodoDivisaoDecimal()
        {
            Assert.Equal(4.1M, Calculadora.Divisao(20.5M, 5.00M));
        }

        [Fact]
        [Trait("Categoria", "Divisao")]
        public void TestMetodoDivisaoLong()
        {
            Assert.Equal(2, Calculadora.Divisao(100000, 50000));
        }



    }
}
