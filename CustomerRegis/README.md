# CRUD de Clientes em ASP.NET Core

Projeto de um sistema de cadastro de clientes que desenvolvi para aprender a usar **ASP.NET Core 8** com **MVC**.

Ele faz o b�sico de um CRUD (**Criar, Ler, Atualizar e Deletar**) e conecta com um banco de dados **MySQL**.

---

## Funcionalidades

- **Cadastrar Cliente:** Formul�rio para adicionar clientes novos.
- **Pagina��o:** Lista dividida em p�ginas se houver muitos clientes, para n�o travar.
- **Ver Detalhes:** Tela para visualizar os dados de um cliente.
- **Editar:** Alterar informa��es de clientes j� cadastrados.
- **Deletar:** Apagar clientes (com confirma��o para evitar erros).

---

## Tecnologias Utilizadas

- **Backend:** C# com .NET 8 (ASP.NET Core MVC)  
- **Frontend:** HTML com Razor (mistura de C# e HTML) e Bootstrap para estilo  
- **Banco de Dados:** MySQL  
- **Conex�o com o Banco:** Entity Framework Core 8  
- **Pacote de Pagina��o:** X.PagedList.Mvc.Core  

---

## Como rodar o projeto na sua m�quina

Para fazer o projeto funcionar, voc� vai precisar de:

1. **.NET 8 SDK:** Instalar o .NET 8  
2. **MySQL:** Servidor MySQL rodando (porta padr�o 3306)  
3. **Ferramenta para banco de dados:** Ex: MySQL Workbench ou outro que rode scripts SQL  
4. **Editor de c�digo:** Visual Studio 2022 ou rider (ou outra ide de sua preferencia) 

---

## Observa��es

Este projeto foi desenvolvido como aprendizado e pr�tica de **CRUD em ASP.NET Core com MySQL**. � simples, direto e funcional, ideal para quem quer estudar integra��o de banco com .NET.


### Passo 1: Baixar o c�digo

Clone o projeto com o Git:

```git clone https://github.com/vitorpaladim/CustomerRegister_CRUD.git
cd customerRegis
```

### Passo 2: Preparar o Banco de Dados

Crie o banco e a tabela rodando o script abaixo no seu programa de banco de dados:

```
-- Cria o banco de dados (se n�o existir)
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

### passo 3: Configurar a Conex�o
Abra o arquivo `customerRegis/appsettings.json` e configure sua **Connection String**:

```
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Port=3306;Database=CustomerRegis_CRUD;User=seuNome(padrao = root);Password=suaSenha;"
}

```


### passo 4:Baixar as depend�ncias

Na pasta do projeto, abra o terminal e rode o comando:
```
dotnet restore

```

### Passo 5: S� rodar o projeto e correr pro abra�o
