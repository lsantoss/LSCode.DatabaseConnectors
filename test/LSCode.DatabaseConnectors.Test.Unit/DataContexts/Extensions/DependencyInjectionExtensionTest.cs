using LSCode.DatabaseConnectors.DataContexts.Extensions;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;

namespace LSCode.DatabaseConnectors.Test.Unit.DataContexts.Extensions
{
    internal class DependencyInjectionExtensionTest
    {
        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddFirebirdContext_Valid(string connectionString)
        {
            var services = new ServiceCollection();

            services.AddFirebirdContext(connectionString);

            var count = services.Count;
            var serviceType = services[0].ServiceType.Name;

            Assert.Multiple(() =>
            {
                Assert.That(count, Is.EqualTo(1));
                Assert.That(serviceType, Is.EqualTo("IFirebirdContext"));
            });
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddFirebirdContext_ConnectionString_Invalid(string connectionString)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddFirebirdContext(connectionString));
        }

        [Test]
        [TestCase("connectionString1", "databaseName1")]
        [TestCase("connectionString2", "databaseName2")]
        [TestCase("connectionString3", "databaseName3")]
        public void AddMongoDBContext_Valid(string connectionString, string databaseName)
        {
            var services = new ServiceCollection();

            services.AddMongoDBContext(connectionString, databaseName);

            var count = services.Count;
            var serviceType = services[0].ServiceType.Name;

            Assert.Multiple(() =>
            {
                Assert.That(count, Is.EqualTo(1));
                Assert.That(serviceType, Is.EqualTo("IMongoDBContext"));
            });
        }

        [Test]
        [TestCase(null, "databaseName1")]
        [TestCase("", "databaseName2")]
        [TestCase(" ", "databaseName3")]
        public void AddMongoDBContext_ConnectionString_Invalid(string connectionString, string databaseName)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddMongoDBContext(connectionString, databaseName));
        }

        [Test]
        [TestCase("connectionString1", null)]
        [TestCase("connectionString2", "")]
        [TestCase("connectionString3", " ")]
        public void AddMongoDBContext_DatabaseName_Invalid(string connectionString, string databaseName)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddMongoDBContext(connectionString, databaseName));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddMySQLContext_Valid(string connectionString)
        {
            var services = new ServiceCollection();

            services.AddMySQLContext(connectionString);

            var count = services.Count;
            var serviceType = services[0].ServiceType.Name;

            Assert.Multiple(() =>
            {
                Assert.That(count, Is.EqualTo(1));
                Assert.That(serviceType, Is.EqualTo("IMySQLContext"));
            });
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddMySQLContext_ConnectionString_Invalid(string connectionString)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddMySQLContext(connectionString));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddOracleContext_Valid(string connectionString)
        {
            var services = new ServiceCollection();

            services.AddOracleContext(connectionString);

            var count = services.Count;
            var serviceType = services[0].ServiceType.Name;

            Assert.Multiple(() =>
            {
                Assert.That(count, Is.EqualTo(1));
                Assert.That(serviceType, Is.EqualTo("IOracleContext"));
            });
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddOracleContext_ConnectionString_Invalid(string connectionString)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddOracleContext(connectionString));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddPostgreSQLContext_Valid(string connectionString)
        {
            var services = new ServiceCollection();

            services.AddPostgreSQLContext(connectionString);

            var count = services.Count;
            var serviceType = services[0].ServiceType.Name;

            Assert.Multiple(() =>
            {
                Assert.That(count, Is.EqualTo(1));
                Assert.That(serviceType, Is.EqualTo("IPostgreSQLContext"));
            });
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddPostgreSQLContext_ConnectionString_Invalid(string connectionString)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddPostgreSQLContext(connectionString));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddRedisContext_Valid(string connectionString)
        {
            var services = new ServiceCollection();

            services.AddRedisContext(connectionString);

            var count = services.Count;
            var serviceType = services[0].ServiceType.Name;

            Assert.Multiple(() =>
            {
                Assert.That(count, Is.EqualTo(1));
                Assert.That(serviceType, Is.EqualTo("IRedisContext"));
            });
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddRedisContext_ConnectionString_Invalid(string connectionString)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddRedisContext(connectionString));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddSQLiteContext_Valid(string connectionString)
        {
            var services = new ServiceCollection();

            services.AddSQLiteContext(connectionString);

            var count = services.Count;
            var serviceType = services[0].ServiceType.Name;

            Assert.Multiple(() =>
            {
                Assert.That(count, Is.EqualTo(1));
                Assert.That(serviceType, Is.EqualTo("ISQLiteContext"));
            });
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddSQLiteContext_ConnectionString_Invalid(string connectionString)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddSQLiteContext(connectionString));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddSQLServerContext_Valid(string connectionString)
        {
            var services = new ServiceCollection();

            services.AddSQLServerContext(connectionString);

            var count = services.Count;
            var serviceType = services[0].ServiceType.Name;

            Assert.Multiple(() =>
            {
                Assert.That(count, Is.EqualTo(1));
                Assert.That(serviceType, Is.EqualTo("ISQLServerContext"));
            });
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void AddSQLServerContext_ConnectionString_Invalid(string connectionString)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddSQLServerContext(connectionString));
        }
    }
}