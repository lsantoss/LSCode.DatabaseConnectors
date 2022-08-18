using Dapper;
using LSCode.DatabaseConnectors.DataContexts;
using Microsoft.Extensions.Configuration;
using Moq;
using MySql.Data.MySqlClient;
using NUnit.Framework;
using System.Data;

namespace LSCode.DatabaseConnectors.Test.Integration.DataContexts
{
    internal class MySQLContextTest
    {
        private readonly string _connectionStringKey = "ConnectionStringMySQL";
        private readonly string _connectionString = @"SERVER=localhost; DATABASE=LSCode.DatabaseConnectors.Test; UID=root; PASSWORD=root;";

        public MySQLContextTest()
        {
            var connectionStringMaster = @"SERVER=localhost; DATABASE=mysql; UID=root; PASSWORD=root;";

            using var connection = new MySqlConnection(connectionStringMaster);
            connection.Open();

            var query = @"CREATE DATABASE IF NOT EXISTS `LSCode.DatabaseConnectors.Test`;";

            connection.Execute(query);
            connection.Close();
        }

        [Test]
        public void Constructor_Valid()
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == _connectionStringKey)]).Returns(_connectionString);

            var dataContext = new MySQLContext(configuration.Object);

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Open));
        }

        [Test]
        public void Dispose_Success()
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == _connectionStringKey)]).Returns(_connectionString);

            var dataContext = new MySQLContext(configuration.Object);

            dataContext.Dispose();

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Closed));
        }
    }
}