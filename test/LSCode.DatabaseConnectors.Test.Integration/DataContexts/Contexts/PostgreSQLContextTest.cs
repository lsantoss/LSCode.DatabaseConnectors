using LSCode.DatabaseConnectors.DataContexts.Contexts;
using NUnit.Framework;
using System.Data;

namespace LSCode.DatabaseConnectors.Test.Integration.DataContexts.Contexts
{
    internal class PostgreSQLContextTest
    {
        private readonly string _connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=root;";

        [Test]
        public void Constructor_Valid()
        {
            var dataContext = new PostgreSQLContext(_connectionString);

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Open));
        }

        [Test]
        public void Dispose_Success()
        {
            var dataContext = new PostgreSQLContext(_connectionString);

            dataContext.Dispose();

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Closed));
        }
    }
}