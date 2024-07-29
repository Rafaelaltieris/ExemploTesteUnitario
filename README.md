# <img src="https://upload.wikimedia.org/wikipedia/commons/4/4f/Csharp_Logo.png" alt="C# Logo" width="150" style="vertical-align: middle;"/> <img src="https://avatars.githubusercontent.com/u/27236192?s=200&v=4" alt="xUnit Logo" width="150" style="vertical-align: middle;"/>

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
Contribuição
Sinta-se à vontade para fazer melhorias ou adicionar novos recursos. Envie um pull request para contribuir.

Licença
Este projeto está licenciado sob a MIT License.
