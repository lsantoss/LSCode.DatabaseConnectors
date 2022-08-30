using LSCode.DatabaseConnectors.DataContexts;
using NUnit.Framework;

namespace LSCode.DatabaseConnectors.Test.Integration.DataContexts
{
    internal class MongoDBContextTest
    {
        private readonly string _connectionString = "mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass%20Community&ssl=false";
        private readonly string _databaseName = "DatabaseName";

        [Test]
        public void Constructor_Valid()
        {
            var dataContext = new MongoDBContext(_connectionString, _databaseName);

            TestContext.WriteLine($"Connection: {dataContext.Connection}");

            Assert.That(dataContext.Connection, Is.Not.Null);
        }

        [Test]
        public void Dispose_Success()
        {
            var dataContext = new MongoDBContext(_connectionString, _databaseName);

            dataContext.Dispose();

            TestContext.WriteLine($"Connection: {dataContext.Connection}");

            Assert.That(dataContext.Connection, Is.Null);
        }
    }
}