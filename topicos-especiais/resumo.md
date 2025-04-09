
# ✨ Tópicos Especiais de C# - Resumo Teórico

Este resumo apresenta alguns recursos úteis e avançados da linguagem C# relacionados a manipulação de strings, datas e horários.

---

## 🔹 Funções Interessantes Para `string`

A classe `string` possui diversos métodos úteis para manipulação de texto:

```csharp
string original = "  CSharp é poderoso!  ";
```

### Métodos comuns:
- `ToUpper()`, `ToLower()`: conversão para maiúsculas/minúsculas
- `Trim()`: remove espaços em branco das extremidades
- `Substring(inicio, comprimento)`: extrai parte da string
- `Replace("a", "b")`: substitui caracteres
- `IndexOf("palavra")`: posição da substring
- `LastIndexOf("palavra")`: última ocorrência
- `Split(' ')`: quebra a string em partes com base no separador
- `StartsWith()`, `EndsWith()`, `Contains()`: verificação de padrões

---

## 🔹 `DateTime`, Propriedades e Operações

A estrutura `DateTime` é usada para manipular datas e horas.

```csharp
DateTime agora = DateTime.Now;
DateTime hoje = DateTime.Today;
DateTime especifico = new DateTime(2025, 4, 8, 14, 30, 0);
```

### Propriedades úteis:
- `Now`, `Today`, `UtcNow`
- `Day`, `Month`, `Year`, `Hour`, `Minute`, `Second`

### Operações:
```csharp
DateTime futuro = agora.AddDays(7);
TimeSpan diferenca = futuro - agora;
```

- Comparação: `if (data1 > data2)`
- Formatação: `data.ToString("dd/MM/yyyy")`

---

## 🔹 `TimeSpan`, Propriedades e Operações

`TimeSpan` representa um intervalo de tempo (duração).

```csharp
TimeSpan duracao = new TimeSpan(2, 30, 0); // 2h30min
```

### Propriedades:
- `TotalDays`, `TotalHours`, `Minutes`, `Seconds`

### Operações:
```csharp
TimeSpan soma = duracao + TimeSpan.FromMinutes(15);
TimeSpan diferenca = TimeSpan.FromDays(1) - duracao;
```

- Pode ser usado para medir tempos entre duas datas (`DateTime2 - DateTime1`)

---

## 🔹 `DateTimeKind` e Padrão ISO 8601

### `DateTimeKind`
Define o tipo de contexto de tempo:
- `Local`: horário local do sistema
- `Utc`: horário universal coordenado
- `Unspecified`: não especificado

```csharp
DateTime local = DateTime.Now;
Console.WriteLine(local.Kind); // Local
```

### ISO 8601

Formato internacional padrão para data/hora:
- `"2025-04-08T14:30:00Z"` representa UTC
- `"2025-04-08T14:30:00"` representa local

Usado para interoperabilidade entre sistemas e APIs.

```csharp
DateTime data = DateTime.Parse("2025-04-08T14:30:00Z", null, DateTimeStyles.RoundtripKind);
```

---

## ✅ Conclusão

Esses recursos tornam o C# extremamente poderoso para manipulação de texto e tempo:
- Strings são facilmente formatadas e analisadas
- `DateTime` e `TimeSpan` oferecem controle detalhado sobre tempo e duração
- Padrões como ISO 8601 facilitam integração com outras plataformas
