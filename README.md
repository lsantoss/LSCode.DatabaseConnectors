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

## How to install:
- Click on the following link and see here some ways to install: [click here](https://www.nuget.org/packages/LSCode.DatabaseConnectors "LSCode.DatabaseConnectors page on nuget.org").

---

## How to use Firebird:
First install the package, for example:

```xml
<PackageReference Include="LSCode.DatabaseConnectors" Version="x.x.x" />
```

In the file where the services used in the application are added (`Startup.cs`, `Program.cs` or others), you must import the following namespaces:

```c#
using LSCode.DatabaseConnectors.DataContexts.Enums;
using LSCode.DatabaseConnectors.DataContexts.Extensions;
```

Then add the following line to register the service:

```c#
services.AddDataContext(DatabaseManagementSystem.Firebird, "connectionString");

//or

builder.Services.AddDataContext(DatabaseManagementSystem.Firebird, "connectionString");
```

In the file that you want to use the database connection context, you must import the following namespace:

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
```

The `context` contains a property called `Connection`. As its name implies, this property contains the connection to the configured database.

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;

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

## How to use MongoDB:
First install the package, for example:

```xml
<PackageReference Include="LSCode.DatabaseConnectors" Version="x.x.x" />
```

In the file where the services used in the application are added (`Startup.cs`, `Program.cs` or others), you must import the following namespaces:

```c#
using LSCode.DatabaseConnectors.DataContexts.Enums;
using LSCode.DatabaseConnectors.DataContexts.Extensions;
```

Then add the following line to register the service:

```c#
services.AddDataContext(DatabaseManagementSystem.MongoDB, "connectionString", "databaseName");

//or

builder.Services.AddDataContext(DatabaseManagementSystem.MongoDB, "connectionString", "databaseName");
```

In the file that you want to use the database connection context, you must import the following namespace:

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
```

The `context` contains a property called `Connection`. As its name implies, this property contains the connection to the configured database.

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;

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

## How to use MySQL:
First install the package, for example:

```xml
<PackageReference Include="LSCode.DatabaseConnectors" Version="x.x.x" />
```

In the file where the services used in the application are added (`Startup.cs`, `Program.cs` or others), you must import the following namespaces:

```c#
using LSCode.DatabaseConnectors.DataContexts.Enums;
using LSCode.DatabaseConnectors.DataContexts.Extensions;
```

Then add the following line to register the service:

```c#
services.AddDataContext(DatabaseManagementSystem.MySQL, "connectionString");

//or

builder.Services.AddDataContext(DatabaseManagementSystem.MySQL, "connectionString");
```

In the file that you want to use the database connection context, you must import the following namespace:

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
```

The `context` contains a property called `Connection`. As its name implies, this property contains the connection to the configured database.

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;

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

## How to use Oracle:
First install the package, for example:

```xml
<PackageReference Include="LSCode.DatabaseConnectors" Version="x.x.x" />
```

In the file where the services used in the application are added (`Startup.cs`, `Program.cs` or others), you must import the following namespaces:

```c#
using LSCode.DatabaseConnectors.DataContexts.Enums;
using LSCode.DatabaseConnectors.DataContexts.Extensions;
```

Then add the following line to register the service:

```c#
services.AddDataContext(DatabaseManagementSystem.Oracle, "connectionString");

//or

builder.Services.AddDataContext(DatabaseManagementSystem.Oracle, "connectionString");
```

In the file that you want to use the database connection context, you must import the following namespace:

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
```

The `context` contains a property called `Connection`. As its name implies, this property contains the connection to the configured database.

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;

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

## How to use PostgreSQL:
First install the package, for example:

```xml
<PackageReference Include="LSCode.DatabaseConnectors" Version="x.x.x" />
```

In the file where the services used in the application are added (`Startup.cs`, `Program.cs` or others), you must import the following namespaces:

```c#
using LSCode.DatabaseConnectors.DataContexts.Enums;
using LSCode.DatabaseConnectors.DataContexts.Extensions;
```

Then add the following line to register the service:

```c#
services.AddDataContext(DatabaseManagementSystem.PostgreSQL, "connectionString");

//or

builder.Services.AddDataContext(DatabaseManagementSystem.PostgreSQL, "connectionString");
```

In the file that you want to use the database connection context, you must import the following namespace:

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
```

The `context` contains a property called `Connection`. As its name implies, this property contains the connection to the configured database.

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;

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

## How to use Redis:
First install the package, for example:

```xml
<PackageReference Include="LSCode.DatabaseConnectors" Version="x.x.x" />
```

In the file where the services used in the application are added (`Startup.cs`, `Program.cs` or others), you must import the following namespaces:

```c#
using LSCode.DatabaseConnectors.DataContexts.Enums;
using LSCode.DatabaseConnectors.DataContexts.Extensions;
```

Then add the following line to register the service:

```c#
services.AddDataContext(DatabaseManagementSystem.Redis, "connectionString");

//or

builder.Services.AddDataContext(DatabaseManagementSystem.Redis, "connectionString");
```

In the file that you want to use the database connection context, you must import the following namespace:

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
```

The `context` contains a property called `Connection`. As its name implies, this property contains the connection to the configured database.

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;

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

## How to use SQLite:
First install the package, for example:

```xml
<PackageReference Include="LSCode.DatabaseConnectors" Version="x.x.x" />
```

In the file where the services used in the application are added (`Startup.cs`, `Program.cs` or others), you must import the following namespaces:

```c#
using LSCode.DatabaseConnectors.DataContexts.Enums;
using LSCode.DatabaseConnectors.DataContexts.Extensions;
```

Then add the following line to register the service:

```c#
services.AddDataContext(DatabaseManagementSystem.SQLite, "connectionString");

//or

builder.Services.AddDataContext(DatabaseManagementSystem.SQLite, "connectionString");
```

In the file that you want to use the database connection context, you must import the following namespace:

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
```

The `context` contains a property called `Connection`. As its name implies, this property contains the connection to the configured database.

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;

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

## How to use SQLServer:
First install the package, for example:

```xml
<PackageReference Include="LSCode.DatabaseConnectors" Version="x.x.x" />
```

In the file where the services used in the application are added (`Startup.cs`, `Program.cs` or others), you must import the following namespaces:

```c#
using LSCode.DatabaseConnectors.DataContexts.Enums;
using LSCode.DatabaseConnectors.DataContexts.Extensions;
```

Then add the following line to register the service:

```c#
services.AddDataContext(DatabaseManagementSystem.SQLServer, "connectionString");

//or

builder.Services.AddDataContext(DatabaseManagementSystem.SQLServer, "connectionString");
```

In the file that you want to use the database connection context, you must import the following namespace:

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;
```

The `context` contains a property called `Connection`. As its name implies, this property contains the connection to the configured database.

```c#
using LSCode.DatabaseConnectors.DataContexts.Interfaces;

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