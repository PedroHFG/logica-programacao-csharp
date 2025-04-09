# 📝 Exercícios Práticos com Vetores e Listas em C#

Esta lista contém exercícios de prática com vetores e listas, abordando uso de arrays de objetos, controle de índices e aplicação de encapsulamento.

---

## 🔹 Vetor

### 1. Preço Médio de Produtos [Link](./exercicios/Ex01)

> Fazer um programa para ler um número inteiro `N` e os dados (nome e preço) de `N` produtos.  
> Armazene os `N` produtos em um vetor. Em seguida, mostrar o preço médio dos produtos.

#### Requisitos:

- Criar uma classe `Produto` com os atributos `Nome` e `Preco`.
- Utilizar um vetor do tipo `Produto[]`.
- Calcular a média aritmética dos preços.

---

### 2. Pensionato [Link](./exercicios/Ex02)

> A dona de um pensionato possui 10 quartos para alugar (números de 0 a 9).  
> Quando um estudante aluga um quarto, registra-se o nome, email e número do quarto.  
> Fazer um programa que:
>
> - Inicie com todos os 10 quartos vazios.
> - Leia um número `N` (1 ≤ N ≤ 10), que representa o número de estudantes.
> - Para cada estudante, leia nome, email e número do quarto.
> - Ao final, imprima um relatório com as ocupações, por ordem de quarto.

#### Requisitos:

- Criar uma classe `Estudante` com os atributos `Nome` e `Email`.
- Usar um vetor `Estudante[]` de 10 posições.
- Imprimir apenas os quartos ocupados.

---

## 🔹 Lista

### 3. Cadastro e Reajuste Salarial de Funcionários [Link](./exercicios/Ex03)

> Fazer um programa para ler um número inteiro `N` e depois os dados (`id`, `nome` e `salário`) de `N` funcionários.  
> Não deve haver repetição de `id`.  
> Em seguida:
>
> - Efetuar um aumento de `X%` no salário de um funcionário, dado o `id`.
> - Se o `id` informado não existir, mostrar uma mensagem e abortar.
> - Ao final, mostrar a listagem atualizada dos funcionários.

#### Requisitos:

- Criar uma classe `Funcionario` com:
  - Propriedades `Id`, `Nome` e `Salario` (somente leitura externa para `Salario`)
  - Método `AumentarSalario(double porcentagem)`
- Usar `List<Funcionario>`
- Implementar validação de `id` único com busca na lista
