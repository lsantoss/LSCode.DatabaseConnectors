using FirebirdSql.Data.FirebirdClient;
using LSCode.DatabaseConnectors.Enums;
using MongoDB.Driver;
using MySql.Data.MySqlClient;
using Npgsql;
using Oracle.ManagedDataAccess.Client;
using StackExchange.Redis;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace LSCode.DatabaseConnectors.DataContexts
{
    /// <summary>Helps to connect to databases.</summary>
    /// <remarks> 
    ///     <para>It offers connections to the most popular relational and non-relational databases. currently supports:</para>
    ///     <para>SQLServer</para>
    ///     <para>MySQL</para>
    ///     <para>SQLite</para>
    ///     <para>PostgreSQL</para>
    ///     <para>Oracle</para>
    ///     <para>Firebird</para>
    ///     <para>MongoDB</para>
    ///     <para>Redis</para>
    /// </remarks>
    public class DataContext : IDisposable
    {
        /// <value>Used when connecting to SQLServer databases.</value>
        public SqlConnection SQLServerConnetion { get; private set; }

        /// <value>Used when connecting to MySQL databases.</value>
        public MySqlConnection MySQLConnetion { get; private set; }

        /// <value>Used when connecting to SQLite databases.</value>
        public SQLiteConnection SQLiteConnetion { get; private set; }

        /// <value>Used when connecting to PostgreSQL databases.</value>
        public NpgsqlConnection PostgreSQLConnetion { get; private set; }

        /// <value>Used when connecting to Oracle databases.</value>
        public OracleConnection OracleConnetion { get; private set; }

        /// <value>Used when connecting to Firebird databases.</value>
        public FbConnection FirebirdConnetion { get; private set; }

        /// <value>Used when connecting to MongoDB databases.</value>
        public IMongoDatabase MongoDBConnetion { get; private set; }

        /// <value>Used when connecting to Redis databases.</value>
        public ConnectionMultiplexer RedisConnetion { get; private set; }

        /// <summary>DataContext class constructor.</summary>
        /// <param name="databaseRelational">Relational database used for connection.</param>
        /// <param name="connectionString">Connection string used for connection.</param>
        /// <returns>Create an instance of the DataContext class.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public DataContext(EDatabaseRelational databaseRelational, string connectionString)
        {
            try
            {
                switch (databaseRelational)
                {
                    case EDatabaseRelational.SQLServer:
                        SQLServerConnetion = new SqlConnection(connectionString);
                        SQLServerConnetion.Open();
                        break;

                    case EDatabaseRelational.MySQL:
                        MySQLConnetion = new MySqlConnection(connectionString);
                        MySQLConnetion.Open();
                        break;

                    case EDatabaseRelational.SQLite:
                        SQLiteConnetion = new SQLiteConnection(connectionString);
                        SQLiteConnetion.Open();
                        break;

                    case EDatabaseRelational.PostgreSQL:
                        PostgreSQLConnetion = new NpgsqlConnection(connectionString);
                        PostgreSQLConnetion.Open();
                        break;

                    case EDatabaseRelational.Oracle:
                        OracleConnetion = new OracleConnection(connectionString);
                        OracleConnetion.Open();
                        break;

                    case EDatabaseRelational.Firebird:
                        FirebirdConnetion = new FbConnection(connectionString);
                        FirebirdConnetion.Open();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>Construtor da classe DataContext.</summary>
        /// <param name="databaseNonRelational">Banco de dados não relacional utilizado para a conexão.</param>
        /// <param name="connectionString">String de conexão utilizada para a conexão.</param>
        /// <param name="databaseName">Nome da base de dados que será acessada.</param>
        /// <returns>Cria uma instância da classe DataContext.</returns>
        /// <exception cref="Exception">Error connecting to the chosen database</exception>
        public DataContext(EDatabaseNonRelational databaseNonRelational, string connectionString, string databaseName = null)
        {
            try
            {
                switch (databaseNonRelational)
                {
                    case EDatabaseNonRelational.MongoDB:
                        var client = new MongoClient(connectionString);
                        MongoDBConnetion = client.GetDatabase(databaseName);
                        break;

                    case EDatabaseNonRelational.Redis:
                        RedisConnetion = new Lazy<ConnectionMultiplexer>(() => {
                            return ConnectionMultiplexer.Connect(connectionString);
                        }).Value;
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>Closes connections used by the DataContext class.</summary>
        /// <exception cref="Exception">Error closing used connections</exception>
        public void Dispose()
        {
            try
            {
                if (SQLServerConnetion.State != ConnectionState.Closed)
                    SQLServerConnetion.Close();

                if (MySQLConnetion.State != ConnectionState.Closed)
                    MySQLConnetion.Close();

                if (SQLiteConnetion.State != ConnectionState.Closed)
                    SQLiteConnetion.Close();

                if (PostgreSQLConnetion.State != ConnectionState.Closed)
                    PostgreSQLConnetion.Close();

                if (OracleConnetion.State != ConnectionState.Closed)
                    OracleConnetion.Close();

                if (FirebirdConnetion.State != ConnectionState.Closed)
                    FirebirdConnetion.Close();

                if (MongoDBConnetion != null)
                    MongoDBConnetion = null;

                if (RedisConnetion.IsConnected)
                    RedisConnetion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}