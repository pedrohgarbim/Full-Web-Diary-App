# 🖥️ Projeto Web App com Entity Framework e ASP.NET Core

Este projeto é uma aplicação web completa que explora diversos aspectos do desenvolvimento com ASP.NET Core e Entity Framework. Temas abordados como a conexão com o banco de dados, manipulação de dados, operações CRUD, e a configuração de uma aplicação web seguindo a arquitetura MVC.

## 📚 Tópicos Abordados

### Construindo uma Aplicação Web Completa com Entity Framework (Conexão com o Banco de Dados)
- **🗂️ Model - Tabela e ID**: Criação do modelo `DiaryEntry` com propriedades e definição do ID como chave primária.
- **📝 Anotações e Evitando Null**: Aplicação de anotações para validações de dados, como campos obrigatórios e validações de comprimento.
- **🛠️ SQL Server e SQL Server Management Studio**: Configuração do SQL Server e do ambiente de gerenciamento para armazenar dados.
- **🔗 ConnectionString**: Configurando a string de conexão para ligar a aplicação ao banco de dados SQL Server.
- **📦 Entity Framework**: Integração do Entity Framework à aplicação para facilitar o acesso e manipulação de dados.
- **🔄 DbContext e EF**: Configurando o `ApplicationDbContext` para conectar o Entity Framework ao SQL Server e manipular os dados.
- **📦 Migrações**: Criando o banco de dados e tabelas utilizando migrações para definir a estrutura inicial do banco.
- **🕹️ Controllers**: Criação e configuração dos controladores para gerenciar as requisições HTTP e a lógica de negócios.
- **🛠️ CRUD Operations**: Implementação de operações de CRUD (Create, Read, Update, Delete) para gerenciar as entradas de diário.
- **🌱 Seed Data**: Como popular o banco de dados com dados iniciais usando o método `OnModelCreating`.
- **✅ Validação**: Implementando validação no lado do cliente e do servidor para garantir a integridade dos dados.
- **🛣️ Roteamento**: Configurando rotas e endpoints para as operações, incluindo a passagem de parâmetros através de URLs.

## 🏗️ Estrutura do Projeto
O projeto segue uma estrutura MVC (Model-View-Controller) para organizar o código, com as seguintes pastas principais:

- **📁 Models**: Contém as classes que representam os dados da aplicação.
  - `DiaryEntry.cs`: Define o modelo de entrada do diário com propriedades como `Id`, `Title`, `Content`, e `Created`.
- **👁️ Views**: Inclui as interfaces de usuário e templates.
  - `Create.cshtml`: Formulário para criar uma nova entrada.
  - `Edit.cshtml`: Formulário para editar uma entrada existente.
  - `Index.cshtml`: Lista todas as entradas do diário.
  - `Delete.cshtml`: Confirmação para deletar uma entrada.
- **🕹️ Controllers**: Define a lógica de aplicação e manipulação dos dados.
  - `DiaryEntriesController.cs`: Controlador principal que gerencia as operações CRUD para as entradas do diário.
- **📁 Data**: Inclui a configuração do contexto do banco de dados.
  - `ApplicationDbContext.cs`: Configura o Entity Framework e define o DbSet para `DiaryEntries`.

## 🎯 Funcionalidades

1. **🔌 Conexão com Banco de Dados**: Conecte-se a um banco de dados SQL Server e configure a aplicação para interagir com ele.
2. **🛠️ CRUD Completo**: Implemente operações de criação, leitura, atualização e exclusão de registros, permitindo a interação com o banco de dados.
3. **✅ Validação de Dados**: Aplique validações no lado do cliente e do servidor para garantir a integridade dos dados, como a exigência de um título para a entrada.
4. **🛣️ Rotas e Navegação**: Configure rotas e navegue pela aplicação de forma intuitiva, utilizando URLs parametrizadas para operações de edição e deleção.

## 📂 Estrutura de Pastas e Arquivos

### 📁 Controllers
- **DiaryEntriesController.cs**: Gerencia as ações de CRUD para as entradas do diário.
  - `Index()`: Recupera e exibe todas as entradas.
  - `Create()`: Exibe o formulário para criar uma nova entrada.
  - `Edit(int? id)`: Exibe o formulário para editar uma entrada existente.
  - `Delete(int? id)`: Exibe a confirmação para deletar uma entrada.

### 📁 Data
- **ApplicationDbContext.cs**: Contexto do banco de dados usando Entity Framework.
  - `DbSet<DiaryEntry>`: Representa a tabela `DiaryEntries`.
  - `OnModelCreating`: Utilizado para preencher a tabela com dados iniciais (seeding).

### 📁 Models
- **DiaryEntry.cs**: Modelo que define a estrutura de uma entrada do diário com propriedades e anotações de validação.

### 📁 Views
- **DiaryEntries**: Contém as views para interações do usuário, como criação, edição, listagem e deleção de entradas.

### 📁 Shared
- **_Layout.cshtml**: Layout padrão da aplicação.
- **_ValidationScriptsPartial.cshtml**: Scripts de validação do lado do cliente.

## 🛠️ Tecnologias Utilizadas
- **🌐 ASP.NET Core**: Framework principal para o desenvolvimento da aplicação.
- **📦 Entity Framework Core**: Ferramenta de ORM para interagir com o banco de dados.
- **💾 SQL Server**: Sistema de gerenciamento de banco de dados utilizado.
- **💻 C#**: Linguagem de programação principal do projeto.

### 3. **📝 Explicação do Código**

#### **🕹️ DiaryEntriesController.cs**

Este controlador lida com as ações CRUD para `DiaryEntry`.

- `Index()`: 📋 Recupera todas as entradas do banco de dados e as envia para a view `Index`.
- `Create()`: 🆕 Exibe o formulário para criar uma nova entrada.
- `Create(DiaryEntry obj)`: 📨 Método `POST` que adiciona uma nova entrada ao banco de dados se o modelo for válido.
- `Edit(int? id)`: ✏️ Recupera uma entrada pelo `id` para edição.
- `Edit(DiaryEntry obj)`: 🔄 Método `POST` que atualiza a entrada no banco de dados.
- `Delete(int? id)`: 🗑️ Recupera uma entrada pelo `id` para confirmação de deleção.
- `Delete(DiaryEntry obj)`: ❌ Método `POST` que remove a entrada do banco de dados.

#### **💾 ApplicationDbContext.cs**

- `ApplicationDbContext`: 🗄️ Herda de `DbContext` e configura o banco de dados.
- `DbSet<DiaryEntry>`: 📂 Representa a tabela `DiaryEntries`.
- `OnModelCreating`: 🌱 Utilizado para preencher inicialmente a tabela com alguns dados (seeding).

#### **🗂️ DiaryEntry.cs**

Este modelo define a estrutura da entrada do diário com anotações de validação.

- `Title`: 📋 Deve ter entre 3 e 100 caracteres.
- `Content`: 📝 Campo obrigatório que armazena o conteúdo da entrada.
- `Created`: 🕒 Define a data de criação como a data e hora atuais por padrão.

#### **🛠️ Program.cs**

- **Configuração do Entity Framework e SQL Server**: 🔗 Configura a conexão com o banco de dados utilizando o Entity Framework.
- **Adiciona serviços ao contêiner**: ⚙️ Incluindo `AddDbContext` para o `ApplicationDbContext`.
- **Configurações de roteamento**: 🛣️ Configura as rotas e o pipeline de requisição HTTP para direcionar as requisições corretamente.

### 4. **👁️ Páginas da Aplicação**

#### **Index.cshtml**

- 📋 Exibe uma tabela com todas as entradas do diário.
- ✏️ Botões para editar e deletar cada entrada.
- 🆕 Botão para criar uma nova entrada.

#### **Create.cshtml**

- 🆕 Formulário para adicionar uma nova entrada.
- 📋 Campos para título, conteúdo e data.

#### **Edit.cshtml**

- ✏️ Formulário para editar uma entrada existente.
- 📋 Pré-preenche os campos com os dados da entrada selecionada.

#### **Delete.cshtml**

- ❌ Exibe os detalhes da entrada a ser deletada.
- 🗑️ Botão para confirmar a deleção.

## 🛠 Como Funciona

1. **Adicionar uma Entrada**: 🆕 O usuário preenche o formulário e submete a entrada. Se o título tiver menos de 3 caracteres, uma mensagem de erro é exibida.
2. **Editar uma Entrada**: ✏️ O usuário seleciona uma entrada para editar, altera os dados e submete o formulário.
3. **Deletar uma Entrada**: 🗑️ O usuário confirma a deleção de uma entrada específica.

## 📊 Banco de Dados

- As entradas são salvas na tabela `DiaryEntries` com as seguintes colunas:
  - `Id`: 🔑 Identificador único da entrada.
  - `Title`: 📋 Título da entrada.
  - `Content`: 📝 Conteúdo da entrada.
  - `Created`: 🕒 Data e hora de criação da entrada.
## **👁️ As Páginas da Aplicação**
## **🖥️ Tela inicial/My Diary**
![image](https://github.com/user-attachments/assets/e05aa8e1-a3ac-48eb-a0bd-feb5f13871db)
![image](https://github.com/user-attachments/assets/f5546bb2-692d-4846-bf8c-a15bb4b6fe6b)
## **🖥️ Criação de uma anotação/Create a new Diary Entry**
![image](https://github.com/user-attachments/assets/102c9132-d234-43ac-a152-1e9f9233bf9d)
![image](https://github.com/user-attachments/assets/0f96a9ca-019a-4d88-952e-2a174fb1fb88)
![image](https://github.com/user-attachments/assets/c3ddbd03-53c5-4595-ad09-2a595e74fabf)

 **❌Mensagens de erro❌**
## **🖥️ Edição de uma anotação/Edit The Diary Entry**
![image](https://github.com/user-attachments/assets/e85fc5c5-a8ae-473d-ade0-03adbbebcf28)
![image](https://github.com/user-attachments/assets/857bfc1c-0f96-4bb3-9047-8f6aaf2a0627)
## **🖥️ Excluir uma anotação/Delete The Diary Entry**
![image](https://github.com/user-attachments/assets/b138d336-b43d-41c7-9bad-9097ea62d352)
![image](https://github.com/user-attachments/assets/f181742b-f86d-4370-928f-96292fefb955)

##  **💾 SQL Server**

![image](https://github.com/user-attachments/assets/f1d518fa-c170-472f-bdf7-16e222e305b9)






