using LSCode.DatabaseConnectors.DataContexts;
using NUnit.Framework;
using System.Data;

namespace LSCode.DatabaseConnectors.Test.Integration.DataContexts
{
    internal class SQLServerContextTest
    {
        private readonly string _connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=SANTOS-PC\SQLEXPRESS;";

        [Test]
        public void Constructor_Valid()
        {
            var dataContext = new SQLServerContext(_connectionString);

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Open));
        }

        [Test]
        public void Dispose_Success()
        {
            var dataContext = new SQLServerContext(_connectionString);

            dataContext.Dispose();

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Closed));
        }
    }
}