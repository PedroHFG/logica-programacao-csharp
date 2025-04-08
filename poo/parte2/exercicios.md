
# 📝 Lista de Exercícios - POO Avançado em C#

Esta lista é voltada para a prática de construtores, encapsulamento, properties e membros com controle de acesso.

---

## 🔹 Construtores e Sobrecarga

1. Crie uma classe `Pessoa` com os atributos `Nome` e `Idade`. Implemente:
   - Um construtor sem parâmetros
   - Um construtor com os dois parâmetros
   - Um método `Exibir()` que imprime os dados

2. Crie uma classe `Produto` com três construtores:
   - Um sem parâmetros
   - Um com nome e preço
   - Um com nome, preço e quantidade

3. Crie uma classe `Livro` com os atributos `Titulo`, `Autor` e `Ano`. Implemente:
   - Um construtor padrão
   - Um construtor que recebe todos os dados
   - Um método que retorna uma string formatada com os dados

---

## 🔹 Sintaxe Alternativa e Palavra `this`

4. Reescreva a classe `Produto` anterior utilizando inicialização via `this` nos construtores.
5. Instancie objetos usando inicializadores de objeto (`new Produto { Nome = "...", ... }`).

---

## 🔹 Encapsulamento e Properties

6. Crie uma classe `ContaBancaria` com:
   - Atributos privados: `Numero`, `Titular`, `Saldo`
   - Properties públicas com regras: `Titular` pode ser alterado, `Saldo` só leitura
   - Método `Depositar()` e `Sacar()` com validações

7. Crie uma classe `Temperatura` com atributo privado `_celsius`:
   - Property `Celsius` com validação (> -273.15)
   - Property somente leitura `Fahrenheit` que calcula com base no valor em Celsius

---

## 🔹 Auto Properties e Modificadores

8. Crie uma classe `Cliente` com auto-properties `Nome`, `Email` e `DataNascimento`.
9. Reforce a visibilidade:
   - Use `private set` para impedir alteração direta de `DataNascimento`
   - Torne a classe visível apenas dentro do assembly (`internal`)

---

## 🔹 Desafio Final

10. Modele uma classe `ProdutoDigital` com:
   - Nome, Preço, TamanhoEmMB
   - Método para aplicar desconto (em %)
   - Uso de auto-properties
   - Construtor com parâmetros

