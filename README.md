# LSCode.ConexoesBD
 Oferece códigos para facilitar conexões com bancos de dados nos projetos da LSCode

<br>

<p>Pacote NuGet: LSCode.Facilitador.Api</p>
<p>Tipo do Projeto: .Net Standard 2.0</p>

<hr>

<h2>Conexões disponíveis</h2>
<dl>
  <dt>Bancos Realacionais</dt>
  <dd>SQL Server</dd>
  <dd>MySQL</dd>
  <dd>SQLite</dd>
  <dd>PostgreSQL</dd>
  <dd>Oracle</dd>
  <dd>Firebird</dd>
  <dt>Bancos Não Realacionais</dt>
  <dd>MongoDB</dd>
  <dd>Redis</dd>
</dl>

<hr>

<h2>Exemplos de string de conexão</h2>

<p>public static string SQLServerConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Votacao;Data Source=SANTOS-PC\SQLEXPRESS;";</p>

<p>public static string SQLServerConnectionString = @"Data Source=dataSource;Initial Catalog=Votacao;User Id=usuario;Password=senha;";</p>

<p>public static string MySQLConnectionString = @"SERVER=localhost; DATABASE=votacao; UID=root; PASSWORD=root;";</p>

<p>public static string SQLiteConnectionString = @"Data Source = C:\BancosSQLite\Votacao.db; Version=3;";</p>

<p>public static string PostgreSQLConnectionString = @"Server=127.0.0.1; Port=5432;User Id = postgres; Password=root; Database=Votacao;";</p>

<p>public static string OracleConnectionString = @"User Id=SYSTEM;Password=root;Data Source=localhost:1521/xe;";</p>

<p>public static string FirebirdConnectionString = @"Server=localhost; Database=C:\Votacao.FDB; User=SYSDBA; Password=masterkey;";</p>

<p>public static string MongoDBConnectionString = @"mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass%20Community&ssl=false";</p>

<p>public static string RedisConnectionString = @"localhost";</p>
