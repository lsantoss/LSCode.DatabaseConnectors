using LSCode.DatabaseConnectors.DataContexts;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;

namespace LSCode.DatabaseConnectors.Test.Integration.DataContexts
{
    internal class RedisContextTest
    {
        private readonly string _connectionStringKey = "ConnectionStringRedis";
        private readonly string _connectionString = "localhost";

        [Test]
        public void Constructor_Valid()
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == _connectionStringKey)]).Returns(_connectionString);

            var dataContext = new RedisContext(configuration.Object);

            TestContext.WriteLine($"Connection: {dataContext.Connection.IsConnected}");

            Assert.That(dataContext.Connection.IsConnected, Is.True);
        }

        [Test]
        public void Dispose_Success()
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == _connectionStringKey)]).Returns(_connectionString);

            var dataContext = new RedisContext(configuration.Object);

            dataContext.Dispose();

            TestContext.WriteLine($"Connection: {dataContext.Connection.IsConnected}");

            Assert.That(dataContext.Connection.IsConnected, Is.False);
        }
    }
}