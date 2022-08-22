using FirebirdSql.Data.FirebirdClient;
using LSCode.DatabaseConnectors.DataContexts;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;
using System;
using System.Data;
using System.IO;

namespace LSCode.DatabaseConnectors.Test.Integration.DataContexts
{
    internal class FirebirdContextTest
    {
        private readonly string _connectionStringKey = "ConnectionStringFirebird";
        private readonly string _connectionString = $@"Server=localhost; Database={AppDomain.CurrentDomain.BaseDirectory}\DatabaseName.FDB; User=SYSDBA; Password=masterkey;";

        public FirebirdContextTest()
        {
            if (!File.Exists($@"{AppDomain.CurrentDomain.BaseDirectory}\DatabaseName.FDB"))
                FbConnection.CreateDatabase(_connectionString);
        }

        [Test]
        public void Constructor_Valid()
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == _connectionStringKey)]).Returns(_connectionString);

            var dataContext = new FirebirdContext(configuration.Object);

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Open));
        }

        [Test]
        public void Dispose_Success()
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == _connectionStringKey)]).Returns(_connectionString);

            var dataContext = new FirebirdContext(configuration.Object);

            dataContext.Dispose();

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Closed));
        }
    }
}