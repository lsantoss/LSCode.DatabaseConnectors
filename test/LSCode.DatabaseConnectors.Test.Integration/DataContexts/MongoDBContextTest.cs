using LSCode.DatabaseConnectors.DataContexts;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;

namespace LSCode.DatabaseConnectors.Test.Integration.DataContexts
{
    internal class MongoDBContextTest
    {
        private readonly string _connectionStringKey = "ConnectionStringMongoDB";
        private readonly string _connectionString = @"mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass%20Community&ssl=false";

        private readonly string _databaseNameKey = "DatabaseNameMongoDB";
        private readonly string _databaseName = @"LSCodeDatabaseConnectorsTest";

        [Test]
        public void Constructor_Valid()
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == _connectionStringKey)]).Returns(_connectionString);
            configuration.SetupGet(x => x[It.Is<string>(s => s == _databaseNameKey)]).Returns(_databaseName);

            var dataContext = new MongoDBContext(configuration.Object);

            TestContext.WriteLine($"Connection: {dataContext.Connection}");

            Assert.That(dataContext.Connection, Is.Not.Null);
        }

        [Test]
        public void Dispose_Success()
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == _connectionStringKey)]).Returns(_connectionString);
            configuration.SetupGet(x => x[It.Is<string>(s => s == _databaseNameKey)]).Returns(_databaseName);

            var dataContext = new MongoDBContext(configuration.Object);

            dataContext.Dispose();

            TestContext.WriteLine($"Connection: {dataContext.Connection}");

            Assert.That(dataContext.Connection, Is.Null);
        }
    }
}