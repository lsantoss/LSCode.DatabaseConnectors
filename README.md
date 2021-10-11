# LSCode.ConexoesBD
 Oferece códigos para facilitar conexões com bancos de dados nos projetos da LSCode

<br>

<p>Pacote NuGet: LSCode.Facilitador.Api</p>
<p>Tipo do Projeto: .Net Standard 2.0</p>

<br>

<p><b>Exemplos de string de conexão</b></p>

<p>public static string SQLServerConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Votacao;Data Source=SANTOS-PC\SQLEXPRESS;";</p>

<p>public static string SQLServerConnectionString = @"Data Source=dataSource;Initial Catalog=inicialCatalog;User Id=usuario;Password=senha;";</p>

<p>public static string MySQLConnectionString = @"SERVER=localhost; DATABASE=votacao; UID=root; PASSWORD=root;";</p>

<p>public static string SQLiteConnectionString = @"Data Source = C:\BancosSQLite\Votacao.db; Version=3;";</p>

<p>public static string PostgreSQLConnectionString = @"Server=127.0.0.1; Port=5432;User Id = postgres; Password=root; Database=Votacao;";</p>

<p>public static string OracleConnectionString = @"User Id=SYSTEM;Password=root;Data Source=localhost:1521/xe;";</p>

<p>public static string MongoDBConnectionString = @"mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass%20Community&ssl=false";</p>
