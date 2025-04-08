
# 🧠 Memória, Vetores, Listas e Matrizes em C#

Este resumo aborda os conceitos essenciais sobre memória e estruturas de dados como vetores, listas e matrizes em C#.

---

## 🔸 Tipos Referência vs Tipos Valor

- **Tipos Valor**: armazenam o valor diretamente na memória (stack).
  - Ex: `int`, `double`, `bool`, `char`, `struct`
- **Tipos Referência**: armazenam o endereço do valor (heap).
  - Ex: `string`, `array`, `class`, `object`

Modificações em tipos valor não afetam o original. Já os tipos referência compartilham o mesmo endereço de memória.

---

## 🔸 Desalocação de Memória - Garbage Collector e Escopo Local

- O **Garbage Collector** (GC) do .NET gerencia automaticamente a memória.
- Objetos que não possuem mais referências são removidos automaticamente.
- Variáveis locais são desalocadas ao final do escopo do método ou bloco.

---

## 🔸 Nullable

Permite que tipos valor aceitem `null`.

```csharp
int? x = null;
if (x.HasValue) Console.WriteLine(x.Value);
```

Pode ser usado para representar dados opcionais.

---

## 🔸 Vetores

Estrutura fixa de elementos do mesmo tipo.

```csharp
int[] numeros = new int[5];
numeros[0] = 10;
```

Pode ser inicializado com valores:

```csharp
int[] pares = { 2, 4, 6, 8 };
```

---

## 🔸 Modificador de Parâmetros `params`

Permite passar um número variável de argumentos.

```csharp
static int Soma(params int[] valores) {
    int total = 0;
    foreach (int v in valores) total += v;
    return total;
}
```

---

## 🔸 Modificadores de Parâmetros `out` e `ref`

- `ref`: o parâmetro deve ser inicializado antes de ser passado e será modificado.
- `out`: o parâmetro será inicializado dentro do método.

```csharp
void Atualizar(ref int x) { x += 10; }

void Calcular(out int x) { x = 100; }
```

---

## 🔸 Boxing e Unboxing

- **Boxing**: conversão de tipo valor para tipo referência.
- **Unboxing**: o inverso.

```csharp
object obj = 123; // boxing
int n = (int)obj; // unboxing
```

---

## 🔸 Sintaxe Opcional - Laço `foreach`

Usado para percorrer coleções de forma simples:

```csharp
foreach (int item in numeros) {
    Console.WriteLine(item);
}
```

Evita erros de índice e melhora a legibilidade.

---

## 🔸 Listas

Coleção dinâmica que cresce conforme necessário. Pertence ao namespace `System.Collections.Generic`.

```csharp
List<string> nomes = new List<string>();
nomes.Add("Ana");
nomes.Remove("Ana");
```

- Métodos úteis: `Add`, `Remove`, `Insert`, `Find`, `Count`, `Contains`

---

## 🔸 Matrizes

Estrutura bidimensional (ou mais) de dados.

```csharp
int[,] mat = new int[2,3];
mat[0,1] = 10;
```

Percorrendo com `for`:

```csharp
for (int i = 0; i < 2; i++) {
    for (int j = 0; j < 3; j++) {
        Console.Write(mat[i,j] + " ");
    }
}
```

---

## ✅ Conclusão

Esses conceitos são fundamentais para controle de memória e manipulação eficiente de dados:
- Entender tipos valor/referência ajuda a evitar bugs.
- Vetores, listas e matrizes são essenciais em algoritmos.
- Nullable, params, out/ref aumentam a flexibilidade de métodos.
