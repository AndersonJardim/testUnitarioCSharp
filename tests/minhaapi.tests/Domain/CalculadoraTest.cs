using FluentAssertions;
using minhaapi.Domain;
using Xunit;

namespace minhaapi.tests.Domain
{
    public class CalculadoraTest
    {
        [Fact]
        public void SomarTeste_1_1_Deveria_Ser2()
        {
            var resultado = Calculadora.Somar(1, 1);
            resultado.Should().Be(2);
        }



        [Fact]
        public void TesteSomar()
        {
            Assert.Equal(20, Calculadora.Somar(10, 10));
        }

        [Fact]
        public void TesteSubtrair()
        {
            Assert.Equal(0, Calculadora.Subtrair(10, 10));
        }


        [Fact]
        public void TesteMultiplicar()
        {
            Assert.Equal(100, Calculadora.Multiplicar(10, 10));
        }

        [Fact]
        public void TesteDividir()
        {
            Assert.Equal(1, Calculadora.Dividir(10, 10));
        }

    }
}