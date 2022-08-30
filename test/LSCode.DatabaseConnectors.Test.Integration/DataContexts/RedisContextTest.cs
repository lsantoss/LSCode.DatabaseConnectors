using LSCode.DatabaseConnectors.DataContexts;
using NUnit.Framework;

namespace LSCode.DatabaseConnectors.Test.Integration.DataContexts
{
    internal class RedisContextTest
    {
        private readonly string _connectionString = "localhost";

        [Test]
        public void Constructor_Valid()
        {
            var dataContext = new RedisContext(_connectionString);

            TestContext.WriteLine($"Connection: {dataContext.Connection.IsConnected}");

            Assert.That(dataContext.Connection.IsConnected, Is.True);
        }

        [Test]
        public void Dispose_Success()
        {
            var dataContext = new RedisContext(_connectionString);

            dataContext.Dispose();

            TestContext.WriteLine($"Connection: {dataContext.Connection.IsConnected}");

            Assert.That(dataContext.Connection.IsConnected, Is.False);
        }
    }
}