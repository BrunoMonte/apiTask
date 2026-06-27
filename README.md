#  Task Manager API

API REST desenvolvida para gerenciamento de tarefas diárias, permitindo criar, listar, atualizar e excluir tarefas de forma simples e eficiente.

---

## 🚧 Refatoração em andamento

> **Atenção:** este projeto está passando por uma refatoração de arquitetura com fins de estudo e evolução das boas práticas de desenvolvimento em .NET.

Atualmente estou migrando de uma estrutura CRUD tradicional para uma arquitetura mais organizada, aplicando conceitos como:

- Clean Architecture (conceitos)
- Use Cases
- Repository Pattern
- Dependency Injection
- SOLID
- Separação de responsabilidades

Durante esse processo, algumas funcionalidades podem estar temporariamente em adaptação até que todas as rotas sejam migradas para a nova arquitetura.

O objetivo desta refatoração é tornar o projeto mais escalável, organizado e alinhado às práticas utilizadas em projetos profissionais.

##  Tecnologias utilizadas

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger (OpenAPI)

---

##  Funcionalidades

-  Criar tarefas
-  Listar tarefas
-  Atualizar tarefas
-  Excluir tarefas

---

##  Pré-requisitos

Antes de começar, você precisa ter instalado em sua máquina:

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- SQL Server (ou SQL Server Express)
- Git

---

##  Clonando o repositório

Via GitHub CLI:

```bash
gh repo clone BrunoMonte/apiTask

##  Executando o projeto

### 1. Acesse a pasta do projeto

```bash
cd apiTask

```bash
dotnet ef migrations add InitialCreate

```bash
dotnet ef database update

```bash
dotnet run

---

##  Acessando o Swagger

Após iniciar a aplicação, abra seu navegador e acesse:

```bash
http://localhost:5212/swagger/index.html

No Swagger você poderá testar todos os endpoints da API:

✅ GET
✅ POST
✅ PUT
✅ DELETE