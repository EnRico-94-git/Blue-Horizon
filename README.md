# Blue-Horizon
Projeto criado para fins de estudo em um desfaio(Global Solution) da faculdade FIAP, feito com linguagem de C# para a matéria de .NET

Este projeto é um sistema de gerenciamento de pesca sustentável desenvolvido em ASP.NET Core MVC. 
O objetivo é ajudar a melhorar e preservar o meio ambiente marinho por meio de práticas de pesca sustentável.

### Funcionalidades
- Gerenciamento de animais marinhos
- Cadastro de clientes (marinheiros/usuários)
- Registro de atividades de pesca
- Integração com sistema de IA para análise de dados
- Relatórios de pesca e conservação de espécies

### Estrutura do Projeto
- Controllers: Contêm a lógica de negócios e manipulam as requisições HTTP.
- Models: Representam as entidades do banco de dados.
- Views: Contêm a interface do usuário.
- Repositories: Implementam o padrão de repositório para acesso aos dados.
- Middleware: Inclui o tratamento de exceções.

### Tecnologias Utilizadas
- ASP.NET Core MVC
- Entity Framework Core
- Oracle Database
- Bootstrap (para a interface do usuário)

### Pré-requisitos
- .NET 6.0 SDK ou superior
- Oracle Database
- Visual Studio 2022 ou superior

### Uso
Após iniciar o projeto, você pode acessar o sistema através do navegador em https://localhost:5001 (ou http://localhost:5000 para HTTP).

### Exemplos de Uso
- Animais
Listar Animais: Acesse /Animal/Index para visualizar a lista de animais.
Adicionar Animal: Acesse /Animal/Create para adicionar um novo animal.
Editar Animal: Acesse /Animal/Edit/{id} para editar um animal existente.
Deletar Animal: Acesse /Animal/Delete/{id} para deletar um animal.

- Clientes
Listar Clientes: Acesse /Cliente/Index para visualizar a lista de clientes.
Adicionar Cliente: Acesse /Cliente/Create para adicionar um novo cliente.
Editar Cliente: Acesse /Cliente/Edit/{id} para editar um cliente existente.
Deletar Cliente: Acesse /Cliente/Delete/{id} para deletar um cliente.

- Registros
Listar Registros: Acesse /Registro/Index para visualizar a lista de registros.
Adicionar Registro: Acesse /Registro/Create para adicionar um novo registro.
Editar Registro: Acesse /Registro/Edit/{id} para editar um registro existente.
Deletar Registro: Acesse /Registro/Delete/{id} para deletar um registro.

### Tratamento de Exceções
- Este projeto inclui um middleware personalizado para tratamento de exceções. Todas as exceções não tratadas serão registradas no arquivo logs/exceptions.log.
