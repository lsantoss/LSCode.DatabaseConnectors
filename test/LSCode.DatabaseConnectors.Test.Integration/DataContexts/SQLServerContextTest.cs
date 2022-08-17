using Dapper;
using LSCode.DatabaseConnectors.DataContexts;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;
using System.Data;
using System.Data.SqlClient;

namespace LSCode.DatabaseConnectors.Test.Integration.DataContexts
{
    internal class SQLServerContextTest
    {
        private const string _connectionStringKey = "ConnectionStringSQLServer";
        private const string _connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LSCode.DatabaseConnectors.Test;Data Source=SANTOS-PC\\SQLEXPRESS;";

        public SQLServerContextTest()
        {
            var connectionStringMaster = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=SANTOS-PC\\SQLEXPRESS;";

            using var connection = new SqlConnection(connectionStringMaster);

            var query = @"USE [master]
                          IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'LSCode.DatabaseConnectors.Test')
                          CREATE DATABASE [LSCode.DatabaseConnectors.Test]";

            connection.Execute(query);
        }

        [Test]
        public void Constructor_Valid()
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == _connectionStringKey)]).Returns(_connectionString);

            var dataContext = new SQLServerContext(configuration.Object);

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Open));
        }

        [Test]
        public void Dispose_Success()
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == _connectionStringKey)]).Returns(_connectionString);

            var dataContext = new SQLServerContext(configuration.Object);

            dataContext.Dispose();

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Closed));
        }
    }
}