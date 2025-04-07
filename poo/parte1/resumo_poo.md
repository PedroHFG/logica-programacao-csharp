
# 🧱 Programação Orientada a Objetos com C# - Fundamentos

Este documento resume os principais conceitos iniciais da programação orientada a objetos em C#.  
A ideia central da POO é representar entidades do mundo real por meio de **classes** e **objetos**, encapsulando dados e comportamentos.

---

## 🔸 Criando uma Classe - Exemplo: Triângulo

Em vez de lidar com variáveis soltas para representar um triângulo, podemos agrupar os lados A, B e C dentro de uma **classe**.

```csharp
class Triangulo {
    public double A;
    public double B;
    public double C;
}
```

Isso melhora a organização e facilita a reutilização do código.

---

## 🔸 Atributos e Objetos

A **classe** define o "molde", enquanto o **objeto** é a instância real que usa esse molde.

```csharp
Triangulo x = new Triangulo();
x.A = 3.0;
x.B = 4.0;
x.C = 5.0;
```

Assim podemos criar quantos triângulos quisermos com a mesma estrutura.

---

## 🔸 Adicionando Métodos à Classe

Métodos representam comportamentos.  
Neste exemplo, colocamos dentro da classe `Triangulo` a lógica para calcular a área, centralizando a responsabilidade.

```csharp
public double Area() {
    double p = (A + B + C) / 2.0;
    return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
}
```

Isso promove **reutilização** e **encapsulamento**.

---

## 🔸 Projeto Produto - Encapsulando Regras

Modelamos um produto com nome, preço e quantidade.  
Métodos como `AdicionarProdutos()` e `RemoverProdutos()` controlam o estado do objeto.

```csharp
class Produto {
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotalEmEstoque() {
        return Preco * Quantidade;
    }

    public void AdicionarProdutos(int quantidade) {
        Quantidade += quantidade;
    }

    public void RemoverProdutos(int quantidade) {
        Quantidade -= quantidade;
    }

    public override string ToString() {
        return Nome + ", $ " + Preco.ToString("F2") + ", "
            + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2");
    }
}
```

---

## 🔸 Membros Estáticos

Membros estáticos pertencem à **classe**, não aos objetos.  
São úteis para cálculos ou constantes que não dependem de estado.

```csharp
class Calculadora {
    public static double Pi = 3.14;

    public static double Circunferencia(double r) {
        return 2.0 * Pi * r;
    }

    public static double Volume(double r) {
        return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
    }
}
```

Uso:
```csharp
double c = Calculadora.Circunferencia(raio);
```

---

## 🔸 Exercício Prático com Membro Estático

Criamos uma classe `ConversorDeMoeda` para converter valores com IOF incluso, sem precisar de instanciar objetos.

```csharp
class ConversorDeMoeda {
    public static double Iof = 6.0;

    public static double DolarParaReal(double quantia, double cotacao) {
        double total = quantia * cotacao;
        return total + total * Iof / 100.0;
    }
}
```

---

## 📌 Conclusão

Com os conceitos iniciais de POO em C#, você pode:

- Representar entidades com atributos e comportamentos
- Delegar responsabilidades para as próprias classes
- Evitar repetição com métodos reutilizáveis
- Usar membros estáticos quando não há necessidade de estado

Esses fundamentos serão a base para avançar em conceitos como encapsulamento, herança e polimorfismo.

