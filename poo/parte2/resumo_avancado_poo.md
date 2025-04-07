
# 🧱 POO em C# - Parte 2: Construtores, Encapsulamento, Properties

Este resumo cobre conceitos intermediários de Programação Orientada a Objetos em C#.

---

## 🔸 Construtores

Um **construtor** é um método especial usado para inicializar objetos quando são instanciados.

```csharp
class Produto {
    public string Nome;
    public double Preco;

    public Produto(string nome, double preco) {
        Nome = nome;
        Preco = preco;
    }
}
```

- Tem o mesmo nome da classe
- Pode ter parâmetros
- É executado automaticamente na criação do objeto

---

## 🔸 Sobrecarga

**Sobrecarga** permite criar múltiplos construtores (ou métodos) com o mesmo nome, desde que tenham assinaturas diferentes.

```csharp
public Produto() {
}

public Produto(string nome) {
    Nome = nome;
}

public Produto(string nome, double preco) {
    Nome = nome;
    Preco = preco;
}
```

---

## 🔸 Sintaxe Alternativa Para Inicializar Valores

É possível usar inicializadores de objeto:

```csharp
Produto p = new Produto { Nome = "TV", Preco = 900.0 };
```

Muito útil com construtor padrão ou propriedades públicas.

---

## 🔸 Palavra `this`

A palavra-chave `this` é usada para referenciar o objeto atual da classe, útil para evitar ambiguidade:

```csharp
public Produto(string nome) {
    this.Nome = nome;
}
```

---

## 🔸 Encapsulamento

**Encapsulamento** é a prática de restringir o acesso direto aos dados internos de um objeto. Utiliza-se métodos (get/set) ou **propriedades** para controlar esse acesso.

---

## 🔸 Properties

**Propriedades** permitem definir regras de leitura e escrita para atributos.

```csharp
private double _preco;

public double Preco {
    get { return _preco; }
    set { if (value > 0) _preco = value; }
}
```

---

## 🔸 Auto Properties

**Auto-properties** são propriedades com sintaxe reduzida, ideais quando não há lógica adicional no get/set.

```csharp
public string Nome { get; set; }
public double Preco { get; private set; }
```

- Pode-se restringir o `set` (somente leitura fora da classe)

---

## 🔸 Ordem Sugerida Para Implementação De Membros

1. Atributos privados
2. Propriedades (public)
3. Construtores
4. Métodos públicos
5. Métodos privados

---

## 🔸 Modificadores De Acesso

Controlam a visibilidade dos membros da classe:

| Modificador     | Acesso                                               |
|-----------------|------------------------------------------------------|
| `public`        | Acessível de qualquer lugar                          |
| `private`       | Acessível somente dentro da própria classe           |
| `protected`     | Acessível na própria classe ou em classes derivadas  |
| `internal`      | Acessível dentro do mesmo assembly                   |
| `protected internal` | Dentro do assembly ou subclasses                |

---

## ✅ Conclusão

Estes conceitos ajudam a escrever código mais seguro, organizado e reutilizável:
- Construtores simplificam a inicialização
- Encapsulamento protege os dados
- Propriedades controlam o acesso com clareza

