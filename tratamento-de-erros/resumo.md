
# 🧯 C# - Tratamento de Exceções

Este documento resume os conceitos fundamentais do tratamento de exceções em C#, com explicações e exemplos práticos.

---

## 🔹 Discussão Inicial Sobre Exceções

Uma **exceção** é um erro que ocorre durante a execução do programa.  
Ela interrompe o fluxo normal de execução, e se não for tratada, o programa é finalizado abruptamente.

### Exemplos comuns de exceções:
- `DivideByZeroException`
- `NullReferenceException`
- `IndexOutOfRangeException`
- `FormatException`

### Benefícios do tratamento de exceções:
- Evita que o programa quebre de forma inesperada
- Permite **lidar com erros** de maneira controlada
- Facilita a **manutenção e depuração**

---

## 🔹 Bloco `try-catch`

O bloco `try-catch` captura exceções que possam ocorrer dentro do bloco `try`.

```csharp
try {
    int x = int.Parse(Console.ReadLine());
    int y = 10 / x;
    Console.WriteLine(y);
}
catch (DivideByZeroException e) {
    Console.WriteLine("Erro: divisão por zero.");
}
catch (FormatException e) {
    Console.WriteLine("Erro: formato inválido.");
}
```

### 💡 Dicas:
- Sempre trate **exceções específicas primeiro**
- Pode-se usar `Exception` como última opção genérica
- O objeto `e` permite acessar `Message`, `StackTrace`, entre outros

---

## 🔹 Bloco `finally`

O bloco `finally` é opcional e **sempre será executado**, ocorra ou não uma exceção.  
É usado, por exemplo, para fechar arquivos ou liberar recursos.

```csharp
try {
    // código com potencial de exceção
}
catch (Exception e) {
    Console.WriteLine("Erro: " + e.Message);
}
finally {
    Console.WriteLine("Encerrando o programa.");
}
```

---

## 🔹 Criando Exceções Personalizadas

Você pode criar suas **próprias exceções** derivando da classe `Exception`.

```csharp
class DomainException : ApplicationException {
    public DomainException(string message) : base(message) { }
}
```

### Exemplo de uso:
```csharp
if (quantidade < 0) {
    throw new DomainException("Quantidade não pode ser negativa.");
}
```

### 💼 Boas práticas:
- Nomeie a exceção com sufixo `Exception`
- Utilize para **erros de negócio** ou regras específicas da sua aplicação
- Evite usar para controle de fluxo comum (não abuse de exceções)

---

## ✅ Conclusão

O tratamento de exceções é essencial para sistemas robustos:
- Prevê falhas sem quebrar o programa
- Fornece mensagens claras ao usuário
- Permite criar erros específicos com **exceções personalizadas**
- O bloco `finally` garante que recursos sejam sempre liberados
