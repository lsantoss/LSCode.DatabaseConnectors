using LSCode.DatabaseConnectors.DataContexts;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;
using System.Data;

namespace LSCode.DatabaseConnectors.Test.Integration.DataContexts
{
    internal class SQLServerContextTest
    {
        private readonly string _connectionStringKey = "ConnectionStringSQLServer";
        private readonly string _connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LSCode.DatabaseConnectors.Test;Data Source=SANTOS-PC\\SQLEXPRESS;";

        [Test]
        public void Test_Valid()
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == _connectionStringKey)]).Returns(_connectionString);

            var dataContext = new SQLServerContext(configuration.Object);

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Open));
        }

        [Test]
        public void Dispose_Success()
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == _connectionStringKey)]).Returns(_connectionString);

            var dataContext = new SQLServerContext(configuration.Object);

            dataContext.Dispose();

            TestContext.WriteLine($"Connection: {dataContext.Connection.State}");

            Assert.That(dataContext.Connection.State, Is.EqualTo(ConnectionState.Closed));
        }
    }
}