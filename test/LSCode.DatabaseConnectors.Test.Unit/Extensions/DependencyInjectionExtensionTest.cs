using LSCode.DatabaseConnectors.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using System;

namespace LSCode.DatabaseConnectors.Test.Unit.Extensions
{
    internal class DependencyInjectionExtensionTest
    {
        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddFirebirdContext_Valid(string connectionString)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "ConnectionStringFirebird")]).Returns(connectionString);

            var services = new ServiceCollection();

            services.AddFirebirdContext(configuration.Object);

            var count = services.Count;
            var serviceType = services[0].ServiceType.Name;
            var implementationType = services[0].ImplementationType.Name;
            
            Assert.Multiple(() =>
            {
                Assert.That(count, Is.EqualTo(1));
                Assert.That(serviceType, Is.EqualTo("IFirebirdContext"));
                Assert.That(implementationType, Is.EqualTo("FirebirdContext"));
            });
        }

        [Test]
        public void AddFirebirdContext_Configuration_Null_Invalid()
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddFirebirdContext(null));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddFirebirdContext_ConnectionString_Invalid(string connectionString)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "ConnectionStringFirebird")]).Returns(connectionString);

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddFirebirdContext(configuration.Object));
        }

        [Test]
        [TestCase("connectionString1", "databaseName1")]
        [TestCase("connectionString2", "databaseName2")]
        [TestCase("connectionString3", "databaseName3")]
        public void AddMongoDBContext_Valid(string connectionString, string databaseName)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "ConnectionStringMongoDB")]).Returns(connectionString);
            configuration.SetupGet(x => x[It.Is<string>(s => s == "DatabaseNameMongoDB")]).Returns(databaseName);

            var services = new ServiceCollection();

            services.AddMongoDBContext(configuration.Object);

            var count = services.Count;
            var serviceType = services[0].ServiceType.Name;
            var implementationType = services[0].ImplementationType.Name;

            Assert.Multiple(() =>
            {
                Assert.That(count, Is.EqualTo(1));
                Assert.That(serviceType, Is.EqualTo("IMongoDBContext"));
                Assert.That(implementationType, Is.EqualTo("MongoDBContext"));
            });
        }

        [Test]
        public void AddMongoDBContext_Configuration_Null_Invalid()
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddMongoDBContext(null));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddMongoDBContext_ConnectionString_Invalid(string connectionString)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "ConnectionStringMongoDB")]).Returns(connectionString);

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddMongoDBContext(configuration.Object));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddMySQLContext_Valid(string connectionString)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "ConnectionStringMySQL")]).Returns(connectionString);

            var services = new ServiceCollection();

            services.AddMySQLContext(configuration.Object);

            var count = services.Count;
            var serviceType = services[0].ServiceType.Name;
            var implementationType = services[0].ImplementationType.Name;

            Assert.Multiple(() =>
            {
                Assert.That(count, Is.EqualTo(1));
                Assert.That(serviceType, Is.EqualTo("IMySQLContext"));
                Assert.That(implementationType, Is.EqualTo("MySQLContext"));
            });
        }

        [Test]
        public void AddMySQLContext_Configuration_Null_Invalid()
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddMySQLContext(null));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddMySQLContext_ConnectionString_Invalid(string connectionString)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "ConnectionStringMySQL")]).Returns(connectionString);

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddMySQLContext(configuration.Object));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddOracleContext_Valid(string connectionString)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "ConnectionStringOracle")]).Returns(connectionString);

            var services = new ServiceCollection();

            services.AddOracleContext(configuration.Object);

            var count = services.Count;
            var serviceType = services[0].ServiceType.Name;
            var implementationType = services[0].ImplementationType.Name;

            Assert.Multiple(() =>
            {
                Assert.That(count, Is.EqualTo(1));
                Assert.That(serviceType, Is.EqualTo("IOracleContext"));
                Assert.That(implementationType, Is.EqualTo("OracleContext"));
            });
        }

        [Test]
        public void AddOracleContext_Configuration_Null_Invalid()
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddOracleContext(null));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddOracleContext_ConnectionString_Invalid(string connectionString)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "ConnectionStringOracle")]).Returns(connectionString);

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddOracleContext(configuration.Object));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddPostgreSQLContext_Valid(string connectionString)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "ConnectionStringPostgreSQL")]).Returns(connectionString);

            var services = new ServiceCollection();

            services.AddPostgreSQLContext(configuration.Object);

            var count = services.Count;
            var serviceType = services[0].ServiceType.Name;
            var implementationType = services[0].ImplementationType.Name;

            Assert.Multiple(() =>
            {
                Assert.That(count, Is.EqualTo(1));
                Assert.That(serviceType, Is.EqualTo("IPostgreSQLContext"));
                Assert.That(implementationType, Is.EqualTo("PostgreSQLContext"));
            });
        }

        [Test]
        public void AddPostgreSQLContext_Configuration_Null_Invalid()
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddPostgreSQLContext(null));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddPostgreSQLContext_ConnectionString_Invalid(string connectionString)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "ConnectionStringPostgreSQL")]).Returns(connectionString);

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddPostgreSQLContext(configuration.Object));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddRedisContext_Valid(string connectionString)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "ConnectionStringRedis")]).Returns(connectionString);

            var services = new ServiceCollection();

            services.AddRedisContext(configuration.Object);

            var count = services.Count;
            var serviceType = services[0].ServiceType.Name;
            var implementationType = services[0].ImplementationType.Name;

            Assert.Multiple(() =>
            {
                Assert.That(count, Is.EqualTo(1));
                Assert.That(serviceType, Is.EqualTo("IRedisContext"));
                Assert.That(implementationType, Is.EqualTo("RedisContext"));
            });
        }

        [Test]
        public void AddRedisContext_Configuration_Null_Invalid()
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddRedisContext(null));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddRedisContext_ConnectionString_Invalid(string connectionString)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "ConnectionStringRedis")]).Returns(connectionString);

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddRedisContext(configuration.Object));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddSQLiteContext_Valid(string connectionString)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "ConnectionStringSQLite")]).Returns(connectionString);

            var services = new ServiceCollection();

            services.AddSQLiteContext(configuration.Object);

            var count = services.Count;
            var serviceType = services[0].ServiceType.Name;
            var implementationType = services[0].ImplementationType.Name;

            Assert.Multiple(() =>
            {
                Assert.That(count, Is.EqualTo(1));
                Assert.That(serviceType, Is.EqualTo("ISQLiteContext"));
                Assert.That(implementationType, Is.EqualTo("SQLiteContext"));
            });
        }

        [Test]
        public void AddSQLiteContext_Configuration_Null_Invalid()
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddSQLiteContext(null));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddSQLiteContext_ConnectionString_Invalid(string connectionString)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "ConnectionStringSQLite")]).Returns(connectionString);

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddSQLiteContext(configuration.Object));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddMongoDBContext_DatabaseName_Invalid(string databaseName)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "DatabaseNameMongoDB")]).Returns(databaseName);

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddMongoDBContext(configuration.Object));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddSQLServerContext_Valid(string connectionString)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "ConnectionStringSQLServer")]).Returns(connectionString);

            var services = new ServiceCollection();

            services.AddSQLServerContext(configuration.Object);

            var count = services.Count;
            var serviceType = services[0].ServiceType.Name;
            var implementationType = services[0].ImplementationType.Name;

            Assert.Multiple(() =>
            {
                Assert.That(count, Is.EqualTo(1));
                Assert.That(serviceType, Is.EqualTo("ISQLServerContext"));
                Assert.That(implementationType, Is.EqualTo("SQLServerContext"));
            });
        }

        [Test]
        public void AddSQLServerContext_Configuration_Null_Invalid()
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddSQLServerContext(null));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddSQLServerContext_ConnectionString_Invalid(string connectionString)
        {
            var configuration = new Mock<IConfiguration>();
            configuration.SetupGet(x => x[It.Is<string>(s => s == "ConnectionStringSQLServer")]).Returns(connectionString);

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddSQLServerContext(configuration.Object));
        }
    }
}