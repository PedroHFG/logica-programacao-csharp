
# 📝 Exercícios de Fixação - Tratamento de Exceções em C#

Abaixo estão exercícios práticos para reforçar o uso de blocos `try-catch-finally` e criação de exceções personalizadas.

---

## 🔹 1. Conversão Segura

Escreva um programa que leia dois valores inteiros e exiba a divisão entre eles.  
Utilize `try-catch` para tratar as seguintes exceções:
- Divisão por zero
- Formato inválido de entrada

---

## 🔹 2. Cadastro de Produto

Crie uma classe `Produto` com `Nome` e `Quantidade`.  
Faça um método `RemoverEstoque(int quantidade)` e **dispare uma exceção personalizada** (`EstoqueInsuficienteException`) caso a quantidade informada seja maior do que o disponível.

---

## 🔹 3. Operação Bancária

Implemente uma classe `ContaBancaria` com `Saldo`, `LimiteSaque`.  
O método `Sacar(double valor)` deve lançar exceções personalizadas:
- `SaldoInsuficienteException` se o valor for maior que o saldo
- `LimiteExcedidoException` se ultrapassar o limite diário

---

## 🔹 4. Bloco Finally

Crie um programa que simula leitura de um arquivo e garanta (via `finally`) que a operação de "fechar o arquivo" seja sempre executada, mesmo em caso de erro.

---

## 🔹 5. Aplicação Financeira com Validação

Monte um programa que:
- Lê o valor de investimento mensal
- Lê a quantidade de meses
- Calcula o valor final com base em juros compostos

Trate:
- Erros de conversão
- Entrada negativa com exceção personalizada `ValorInvalidoException`

---

Esses exercícios simulam cenários comuns de mercado e ajudam a desenvolver códigos mais resilientes e profissionais.
