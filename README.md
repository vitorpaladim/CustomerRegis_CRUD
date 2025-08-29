# CRUD de Clientes em ASP.NET Core

Projeto de um sistema de cadastro de clientes que desenvolvi para aprender a usar **ASP.NET Core 8** com **MVC**.

Ele faz o básico de um CRUD (**Criar, Ler, Atualizar e Deletar**) e conecta com um banco de dados **MySQL**.

---

## Funcionalidades

- **Cadastrar Cliente:** Formulário para adicionar clientes novos.

- **Paginação:** Lista dividida em páginas se houver muitos clientes, para não travar.
- **Ver Detalhes:** Tela para visualizar os dados de um cliente.
- **Editar:** Alterar informações de clientes já cadastrados.
- **Deletar:** Apagar clientes (com confirmação para evitar erros).

---

## Tecnologias Utilizadas

- **Backend:** C# com .NET 8 (ASP.NET Core MVC)  
- **Frontend:** HTML com Razor (mistura de C# e HTML) e Bootstrap para estilo  
- **Banco de Dados:** MySQL  
- **Conexão com o Banco:** Entity Framework Core 8  
- **Pacote de Paginação:** X.PagedList.Mvc.Core  

---

## Como rodar o projeto na sua máquina

Para fazer o projeto funcionar, você vai precisar de:

1. **.NET 8 SDK:** Instalar o .NET 8  
2. **MySQL:** Servidor MySQL rodando (porta padrão 3306)  
3. **Ferramenta para banco de dados:** Ex: MySQL Workbench ou outro que rode scripts SQL  
4. **Editor de código:** Visual Studio 2022 ou rider (ou outra ide de sua preferencia) 

---

## Observações

Este projeto foi desenvolvido como aprendizado e prática de **CRUD em ASP.NET Core com MySQL**. É simples, direto e funcional, ideal para quem quer estudar integração de banco com .NET.


### Passo 1: Baixar o código

Clone o projeto com o Git:

```git clone https://github.com/vitorpaladim/CustomerRegister_CRUD.git
cd customerRegis
```

### Passo 2: Preparar o Banco de Dados

Crie o banco e a tabela rodando o script abaixo no seu programa de banco de dados:

```
-- Cria o banco de dados (se não existir)
CREATE DATABASE IF NOT EXISTS CustomerRegis_CRUD;

-- Seleciona o banco
USE CustomerRegis_CRUD;

-- Cria a tabela de clientes
CREATE TABLE IF NOT EXISTS Customer (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(255) NOT NULL,
    Email VARCHAR(255),
    PhoneNumber VARCHAR(20),
    Address VARCHAR(255)
);
```

### passo 3: Configurar a Conexão
Abra o arquivo `customerRegis/appsettings.json` e configure sua **Connection String**:

```
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Port=3306;Database=CustomerRegis_CRUD;User=seuNome(padrao = root);Password=suaSenha;"
}

```


### passo 4:Baixar as dependências

Na pasta do projeto, abra o terminal e rode o comando:
```
dotnet restore

```

### Passo 5: Só rodar o projeto e correr pro abraço
