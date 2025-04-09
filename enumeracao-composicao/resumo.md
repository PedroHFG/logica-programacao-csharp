
# 📘 C# - Enumerações, Design e Composição

Este documento traz um resumo teórico com exemplos práticos sobre Enumerações, Design de Classes e Composição em C#.

---

## 🔹 Enumerações (`enum`)

Uma **enumeração** é um tipo especial em C# que define um conjunto de **constantes nomeadas**. É ideal para representar valores fixos e conhecidos, como status de pedido, níveis de acesso, tipos de usuário etc.

### ✔️ Vantagens:
- Código mais legível e semântico
- Ajuda do compilador (autocomplete e validação)
- Reduz o uso de "números mágicos" no código

### 🧱 Exemplo - Ciclo de vida de um pedido:
```csharp
enum OrderStatus {
    PendingPayment,
    Processing,
    Shipped,
    Delivered
}

class Order {
    public int Id { get; set; }
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
}
```

### 🔄 Conversões:
```csharp
OrderStatus status = OrderStatus.Shipped;
string texto = status.ToString(); // "Shipped"

OrderStatus status2 = Enum.Parse<OrderStatus>("Delivered");
int num = (int)OrderStatus.Processing; // 1
```

---

## 🔹 Design de Classes Orientado a Objetos

Ao desenvolver um sistema orientado a objetos, buscamos dividir o código em **categorias de classes** para obter maior **organização**, **flexibilidade** e **reutilização**.

### 🎯 Categorias Comuns:

| Categoria     | Responsabilidade Principal                       |
|---------------|--------------------------------------------------|
| `Entities`    | Representam dados e regras básicas               |
| `Services`    | Executam lógica de negócio                       |
| `Controllers` | Controlam entrada/saída e chamadas de serviço    |
| `Views`       | Interface com o usuário                          |
| `Repositories`| Acesso e persistência de dados                   |
| `Utils`       | Funções auxiliares de uso geral                  |

### 🧠 Exemplo de estrutura:
```csharp
class Client { ... }            // Entity
class Order { ... }             // Entity
class OrderService { ... }      // Service
class OrderController { ... }   // Controller
```

Separar responsabilidades ajuda a aplicar princípios como **SRP (Responsabilidade Única)** e facilita **testes e manutenção**.

---

## 🔹 Composição

A **composição** é uma forma de criar relacionamentos entre objetos no estilo **“tem-um”** ou **“tem-muitos”**. É usada para construir objetos complexos a partir de objetos mais simples.

### 🧱 Exemplo - Um Trabalhador tem um Departamento:
```csharp
class Department {
    public string Name { get; set; }
}

class Worker {
    public string Name { get; set; }
    public Department Department { get; set; }  // Composição
}
```

### 🧱 Exemplo - Um Pedido com Cliente e Itens:
```csharp
class Client {
    public string Name { get; set; }
    public string Email { get; set; }
}

class Product {
    public string Name { get; set; }
    public double Price { get; set; }
}

class OrderItem {
    public int Quantity { get; set; }
    public Product Product { get; set; }

    public double SubTotal() {
        return Product.Price * Quantity;
    }
}

class Order {
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public Client Client { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();

    public double Total() {
        double sum = 0;
        foreach (OrderItem item in Items) {
            sum += item.SubTotal();
        }
        return sum;
    }
}
```

### 🎯 Vantagens da Composição:
- Favorece **coesão** e **separação de responsabilidades**
- Torna o sistema mais **flexível e modular**
- Estimula o **reaproveitamento de código**

---

## ✅ Conclusão

- **Enumerações** permitem representar valores constantes de forma legível.
- Um bom **design orientado a objetos** usa categorias de classes para modularidade e clareza.
- A **composição** permite criar estruturas complexas e reutilizáveis, centralizando dados e comportamentos.

Esses conceitos são fundamentais para criar sistemas robustos, bem estruturados e de fácil manutenção em C#.
