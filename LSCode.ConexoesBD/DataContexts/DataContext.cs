using FirebirdSql.Data.FirebirdClient;
using LSCode.ConexoesBD.Enums;
using MongoDB.Driver;
using MySql.Data.MySqlClient;
using Npgsql;
using Oracle.ManagedDataAccess.Client;
using StackExchange.Redis;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace LSCode.ConexoesBD.DataContexts
{
    /// <summary>Auxilia na conexão com bases de dados.</summary>
    /// <remarks> 
    ///     <para>Oferece conexões com as mais populares bases de dados relacionais e não relacionais. Atualmente suporta:</para>
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
        /// <value>Utilizada na conexão com bases de dados SQLServer.</value>
        public SqlConnection SQLServerConexao { get; private set; }

        /// <value>Utilizada na conexão com bases de dados MySQL.</value>
        public MySqlConnection MySQLConexao { get; private set; }

        /// <value>Utilizada na conexão com bases de dados SQLite.</value>
        public SQLiteConnection SQLiteConexao { get; private set; }

        /// <value>Utilizada na conexão com bases de dados PostgreSQL.</value>
        public NpgsqlConnection PostgreConexao { get; private set; }

        /// <value>Utilizada na conexão com bases de dados Oracle.</value>
        public OracleConnection OracleConexao { get; private set; }

        /// <value>Utilizada na conexão com bases de dados Firebird.</value>
        public FbConnection FirebirdConexao { get; private set; }

        /// <value>Utilizada na conexão com bases de dados MongoDB.</value>
        public IMongoDatabase MongoDBConexao { get; private set; }

        /// <value>Utilizada na conexão com bases de dados Redis.</value>
        public ConnectionMultiplexer RedisConexao { get; private set; }

        /// <summary>Construtor da classe DbContext.</summary>
        /// <param name="bancoDadosRelacional">Banco de dados relacional utilizado para a conexão.</param>
        /// <param name="stringConexao">String de conexão utilizada para a conexão. </param>
        /// <returns>Cria uma instância da classe DbContext.</returns>
        /// <exception cref="Exception">Erro ao conectar na base de dados escolhida</exception>
        public DataContext(EBancoDadosRelacional bancoDadosRelacional, string stringConexao)
        {
            try
            {
                if (bancoDadosRelacional == EBancoDadosRelacional.SQLServer)
                {
                    SQLServerConexao = new SqlConnection(stringConexao);
                    SQLServerConexao.Open();
                }
                else if (bancoDadosRelacional == EBancoDadosRelacional.MySQL)
                {
                    MySQLConexao = new MySqlConnection(stringConexao);
                    MySQLConexao.Open();
                }
                else if (bancoDadosRelacional == EBancoDadosRelacional.SQLite)
                {
                    SQLiteConexao = new SQLiteConnection(stringConexao);
                    SQLiteConexao.Open();
                }
                else if (bancoDadosRelacional == EBancoDadosRelacional.PostgreSQL)
                {
                    PostgreConexao = new NpgsqlConnection(stringConexao);
                    PostgreConexao.Open();
                }
                else if (bancoDadosRelacional == EBancoDadosRelacional.Oracle)
                {
                    OracleConexao = new OracleConnection(stringConexao);
                    OracleConexao.Open();
                }
                else if (bancoDadosRelacional == EBancoDadosRelacional.Firebird)
                {
                    FirebirdConexao = new FbConnection(stringConexao);
                    FirebirdConexao.Open();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>Construtor da classe DbContext.</summary>
        /// <param name="bancoDadosNaoRelacional">Banco de dados não relacional utilizado para a conexão.</param>
        /// <param name="stringConexao">String de conexão utilizada para a conexão.</param>
        /// <param name="nomeBaseDeDados">Nome da base de dados que será acessada.</param>
        /// <returns>Cria uma instância da classe DbContext.</returns>
        /// <exception cref="Exception">Erro ao conectar na base de dados escolhida</exception>
        public DataContext(EBancoDadosNaoRelacional bancoDadosNaoRelacional, string stringConexao, string nomeBaseDeDados)
        {
            try
            {
                if (bancoDadosNaoRelacional == EBancoDadosNaoRelacional.MongoDB)
                {
                    var client = new MongoClient(stringConexao);
                    MongoDBConexao = client.GetDatabase(nomeBaseDeDados);
                }
                else if (bancoDadosNaoRelacional == EBancoDadosNaoRelacional.Redis)
                {
                    RedisConexao = new Lazy<ConnectionMultiplexer>(() =>
                    {
                        return ConnectionMultiplexer.Connect(stringConexao);
                    }).Value;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        /// <summary>Fecha conexões utlizadas pela classe DbContext.</summary>
        /// <exception cref="Exception">Erro ao fechar as conexões utilizadas</exception>
        public void Dispose()
        {
            try
            {
                if (SQLServerConexao.State != ConnectionState.Closed)
                    SQLServerConexao.Close();

                if (MySQLConexao.State != ConnectionState.Closed)
                    MySQLConexao.Close();

                if (SQLiteConexao.State != ConnectionState.Closed)
                    SQLiteConexao.Close();

                if (PostgreConexao.State != ConnectionState.Closed)
                    PostgreConexao.Close();

                if (OracleConexao.State != ConnectionState.Closed)
                    OracleConexao.Close();

                if (FirebirdConexao.State != ConnectionState.Closed)
                    FirebirdConexao.Close();

                if (MongoDBConexao != null)
                    MongoDBConexao = null;

                if (RedisConexao.IsConnected)
                    RedisConexao.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}