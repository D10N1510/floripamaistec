using TDD;

namespace xunitValidadorNumerosTDD
{
    public class ValidadorDeNumerosTest
    {
        [Fact]
        public void TesteENumeroPrimo()
        {
            Assert.True(ValidadorDeNumeros.ENumeroPrimo(5));
        }

        [Fact]
        public void TesteParOuImpar()
        {
            Assert.Equal("Impar", ValidadorDeNumeros.ParOuImpar(9));
        }

        [Fact]
        public void TesteEhDivisivelPor()
        {
            Assert.True(ValidadorDeNumeros.EDivisivelPor(20, 5));
        }
    }
}