
# 📁 C# - Manipulação de Arquivos

Este documento apresenta os principais conceitos e classes para trabalhar com arquivos no .NET, com foco em leitura, escrita e tratamento seguro.

---

## 🔹 File, FileInfo e IOException

### `File`
Classe estática usada para **operações rápidas** com arquivos:
- `File.ReadAllText(path)`
- `File.ReadAllLines(path)`
- `File.WriteAllText(path)`
- `File.Exists(path)`

### `FileInfo`
Representa um arquivo como objeto e oferece **operações orientadas a instância**:
```csharp
FileInfo fi = new FileInfo("dados.txt");
fi.CopyTo("backup.txt");
fi.Delete();
```

### `IOException`
Exceção base para erros de I/O (input/output).  
Exemplo: acesso negado, arquivo inexistente, arquivo em uso.

```csharp
try {
    string[] linhas = File.ReadAllLines("arquivo.txt");
} catch (IOException e) {
    Console.WriteLine("Erro de acesso ao arquivo: " + e.Message);
}
```

---

## 🔹 FileStream e StreamReader

### `FileStream`
Permite leitura/escrita de **dados binários ou texto**, com maior controle de baixo nível.

```csharp
using (FileStream fs = new FileStream("arquivo.txt", FileMode.Open)) {
    // leitura ou escrita de bytes
}
```

### `StreamReader`
Classe para leitura de **texto** a partir de arquivos.

```csharp
using (StreamReader sr = new StreamReader("arquivo.txt")) {
    while (!sr.EndOfStream) {
        string linha = sr.ReadLine();
        Console.WriteLine(linha);
    }
}
```

---

## 🔹 Bloco `using`

Usado para garantir que recursos como arquivos e streams sejam **fechados corretamente**, mesmo que ocorra exceção.

```csharp
using (StreamReader sr = new StreamReader("entrada.txt")) {
    // leitura do arquivo
}
```

Evita a necessidade de `sr.Close()` manualmente. O mesmo vale para `StreamWriter`, `FileStream`, etc.

---

## 🔹 StreamWriter

Usado para gravar **texto** em arquivos.

```csharp
using (StreamWriter sw = new StreamWriter("saida.txt")) {
    sw.WriteLine("Texto gravado no arquivo.");
}
```

- Pode adicionar o parâmetro `true` para **escrita no final do arquivo** (append):
```csharp
new StreamWriter("saida.txt", true);
```

---

## 🔹 Directory e DirectoryInfo

### `Directory`
Classe estática para **operações com pastas**:
```csharp
string[] pastas = Directory.GetDirectories("C:\temp");
string[] arquivos = Directory.GetFiles("C:\temp");
Directory.CreateDirectory("C:\nova_pasta");
```

### `DirectoryInfo`
Versão orientada a objeto:
```csharp
DirectoryInfo di = new DirectoryInfo("C:\temp");
di.Create();
di.Delete();
```

---

## 🔹 Path

Classe auxiliar para operações com **caminhos de arquivos e diretórios**.

### Métodos úteis:
- `Path.Combine("pasta", "arquivo.txt")`: monta caminho completo
- `Path.GetDirectoryName(path)`: retorna o diretório
- `Path.GetExtension(path)`: retorna a extensão
- `Path.GetFileName(path)`: nome do arquivo
- `Path.GetTempPath()`: caminho da pasta temporária

---

## ✅ Conclusão

C# fornece classes poderosas para trabalhar com arquivos de forma:
- Simples (`File`, `StreamReader`, `StreamWriter`)
- Flexível (`FileStream`, `FileInfo`, `DirectoryInfo`)
- Segura (`using`, `try-catch`, `IOException`)

Com essas ferramentas, é possível ler, gravar e manipular arquivos e diretórios de forma profissional.
