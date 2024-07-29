using Calculadora;
using System;
using Xunit;

namespace TesteCalculadora
{
    public class CalculadoraTeste
    {
        [Fact]
        public void Somar()
        {
            // Assert
            Assert.Equal(20, Calculadora.Calculadora.Somar(10, 10));
        }

        [Fact]
        public void Subtrair()
        {
            Assert.Equal(0, Calculadora.Calculadora.Subtrair(10, 10));
        }

        [Fact]
        public void Dividir()
        {
            Assert.Equal(1, Calculadora.Calculadora.Dividir(10, 10));
        }

        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(100, Calculadora.Calculadora.Multiplicar(10, 10));
        }
    }
}