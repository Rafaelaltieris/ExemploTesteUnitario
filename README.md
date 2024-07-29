# <img src="https://upload.wikimedia.org/wikipedia/commons/4/4f/Csharp_Logo.png" alt="C# Logo" width="150"/> <img src="[https://xunit.net/images/xunit-logo.png](https://www.google.com/imgres?q=xunit%20logo&imgurl=https%3A%2F%2Fmedia.licdn.com%2Fdms%2Fimage%2FD4E12AQE4AmAdWfL3sQ%2Farticle-cover_image-shrink_600_2000%2F0%2F1695127505668%3Fe%3D2147483647%26v%3Dbeta%26t%3DziuXm_riVZkSTXxDED73oH62D_VLoupVaZKdeF9oTxQ&imgrefurl=https%3A%2F%2Fwww.linkedin.com%2Fpulse%2Funit-testing-based-xunit-net-vahid-alizadeh&docid=2HQyQ4M7TXgldM&tbnid=eOtHKeKOJWj5JM&vet=12ahUKEwiFwaKDgM2HAxUxObkGHXxqOkAQM3oECBwQAA..i&w=827&h=279&hcb=2&ved=2ahUKEwiFwaKDgM2HAxUxObkGHXxqOkAQM3oECBwQAA)" alt="xUnit Logo" width="150"/>

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
