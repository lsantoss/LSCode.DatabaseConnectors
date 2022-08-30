# LSCode.DatabaseConnectors

## Application:
Offers codes to facilitate connections to databases in LSCode projects.

[![NuGet version (LSCode.DatabaseConnectors)](https://img.shields.io/nuget/v/LSCode.DatabaseConnectors.svg?style=flat-square)](https://www.nuget.org/packages/LSCode.DatabaseConnectors)

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
- Microsoft.Extensions.DependencyInjection.Abstractions
- MongoDB.Driver
- MySql.Data
- Npgsql
- Oracle.ManagedDataAccess.Core
- StackExchange.Redis
- System.Data.SqlClient
- System.Data.SQLite.Core

---

## Dependencies (Test projects):
- Microsoft.NET.Test.Sdk
- NUnit
- NUnit3TestAdapter
- NUnit.Analyzers
- coverlet.collector

---

## How install:
- Click on the following link and see here some ways to install: [click here](https://www.nuget.org/packages/LSCode.DatabaseConnectors "LSCode.DatabaseConnectors page on nuget.org").

---

## How use Firebird:

First install the package, for example:

```xml
<PackageReference Include="LSCode.DatabaseConnectors" Version="x.x.x" />
```

Add the following line of code according to the .Net version:
- .Net 6 (without Startup.cs) - `Program.cs` file
- .Net 6 (with Startup.cs) ou less - `Startup.cs` file

```c#
using LSCode.DatabaseConnectors.Extensions;
```

After that, according to the .Net version configure the following file:
- .Net 6 (without Startup.cs) - `Program.cs` file
- .Net 6 (with Startup.cs) ou less - `Startup.cs` file, add the following line in the `ConfigureServices` method

```c#
//.Net 6 (without Startup.cs)
builder.Services.AddFirebirdContext("connectionString");

//.Net 6 (with Startup.cs) ou less
services.AddFirebirdContext("connectionString");
```

In the file that you want to use the database connection context, you must import the following namespace:

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
```

The `context` contains a property called `Connection`. As its name implies, this property contains the connection to the configured database.

```c#
namespace MyNamespace
{
  public class MyClass
  {
    private readonly IFirebirdContext _context;

    public MyClass(IFirebirdContext context) => _context = context;

    public Task Delete(long id) => ... _context.Connection ...;
  }
}
```

---

## How use MongoDB:

First install the package, for example:

```xml
<PackageReference Include="LSCode.DatabaseConnectors" Version="x.x.x" />
```

Add the following line of code according to the .Net version:
- .Net 6 (without Startup.cs) - `Program.cs` file
- .Net 6 (with Startup.cs) ou less - `Startup.cs` file

```c#
using LSCode.DatabaseConnectors.Extensions;
```

After that, according to the .Net version configure the following file:
- .Net 6 (without Startup.cs) - `Program.cs` file
- .Net 6 (with Startup.cs) ou less - `Startup.cs` file, add the following line in the `ConfigureServices` method

```c#
//.Net 6 (without Startup.cs)
builder.Services.AddMongoDBContext("connectionString", "databaseName");

//.Net 6 (with Startup.cs) ou less
services.AddMongoDBContext("connectionString", "databaseName");
```

In the file that you want to use the database connection context, you must import the following namespace:

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
```

The `context` contains a property called `Connection`. As its name implies, this property contains the connection to the configured database.

```c#
namespace MyNamespace
{
  public class MyClass
  {
    private readonly IMongoDBContext _context;

    public MyClass(IMongoDBContext context) => _context = context;

    public Task Delete(long id) => ... _context.Connection ...;
  }
}
```

---

## How use MySQL:

First install the package, for example:

```xml
<PackageReference Include="LSCode.DatabaseConnectors" Version="x.x.x" />
```

Add the following line of code according to the .Net version:
- .Net 6 (without Startup.cs) - `Program.cs` file
- .Net 6 (with Startup.cs) ou less - `Startup.cs` file

```c#
using LSCode.DatabaseConnectors.Extensions;
```

After that, according to the .Net version configure the following file:
- .Net 6 (without Startup.cs) - `Program.cs` file
- .Net 6 (with Startup.cs) ou less - `Startup.cs` file, add the following line in the `ConfigureServices` method

```c#
//.Net 6 (without Startup.cs)
builder.Services.AddMySQLContext("connectionString");

//.Net 6 (with Startup.cs) ou less
services.AddMySQLContext("connectionString");
```

In the file that you want to use the database connection context, you must import the following namespace:

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
```

The `context` contains a property called `Connection`. As its name implies, this property contains the connection to the configured database.

```c#
namespace MyNamespace
{
  public class MyClass
  {
    private readonly IMySQLContext _context;

    public MyClass(IMySQLContext context) => _context = context;

    public Task Delete(long id) => ... _context.Connection ...;
  }
}
```

---

## How use Oracle:

First install the package, for example:

```xml
<PackageReference Include="LSCode.DatabaseConnectors" Version="x.x.x" />
```

Add the following line of code according to the .Net version:
- .Net 6 (without Startup.cs) - `Program.cs` file
- .Net 6 (with Startup.cs) ou less - `Startup.cs` file

```c#
using LSCode.DatabaseConnectors.Extensions;
```

After that, according to the .Net version configure the following file:
- .Net 6 (without Startup.cs) - `Program.cs` file
- .Net 6 (with Startup.cs) ou less - `Startup.cs` file, add the following line in the `ConfigureServices` method

```c#
//.Net 6 (without Startup.cs)
builder.Services.AddOracleContext("connectionString");

//.Net 6 (with Startup.cs) ou less
services.AddOracleContext("connectionString");
```

In the file that you want to use the database connection context, you must import the following namespace:

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
```

The `context` contains a property called `Connection`. As its name implies, this property contains the connection to the configured database.

```c#
namespace MyNamespace
{
  public class MyClass
  {
    private readonly IOracleContext _context;

    public MyClass(IOracleContext context) => _context = context;

    public Task Delete(long id) => ... _context.Connection ...;
  }
}
```

---

## How use PostgreSQL:

First install the package, for example:

```xml
<PackageReference Include="LSCode.DatabaseConnectors" Version="x.x.x" />
```

Add the following line of code according to the .Net version:
- .Net 6 (without Startup.cs) - `Program.cs` file
- .Net 6 (with Startup.cs) ou less - `Startup.cs` file

```c#
using LSCode.DatabaseConnectors.Extensions;
```

After that, according to the .Net version configure the following file:
- .Net 6 (without Startup.cs) - `Program.cs` file
- .Net 6 (with Startup.cs) ou less - `Startup.cs` file, add the following line in the `ConfigureServices` method

```c#
//.Net 6 (without Startup.cs)
builder.Services.AddPostgreSQLContext("connectionString");

//.Net 6 (with Startup.cs) ou less
services.AddPostgreSQLContext("connectionString");
```

In the file that you want to use the database connection context, you must import the following namespace:

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
```

The `context` contains a property called `Connection`. As its name implies, this property contains the connection to the configured database.

```c#
namespace MyNamespace
{
  public class MyClass
  {
    private readonly IPostgreSQLContext _context;

    public MyClass(IPostgreSQLContext context) => _context = context;

    public Task Delete(long id) => ... _context.Connection ...;
  }
}
```

---

## How use Redis:

First install the package, for example:

```xml
<PackageReference Include="LSCode.DatabaseConnectors" Version="x.x.x" />
```

Add the following line of code according to the .Net version:
- .Net 6 (without Startup.cs) - `Program.cs` file
- .Net 6 (with Startup.cs) ou less - `Startup.cs` file

```c#
using LSCode.DatabaseConnectors.Extensions;
```

After that, according to the .Net version configure the following file:
- .Net 6 (without Startup.cs) - `Program.cs` file
- .Net 6 (with Startup.cs) ou less - `Startup.cs` file, add the following line in the `ConfigureServices` method

```c#
//.Net 6 (without Startup.cs)
builder.Services.AddRedisContext("connectionString");

//.Net 6 (with Startup.cs) ou less
servRedisices.AddRedisContext("connectionString");
```

In the file that you want to use the database connection context, you must import the following namespace:

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
```

The `context` contains a property called `Connection`. As its name implies, this property contains the connection to the configured database.

```c#
namespace MyNamespace
{
  public class MyClass
  {
    private readonly IRedisContext _context;

    public MyClass(IRedisContext context) => _context = context;

    public Task Delete(long id) => ... _context.Connection ...;
  }
}
```

---

## How use SQLite:

First install the package, for example:

```xml
<PackageReference Include="LSCode.DatabaseConnectors" Version="x.x.x" />
```

Add the following line of code according to the .Net version:
- .Net 6 (without Startup.cs) - `Program.cs` file
- .Net 6 (with Startup.cs) ou less - `Startup.cs` file

```c#
using LSCode.DatabaseConnectors.Extensions;
```

After that, according to the .Net version configure the following file:
- .Net 6 (without Startup.cs) - `Program.cs` file
- .Net 6 (with Startup.cs) ou less - `Startup.cs` file, add the following line in the `ConfigureServices` method

```c#
//.Net 6 (without Startup.cs)
builder.Services.AddSQLiteContext("connectionString");

//.Net 6 (with Startup.cs) ou less
servRedisices.AddSQLiteContext("connectionString");
```

In the file that you want to use the database connection context, you must import the following namespace:

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
```

The `context` contains a property called `Connection`. As its name implies, this property contains the connection to the configured database.

```c#
namespace MyNamespace
{
  public class MyClass
  {
    private readonly ISQLiteContext _context;

    public MyClass(ISQLiteContext context) => _context = context;

    public Task Delete(long id) => ... _context.Connection ...;
  }
}
```

---

## How use SQLServer:

First install the package, for example:

```xml
<PackageReference Include="LSCode.DatabaseConnectors" Version="x.x.x" />
```

Add the following line of code according to the .Net version:
- .Net 6 (without Startup.cs) - `Program.cs` file
- .Net 6 (with Startup.cs) ou less - `Startup.cs` file

```c#
using LSCode.DatabaseConnectors.Extensions;
```

After that, according to the .Net version configure the following file:
- .Net 6 (without Startup.cs) - `Program.cs` file
- .Net 6 (with Startup.cs) ou less - `Startup.cs` file, add the following line in the `ConfigureServices` method

```c#
//.Net 6 (without Startup.cs)
builder.Services.AddSQLServerContext("connectionString");

//.Net 6 (with Startup.cs) ou less
servRedisices.AddSQLServerContext("connectionString");
```

In the file that you want to use the database connection context, you must import the following namespace:

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
```

The `context` contains a property called `Connection`. As its name implies, this property contains the connection to the configured database.

```c#
namespace MyNamespace
{
  public class MyClass
  {
    private readonly ISQLServerContext _context;

    public MyClass(ISQLServerContext context) => _context = context;

    public Task Delete(long id) => ... _context.Connection ...;
  }
}
```

---

## Connection string examples:

| Database | Connection String |
| -- | -- |
| Firebird | Server=localhost; Database=C:\database.FDB; User=SYSDBA; Password=masterkey; |
| MongoDB | mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass%20Community&ssl=false |
| MySQL | SERVER=localhost; DATABASE=mysql; UID=root; PASSWORD=root; |
| Oracle | User ID=SYSTEM;Password=root;Data Source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = xe)));Pooling=true;Connection Lifetime=300;Max Pool Size=20; |
| PostgreSQL | Server=localhost;Port=5432;Database=LSCode.DatabaseConnectors.Test;User Id=postgres;Password=root; |
| Redis | localhost |
| SQLite | Data Source=C:\database.sqlite;Version=3; |
| SQL Server | Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=PC\SQLEXPRESS; |