# LSCode.DatabaseConnectors

## Application:
Offers codes to facilitate connections to databases in LSCode projects.

[![NuGet version (LSCode.DatabaseConnectors)](https://img.shields.io/nuget/v/LSCode.DatabaseConnectors.svg?style=flat-square)](https://www.nuget.org/packages/LSCode.DatabaseConnectors)

---

## How install:
- Click on the following link and see here some ways to install: [click here](https://www.nuget.org/packages/LSCode.DatabaseConnectors "LSCode.DatabaseConnectors page on nuget.org").

---

## How use:


---

## Frameworks:
- .Net Standard 2.1

---

## Currently supported:

- Relational databases
  - Firebird
  - MySQL
  - Oracle
  - PostgreSQL
  - SQLite
  - SQL Server

- Non-relational databases
  - MongoDB
  - Redis

---

## Dependencies:
- FirebirdSql.Data.FirebirdClient
- Microsoft.Extensions.Configuration.Abstractions
- Microsoft.Extensions.DependencyInjection.Abstractions
- MongoDB.Driver
- MySql.Data
- Npgsql
- Oracle.ManagedDataAccess.Core
- StackExchange.Redis
- System.Data.SqlClient
- System.Data.SQLite.Core

---

## Connection string examples:

| Database | Connection String |
|--|--|
| SQL Server | Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=database;Data Source=SANTOS-PC\SQLEXPRESS; |
| SQL Server | Data Source=dataSource;Initial Catalog=database;User Id=user;Password=password; |
| MySQL | SERVER=localhost; DATABASE=database; UID=root; PASSWORD=root; |
| SQLite | Data Source = C:\database.db; Version=3; |
| PostgreSQL | User Id=SYSTEM;Password=root;Data Source=localhost:1521/xe; |
| Oracle | User Id=userId;Password=password;Data Source=dataSource; |
| Firebird | Server=localhost; Database=C:\database.FDB; User=SYSDBA; Password=masterkey; |
| MongoDB | mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass%20Community&ssl=false |
| Redis | localhost |