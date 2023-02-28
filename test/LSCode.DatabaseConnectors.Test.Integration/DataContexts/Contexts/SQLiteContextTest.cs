using LSCode.DatabaseConnectors.DataContexts.Contexts;
using NUnit.Framework;
using System;
using System.Data;

namespace LSCode.DatabaseConnectors.Test.Integration.DataContexts.Contexts
{
    internal class SQLiteContextTest
    {
        private readonly string _connectionString = $@"Data Source={AppDomain.CurrentDomain.BaseDirectory}\DatabaseName.sqlite;Version=3;";

        [Test]
        public void Constructor_Valid()
        {
            var dataContext = new SQLiteContext(_connectionString);

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Open));
        }

        [Test]
        public void Dispose_Success()
        {
            var dataContext = new SQLiteContext(_connectionString);

            dataContext.Dispose();

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Closed));
        }
    }
}