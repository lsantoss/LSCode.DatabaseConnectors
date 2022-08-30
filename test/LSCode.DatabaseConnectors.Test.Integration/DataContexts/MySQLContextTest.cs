using LSCode.DatabaseConnectors.DataContexts;
using NUnit.Framework;
using System.Data;

namespace LSCode.DatabaseConnectors.Test.Integration.DataContexts
{
    internal class MySQLContextTest
    {
        private readonly string _connectionString = "SERVER=localhost; DATABASE=mysql; UID=root; PASSWORD=root;";

        [Test]
        public void Constructor_Valid()
        {
            var dataContext = new MySQLContext(_connectionString);

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Open));
        }

        [Test]
        public void Dispose_Success()
        {
            var dataContext = new MySQLContext(_connectionString);

            dataContext.Dispose();

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Closed));
        }
    }
}