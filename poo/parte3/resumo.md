
# 🧬 C# - Herança e Polimorfismo

Este documento resume os principais conceitos sobre **Herança e Polimorfismo** em C#, incluindo práticas de mercado, exemplos e explicações ampliadas.

---

## 🔹 Herança

A **herança** permite que uma classe (subclasse) herde atributos e métodos de outra classe (superclasse), promovendo **reutilização de código** e **especialização**.

### 📌 Palavras-chave:
- `:` (para herdar)
- `base` (para acessar membros da superclasse)

### 🧱 Exemplo:
```csharp
class Account {
    public int Number;
    public string Holder;
    public double Balance;

    public void Deposit(double amount) {
        Balance += amount;
    }
}

class BusinessAccount : Account {
    public double LoanLimit;

    public void Loan(double amount) {
        if (amount <= LoanLimit) {
            Balance += amount;
        }
    }
}
```

---

## 🔹 Upcasting e Downcasting

### Upcasting
Conversão da subclasse para superclasse (seguro e implícito).
```csharp
Account acc = new BusinessAccount();
```

### Downcasting
Conversão da superclasse para subclasse (explícito e requer cuidado).
```csharp
BusinessAccount bacc = (BusinessAccount)acc;
```

Recomenda-se o uso de `is` ou `as`:
```csharp
if (acc is BusinessAccount) { ... }
BusinessAccount bacc = acc as BusinessAccount;
```

---

## 🔹 Sobreposição (`virtual`, `override`, `base`)

### Sobreposição (override)
Permite que uma subclasse forneça sua **própria versão** de um método da superclasse.

```csharp
class Account {
    public virtual void Withdraw(double amount) {
        Balance -= amount + 5.0;
    }
}

class SavingsAccount : Account {
    public override void Withdraw(double amount) {
        Balance -= amount; // Sem taxa
    }
}
```

### Uso de `base`
Chama a implementação da superclasse:

```csharp
public override void Withdraw(double amount) {
    base.Withdraw(amount);
    Balance -= 2.0;
}
```

---

## 🔹 Classes e Métodos Selados (`sealed`)

### Classe `sealed`
Impede que uma classe seja herdada.

```csharp
sealed class SavingsAccount { ... }
```

### Método `sealed`
Impede que o método sobrescrito possa ser sobrescrito novamente.

```csharp
public sealed override void Withdraw(double amount) { ... }
```

### 🛡️ Motivos:
- Segurança
- Manutenção do design
- Performance (otimizações em tempo de execução)

---

## 🔹 Polimorfismo

Permite que **referências de uma superclasse** apontem para **objetos de subclasses**, executando comportamentos diferentes.

### Exemplo:
```csharp
Account acc1 = new Account(...);
Account acc2 = new SavingsAccount(...);

acc1.Withdraw(10); // chama método da classe base
acc2.Withdraw(10); // chama método sobrescrito
```

---

## 🔹 Classes Abstratas

Uma **classe abstrata**:
- **Não pode ser instanciada**
- Pode conter **métodos abstratos** (sem implementação)
- Garante **herança total** e aplicação de **polimorfismo**

```csharp
abstract class Shape {
    public abstract double Area();
}
```

---

## 🔹 Métodos Abstratos

- Devem ser **implementados obrigatoriamente** nas subclasses concretas
- Fornecem uma "interface mínima" que todas as subclasses devem seguir

```csharp
abstract class Shape {
    public string Color { get; set; }
    public abstract double Area();
}

class Circle : Shape {
    public double Radius { get; set; }

    public override double Area() {
        return Math.PI * Radius * Radius;
    }
}
```

---

## ✅ Conclusão

Herança e polimorfismo são **pilares essenciais da orientação a objetos**.  
Permitem:
- Reutilização e extensão de código
- Generalização de comportamentos com especialização quando necessário
- Flexibilidade para lidar com diferentes tipos em tempo de execução

Aplicar esses conceitos corretamente traz clareza, organização e robustez aos sistemas em C#.
