# 📘 Fundamentos de Lógica de Programação com C#

Este repositório contém um material completo de revisão para os principais conceitos de lógica de programação utilizando a linguagem **C#**.

---

## 🔹 Tipos Básicos de Dados

| Tipo    | Descrição                                   | Exemplo                  |
| ------- | ------------------------------------------- | ------------------------ |
| int     | Números inteiros                            | `int idade = 30;`        |
| double  | Números com ponto flutuante (alta precisão) | `double pi = 3.14;`      |
| float   | Similar ao double, menos preciso            | `float altura = 1.75f;`  |
| decimal | Muito preciso, ideal para finanças          | `decimal preco = 9.99m;` |
| bool    | Verdadeiro ou falso                         | `bool ativo = true;`     |
| char    | Um caractere                                | `char letra = 'A';`      |
| string  | Conjunto de caracteres                      | `string nome = "Ana";`   |
| var     | Tipo implícito, o compilador infere         | `var x = 100;`           |

---

## 🔹 Restrições E Convenções Para Nomes

- Regras para nomear variáveis, funções e classes: sem espaços, não iniciar com número, evitar palavras reservadas.

- Convenções: camelCase para variáveis, PascalCase para métodos e classes.

```csharp
using System;

namespace ExemploNomes
{
    // Classe usando PascalCase
    public class Calculadora
    {
        // Propriedade usando PascalCase
        public int Resultado { get; set; }

        // Método usando PascalCase
        public void Somar(int primeiroNumero, int segundoNumero)
        {
            // Variáveis usando camelCase
            int soma = primeiroNumero + segundoNumero;
            Resultado = soma;
        }

        public void Subtrair(int primeiroNumero, int segundoNumero)
        {
            // Variáveis usando camelCase
            int resultadoSubtracao = primeiroNumero - segundoNumero;
            Resultado = resultadoSubtracao;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis usando camelCase
            int numero1 = 10;
            int numero2 = 5;
            Calculadora calculadora = new Calculadora();

            calculadora.Somar(numero1, numero2);
            Console.WriteLine("Soma: " + calculadora.Resultado);

            calculadora.Subtrair(numero1, numero2);
            Console.WriteLine("Subtração: " + calculadora.Resultado);
        }
    }
}


```

---

## 🔹 Entrada e Saída de Dados

### 📤 Saída

```csharp
Console.Write("Olá ");        // Sem quebra de linha
Console.WriteLine("mundo!");  // Com quebra de linha
Console.WriteLine($"Nome: {nome}"); // Interpolação
```

### 📥 Entrada

```csharp
string nome = Console.ReadLine();
int idade = int.Parse(Console.ReadLine());
double preco = Convert.ToDouble(Console.ReadLine());
```

---

## 🔹 Operadores

### Aritméticos

`+`, `-`, `*`, `/`, `%`

### Atribuição

`=`, `+=`, `-=`, `*=`, `/=`, `%=`

### Comparação

`==`, `!=`, `<`, `>`, `<=`, `>=`

### Lógicos

`&&` (E), `||` (OU), `!` (NÃO)

---

## 🔹 Estruturas Condicionais

### if / else

```csharp
if (idade >= 18) {
    Console.WriteLine("Maior de idade");
} else {
    Console.WriteLine("Menor de idade");
}
```

### Operador Ternário

```csharp
string status = (idade >= 18) ? "Adulto" : "Menor";
```

### Switch

```csharp
int diaDaSemana = 3;

switch (diaDaSemana)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda-feira");
        break;
    case 3:
        Console.WriteLine("Terça-feira");
        break;
    case 4:
        Console.WriteLine("Quarta-feira");
        break;
    case 5:
        Console.WriteLine("Quinta-feira");
        break;
    case 6:
        Console.WriteLine("Sexta-feira");
        break;
    case 7:
        Console.WriteLine("Sábado");
        break;
    default:
        Console.WriteLine("Dia inválido");
        break;
}

```

---

## 🔹 Escopo e Inicialização

- Variáveis devem ser inicializadas antes do uso.
- Escopo é definido entre `{ }`, ou seja, uma variável só é acessível dentro do bloco onde foi declarada.

---

## 🔹 Funções em C#

```csharp
static int Soma(int a, int b) {
    return a + b;
}

static void MostrarMensagem() {
    Console.WriteLine("Olá mundo!");
}
```

- `void`: sem retorno
- `return`: usado para retornar valores

---

## 🔹 Estruturas de Repetição

### while

```csharp
int i = 0;
while (i < 5) {
    Console.WriteLine(i);
    i++;
}
```

### for

```csharp
for (int i = 0; i < 5; i++) {
    Console.WriteLine(i);
}
```

---

## 🔹 Debugging no Visual Studio

- **Breakpoints**: pausam a execução no ponto desejado
- **F10**: executa linha a linha
- **F11**: entra em funções
- **Watch/Inspeção**: permite ver valores de variáveis

---

## 🔹 Exercícios de Fixação

- 📝 [Lista de Exercícios](./fundamentos/exercicios.md)

---

## 🧠 Ideal para:

- Estudantes iniciantes em C#
- Revisão para provas ou entrevistas
- Base sólida em lógica de programação

---

## ✅ Contribuição

Sinta-se livre para sugerir melhorias ou adicionar novos tópicos!

---

> Criado com foco em clareza, prática e aplicabilidade.
