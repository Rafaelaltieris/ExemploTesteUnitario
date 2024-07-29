# <img src="https://upload.wikimedia.org/wikipedia/commons/4/4f/Csharp_Logo.png" alt="C# Logo" width="150" style="vertical-align: middle;"/> <img src="https://avatars.githubusercontent.com/u/2092016?s=200&v=4" width="150" style="vertical-align: middle;"/>

# Calculadora com Testes Unitários

Este repositório contém um exemplo de uma calculadora simples implementada em C# com testes unitários utilizando o framework xUnit. Este projeto é destinado a fins educativos, para ajudar a entender como criar e testar uma aplicação básica em C#.

## Estrutura do Projeto

O projeto está dividido em duas partes principais:
1. **Calculadora**: Implementação da calculadora.
2. **Testes**: Testes unitários para verificar a funcionalidade da calculadora.

### Calculadora

A calculadora possui as seguintes funcionalidades:
- **Adicionar**: `Somar(int n1, int n2)`
- **Subtrair**: `Subtrair(int n1, int n2)`
- **Multiplicar**: `Multiplicar(int n1, int n2)`
- **Dividir**: `Dividir(int n1, int n2)`

O código da calculadora está localizado na pasta `src/Calculadora` e é composto pelo seguinte:

```csharp
namespace Calculadora
{
    public static class Calculadora
    {
        public static int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }

        public static int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
```
#### Testes Unitários
Os testes unitários foram implementados utilizando o xUnit. Eles verificam o correto funcionamento das operações da calculadora. Os testes estão localizados na pasta tests/Calculadora.Tests e são compostos pelo seguinte:

```csharp
using Calculadora;
using Xunit;

namespace TesteCalculadora
{
    public class CalculadoraTeste
    {
        [Fact]
        public void Somar()
        {
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
```
Contribuição
Sinta-se à vontade para fazer melhorias ou adicionar novos recursos. Envie um pull request para contribuir.

Licença
Este projeto está licenciado sob a MIT License.
