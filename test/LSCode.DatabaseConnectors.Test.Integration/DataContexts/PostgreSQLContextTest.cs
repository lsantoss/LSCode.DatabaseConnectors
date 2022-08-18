using Dapper;
using LSCode.DatabaseConnectors.DataContexts;
using Microsoft.Extensions.Configuration;
using Moq;
using Npgsql;
using NUnit.Framework;
using System.Data;
using System.Linq;

namespace LSCode.DatabaseConnectors.Test.Integration.DataContexts
{
    internal class PostgreSQLContextTest
    {
        private readonly string _connectionStringKey = "ConnectionStringPostgreSQL";
        private readonly string _connectionString = @"Server=localhost;Port=5432;Database=LSCode.DatabaseConnectors.Test;User Id=postgres;Password=root;";

        public PostgreSQLContextTest()
        {
            var connectionStringMaster = @"Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=root;";

            using var connection = new NpgsqlConnection(connectionStringMaster);
            connection.Open();

            var databaseExistQuery = "SELECT datname FROM pg_database WHERE datname = 'LSCode.DatabaseConnectors.Test'";
            var databaseExist = connection.Query<string>(databaseExistQuery).Any();

            if (!databaseExist)
            {
                var query = "CREATE DATABASE \"LSCode.DatabaseConnectors.Test\" WITH OWNER = postgres ENCODING = 'UTF8' CONNECTION LIMIT = -1;";
                connection.Execute(query);
            }

            connection.Close();
        }

        [Test]
        public void Constructor_Valid()
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == _connectionStringKey)]).Returns(_connectionString);

            var dataContext = new PostgreSQLContext(configuration.Object);

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Open));
        }

        [Test]
        public void Dispose_Success()
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == _connectionStringKey)]).Returns(_connectionString);

            var dataContext = new PostgreSQLContext(configuration.Object);

            dataContext.Dispose();

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Closed));
        }
    }
}