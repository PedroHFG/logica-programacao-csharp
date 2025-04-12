
# 🧠 Desafios Avançados em C# - Integração de Conceitos

Estes desafios foram elaborados para consolidar os principais tópicos já estudados, simulando cenários reais de desenvolvimento. São indicados para reforçar o uso combinado de orientação a objetos, estrutura de dados, arquivos, tratamento de exceções e boas práticas de design.

---

## 🔹 Desafio 1: Sistema de Gerenciamento de Funcionários (CRUD com Arquivo)

Implemente um sistema para cadastrar, atualizar e remover funcionários.

### Requisitos:
- Classe `Funcionario` com `Id`, `Nome`, `Cargo`, `Salario` e `DataAdmissao`.
- Classe `Departamento` com composição (um funcionário pertence a um departamento).
- Armazene os dados dos funcionários em um arquivo `.csv`.
- Use `StreamReader/StreamWriter` para leitura e escrita.
- Trate exceções de leitura/escrita e formatação com `try-catch`.

### Funcionalidades:
- Adicionar funcionário
- Listar todos os funcionários
- Atualizar salário (por id)
- Excluir funcionário
- Listar por departamento

---

## 🔹 Desafio 2: Plataforma de Cursos Online

Modele uma aplicação que gerencia cursos, alunos e matrículas.

### Estrutura:
- `Aluno`: `Id`, `Nome`, `Email`
- `Curso`: `Id`, `Titulo`, `Nivel` (enum: Basico, Intermediario, Avancado)
- `Matricula`: representa a associação entre Aluno e Curso (composição)

### Requisitos:
- Use listas para armazenar alunos, cursos e matrículas
- Crie métodos para matrícula, cancelamento e listagem por aluno
- Adicione tratamento de exceções para entrada inválida
- Salve histórico de matrículas em arquivo
- Aplique encapsulamento e validação nas classes

---

## 🔹 Desafio 3: Sistema Bancário Simples com Herança

### Estrutura:
- Classe abstrata `Conta`: `Numero`, `Titular`, `Saldo`
- Subclasses:
  - `ContaCorrente`: saque com taxa
  - `ContaPoupanca`: saque sem taxa
- Enum `TipoConta`
- Método polimórfico `Sacar()`

### Requisitos:
- Permitir transferências entre contas (verifique saldo disponível)
- Persistência dos dados em arquivo
- Exibir extrato
- Utilizar `try-catch-finally` para erros operacionais

---

## 🔹 Desafio 4: Controle de Estoque com Arquivo e Polimorfismo

### Estrutura:
- `Produto` (classe base com `Nome`, `Preco`)
- Subclasses:
  - `ProdutoComum`
  - `ProdutoUsado` (com `DataFabricacao`)
  - `ProdutoImportado` (com `TaxaAlfandega`)

### Requisitos:
- Lista de produtos com polimorfismo
- Leitura e escrita de estoque em arquivo texto
- Cálculo de preço final com sobreposição de método
- Apresentação dos dados com `ToString()` sobrescrito
- Exceções para produtos com preço inválido

---

## 🔹 Desafio 5: Sistema de Reservas com Composição e Datas

### Estrutura:
- `Cliente`: `Nome`, `Email`
- `Reserva`: `Numero`, `CheckIn`, `CheckOut`, `Cliente`
- `Quarto`: `Numero`, `Tipo`, `PrecoPorNoite`

### Requisitos:
- Verificar disponibilidade de datas
- Calcular valor total da estadia com `TimeSpan`
- Salvar e recuperar reservas de arquivo
- Lançar exceções personalizadas se a data for inválida
- Uso de `DateTime`, `TimeSpan`, `Path`, `FileInfo`

---

## ✅ Observações

- Todos os desafios devem ser organizados com separação clara entre entidades, serviços, e interfaces (se houver).
- Use `enum`, `override`, `abstract`, `try-catch`, `List<T>`, `StreamWriter`, `StreamReader` conforme o caso.
- Estruture seu projeto com boas práticas: cada classe em seu próprio arquivo, nome adequado aos arquivos e pastas.

