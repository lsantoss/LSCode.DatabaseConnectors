using FirebirdSql.Data.FirebirdClient;
using LSCode.DatabaseConnectors.DataContexts;
using NUnit.Framework;
using System;
using System.Data;
using System.IO;

namespace LSCode.DatabaseConnectors.Test.Integration.DataContexts
{
    internal class FirebirdContextTest
    {
        private readonly string _connectionString = $@"Server=localhost; Database={AppDomain.CurrentDomain.BaseDirectory}\DatabaseName.FDB; User=SYSDBA; Password=masterkey;";

        public FirebirdContextTest()
        {
            if (!File.Exists($@"{AppDomain.CurrentDomain.BaseDirectory}\DatabaseName.FDB"))
                FbConnection.CreateDatabase(_connectionString);
        }

        [Test]
        public void Constructor_Valid()
        {
            var dataContext = new FirebirdContext(_connectionString);

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Open));
        }

        [Test]
        public void Dispose_Success()
        {
            var dataContext = new FirebirdContext(_connectionString);

            dataContext.Dispose();

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Closed));
        }
    }
}