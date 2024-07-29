# Projeto Calculadora

Bem-vindo ao projeto **Calculadora**! Este projeto é uma implementação simples de uma calculadora em C# que suporta operações básicas como soma, subtração, multiplicação e divisão. Além disso, o projeto inclui testes unitários para garantir a precisão das operações.

## Tecnologias Utilizadas

- **Linguagem de Programação**: C#
- **Framework de Testes**: xUnit
- **IDE**: Visual Studio

## Estrutura do Projeto

O projeto está organizado da seguinte forma:

Calculadora/
├── Calculadora/
│ └── Calculadora.cs
├── TesteCalculadora/
│ └── CalculadoraTeste.cs
├── Calculadora.sln
└── README.md


## Classe Calculadora

A classe `Calculadora` é definida no namespace `CalculadoraApp` e inclui métodos estáticos para realizar operações aritméticas básicas.

### Exemplo de Implementação

```csharp
namespace CalculadoraApp
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

Testes Unitários
Os testes unitários são escritos usando o framework xUnit e estão localizados no projeto TesteCalculadora.

Exemplo de Testes

using Xunit;
using CalculadoraApp;

namespace TesteCalculadora
{
    public class CalculadoraTeste
    {
        [Fact]
        public void Somar_DeveRetornarValorCorreto()
        {
            // Act
            int resultado = Calculadora.Somar(10, 10);

             Assert
            Assert.Equal(20, resultado);
        }

        [Fact]
        public void Subtrair_DeveRetornarValorCorreto()
        {
            // Act
            int resultado = Calculadora.Subtrair(10, 10);

            // Assert
            Assert.Equal(0, resultado);
        }
    }
}

Como Executar os Testes
Clone o repositório para sua máquina local.
Abra o projeto no Visual Studio.
Compile o projeto para restaurar os pacotes NuGet.
Navegue até a janela de Test Explorer.
Execute todos os testes para garantir que tudo está funcionando conforme o esperado.
Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests para adicionar novas funcionalidades ou corrigir bugs.

Licença
Este projeto é licenciado sob a MIT License.

Claro! Aqui está o texto completo formatado para que você possa copiar e colar diretamente:

markdown
Copiar código
# Projeto Calculadora

Bem-vindo ao projeto **Calculadora**! Este projeto é uma implementação simples de uma calculadora em C# que suporta operações básicas como soma, subtração, multiplicação e divisão. Além disso, o projeto inclui testes unitários para garantir a precisão das operações.

## Tecnologias Utilizadas

- **Linguagem de Programação**: C#
- **Framework de Testes**: xUnit
- **IDE**: Visual Studio

## Estrutura do Projeto

O projeto está organizado da seguinte forma:

Calculadora/
├── Calculadora/
│ └── Calculadora.cs
├── TesteCalculadora/
│ └── CalculadoraTeste.cs
├── Calculadora.sln
└── README.md

arduino
Copiar código

## Classe Calculadora

A classe `Calculadora` é definida no namespace `CalculadoraApp` e inclui métodos estáticos para realizar operações aritméticas básicas.

### Exemplo de Implementação

```csharp
namespace CalculadoraApp
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
Testes Unitários
Os testes unitários são escritos usando o framework xUnit e estão localizados no projeto TesteCalculadora.

Exemplo de Testes
csharp
Copiar código
using Xunit;
using CalculadoraApp;

namespace TesteCalculadora
{
    public class CalculadoraTeste
    {
        [Fact]
        public void Somar_DeveRetornarValorCorreto()
        {
            // Act
            int resultado = Calculadora.Somar(10, 10);

            // Assert
            Assert.Equal(20, resultado);
        }

        [Fact]
        public void Subtrair_DeveRetornarValorCorreto()
        {
            // Act
            int resultado = Calculadora.Subtrair(10, 10);

            // Assert
            Assert.Equal(0, resultado);
        }
    }
}
Como Executar os Testes
Clone o repositório para sua máquina local.
Abra o projeto no Visual Studio.
Compile o projeto para restaurar os pacotes NuGet.
Navegue até a janela de Test Explorer.
Execute todos os testes para garantir que tudo está funcionando conforme o esperado.
Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests para adicionar novas funcionalidades ou corrigir bugs.

Licença
Este projeto é licenciado sob a MIT License.

Autor: Rafael Altieris Almeida dos Santos
GitHub: [Seu GitHub](https://github.com/Rafaelaltieris)


Este README.md fornece uma visão geral clara e estruturada do projeto, incluindo informações sobre a tecnologia usada, estrutura do projeto, exemplos de código e instruções sobre como executar os testes. Certifique-se de personalizar os links e informações conforme necessário.
