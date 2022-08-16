using LSCode.DatabaseConnectors.Extensions;
using LSCode.DatabaseConnectors.Test.Tools.Base.Unit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using System;

namespace LSCode.DatabaseConnectors.Test.Unit.Extensions
{
    internal class DependencyInjectionExtensionTest : UnitTest
    {
        [Test]
        public void AddFirebirdContext_Valid()
        {
            var configuration = GetConfiguration();

            var services = new ServiceCollection();

            services.AddFirebirdContext(configuration);

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
            var configuration = Mock.Of<IConfiguration>();
            configuration = null;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddFirebirdContext(configuration));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddFirebirdContext_ConnectionString_Invalid(string connctionString)
        {
            var configuration = Mock.Of<IConfiguration>();
            configuration["ConnectionStringFirebird"] = connctionString;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddFirebirdContext(configuration));
        }

        [Test]
        public void AddMongoDBContext_Valid()
        {
            var configuration = GetConfiguration();

            var services = new ServiceCollection();

            services.AddMongoDBContext(configuration);

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
            var configuration = Mock.Of<IConfiguration>();
            configuration = null;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddMongoDBContext(configuration));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddMongoDBContext_ConnectionString_Invalid(string connctionString)
        {
            var configuration = Mock.Of<IConfiguration>();
            configuration["ConnectionStringMongoDB"] = connctionString;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddMongoDBContext(configuration));
        }

        [Test]
        public void AddMySQLContext_Valid()
        {
            var configuration = GetConfiguration();

            var services = new ServiceCollection();

            services.AddMySQLContext(configuration);

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
            var configuration = Mock.Of<IConfiguration>();
            configuration = null;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddMySQLContext(configuration));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddMySQLContext_ConnectionString_Invalid(string connctionString)
        {
            var configuration = Mock.Of<IConfiguration>();
            configuration["ConnectionStringMySQL"] = connctionString;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddMySQLContext(configuration));
        }

        [Test]
        public void AddOracleContext_Valid()
        {
            var configuration = GetConfiguration();

            var services = new ServiceCollection();

            services.AddOracleContext(configuration);

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
            var configuration = Mock.Of<IConfiguration>();
            configuration = null;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddOracleContext(configuration));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddOracleContext_ConnectionString_Invalid(string connctionString)
        {
            var configuration = Mock.Of<IConfiguration>();
            configuration["ConnectionStringOracle"] = connctionString;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddOracleContext(configuration));
        }

        [Test]
        public void AddPostgreSQLContext_Valid()
        {
            var configuration = GetConfiguration();

            var services = new ServiceCollection();

            services.AddPostgreSQLContext(configuration);

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
            var configuration = Mock.Of<IConfiguration>();
            configuration = null;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddPostgreSQLContext(configuration));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddPostgreSQLContext_ConnectionString_Invalid(string connctionString)
        {
            var configuration = Mock.Of<IConfiguration>();
            configuration["ConnectionStringPostgreSQL"] = connctionString;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddPostgreSQLContext(configuration));
        }

        [Test]
        public void AddRedisContext_Valid()
        {
            var configuration = GetConfiguration();

            var services = new ServiceCollection();

            services.AddRedisContext(configuration);

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
            var configuration = Mock.Of<IConfiguration>();
            configuration = null;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddRedisContext(configuration));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddRedisContext_ConnectionString_Invalid(string connctionString)
        {
            var configuration = Mock.Of<IConfiguration>();
            configuration["ConnectionStringRedis"] = connctionString;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddRedisContext(configuration));
        }

        [Test]
        public void AddSQLiteContext_Valid()
        {
            var configuration = GetConfiguration();

            var services = new ServiceCollection();

            services.AddSQLiteContext(configuration);

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
            var configuration = Mock.Of<IConfiguration>();
            configuration = null;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddSQLiteContext(configuration));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddSQLiteContext_ConnectionString_Invalid(string connctionString)
        {
            var configuration = Mock.Of<IConfiguration>();
            configuration["ConnectionStringSQLite"] = connctionString;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddSQLiteContext(configuration));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddMongoDBContext_DatabaseName_Invalid(string databaseName)
        {
            var configuration = Mock.Of<IConfiguration>();
            configuration["DatabaseNameMongoDB"] = databaseName;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddMongoDBContext(configuration));
        }

        [Test]
        public void AddSQLServerContext_Valid()
        {
            var configuration = GetConfiguration();

            var services = new ServiceCollection();

            services.AddSQLServerContext(configuration);

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
            var configuration = Mock.Of<IConfiguration>();
            configuration = null;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddSQLServerContext(configuration));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddSQLServerContext_ConnectionString_Invalid(string connctionString)
        {
            var configuration = Mock.Of<IConfiguration>();
            configuration["ConnectionStringSQLServer"] = connctionString;

            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddSQLServerContext(configuration));
        }
    }
}