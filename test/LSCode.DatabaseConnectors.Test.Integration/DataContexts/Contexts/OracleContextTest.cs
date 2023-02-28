using LSCode.DatabaseConnectors.DataContexts.Contexts;
using NUnit.Framework;
using System.Data;

namespace LSCode.DatabaseConnectors.Test.Integration.DataContexts.Contexts
{
    internal class OracleContextTest
    {
        private readonly string _connectionString = "User ID=SYSTEM;Password=root;Data Source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = xe)));Pooling=true;Connection Lifetime=300;Max Pool Size=20;";

        [Test]
        public void Constructor_Valid()
        {
            var dataContext = new OracleContext(_connectionString);

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Open));
        }

        [Test]
        public void Dispose_Success()
        {
            var dataContext = new OracleContext(_connectionString);

            dataContext.Dispose();

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Closed));
        }
    }
}