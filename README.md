# Learning .NET API Project

Este é um projeto de estudo focado no fortalecimento das bases de desenvolvimento com .NET, ASP.NET Core e APIs REST. Ele foi criado com o objetivo de explorar conceitos fundamentais e boas práticas no ecossistema .NET.

## 🎯 Objetivos de Estudo

- Construção de APIs RESTful utilizando ASP.NET Core 8
- Implementação de controladores com métodos HTTP adequados
- Uso de C# 12 e suas novas funcionalidades
- Definição de tipos de resposta e códigos de status HTTP
- Manipulação de rotas e validação de dados em endpoints

## 🛠 Tecnologias Utilizadas

- .NET 8
- ASP.NET Core
- C# 12
- Princípios de APIs REST

## 📚 Funcionalidades Implementadas

O projeto inclui os seguintes endpoints no controlador `UserController`:

- **GET /api/user/{id}**: Retorna um usuário pelo ID.
- **POST /api/user**: Cria um novo usuário com base nos dados fornecidos.
- **PUT /api/user**: Atualiza os dados de um usuário existente.
- **DELETE /api/user**: Remove um usuário.
- **GET /api/user**: Retorna uma lista de todos os usuários.
- **PUT /api/user/change-password**: Permite a alteração de senha de um usuário.

## 📂 Estrutura do Projeto

- **Controllers**: Contém os controladores da API, como `UserController` e `DeviceController`.
- **Comunication**: Define os modelos de requisição e resposta, como `RequestRegisterUserJson` e `ResponseRegisteredUserJson`.

## 🚀 Próximos Passos

- Adicionar validações para os modelos de requisição.
- Implementar autenticação e autorização.
- Explorar integração com banco de dados para persistência de dados.

> Este projeto é voltado para aprendizado e prática. Sinta-se à vontade para contribuir ou sugerir melhorias!
