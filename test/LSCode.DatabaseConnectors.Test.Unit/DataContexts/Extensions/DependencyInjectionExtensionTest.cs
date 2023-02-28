using LSCode.DatabaseConnectors.DataContexts.Enums;
using LSCode.DatabaseConnectors.DataContexts.Extensions;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver.Core.Configuration;
using NUnit.Framework;
using System;

namespace LSCode.DatabaseConnectors.Test.Unit.DataContexts.Extensions
{
    internal class DependencyInjectionExtensionTest
    {
        [Test]
        [TestCase(-100)]
        [TestCase(-101)]
        [TestCase(-102)]
        public void AddDataContext_DatabaseManagementSystem_Invalid(int index)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddDataContext((DatabaseManagementSystem)index, ""));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddDataContext_AddFirebirdContext_Valid(string connectionString)
        {
            var services = new ServiceCollection();

            services.AddDataContext(DatabaseManagementSystem.Firebird, connectionString);

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
        public void AddDataContext_AddFirebirdContext_ConnectionString_Invalid(string connectionString)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddDataContext(DatabaseManagementSystem.Firebird, connectionString));
        }

        [Test]
        [TestCase("connectionString1", "databaseName1")]
        [TestCase("connectionString2", "databaseName2")]
        [TestCase("connectionString3", "databaseName3")]
        public void AddDataContext_AddMongoDBContext_Valid(string connectionString, string databaseName)
        {
            var services = new ServiceCollection();

            services.AddDataContext(DatabaseManagementSystem.MongoDB, connectionString, databaseName);

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
        public void AddDataContext_AddMongoDBContext_ConnectionString_Invalid(string connectionString, string databaseName)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddDataContext(DatabaseManagementSystem.MongoDB, connectionString, databaseName));
        }

        [Test]
        [TestCase("connectionString1", null)]
        [TestCase("connectionString2", "")]
        [TestCase("connectionString3", " ")]
        public void AddDataContext_AddMongoDBContext_DatabaseName_Invalid(string connectionString, string databaseName)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddDataContext(DatabaseManagementSystem.MongoDB, connectionString, databaseName));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddDataContext_AddMySQLContext_Valid(string connectionString)
        {
            var services = new ServiceCollection();

            services.AddDataContext(DatabaseManagementSystem.MySQL, connectionString);

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
        public void AddDataContext_AddMySQLContext_ConnectionString_Invalid(string connectionString)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddDataContext(DatabaseManagementSystem.MySQL, connectionString));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddDataContext_AddOracleContext_Valid(string connectionString)
        {
            var services = new ServiceCollection();

            services.AddDataContext(DatabaseManagementSystem.Oracle, connectionString);

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
        public void AddDataContext_AddOracleContext_ConnectionString_Invalid(string connectionString)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddDataContext(DatabaseManagementSystem.Oracle, connectionString));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddDataContext_AddPostgreSQLContext_Valid(string connectionString)
        {
            var services = new ServiceCollection();

            services.AddDataContext(DatabaseManagementSystem.PostgreSQL, connectionString);

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
        public void AddDataContext_AddPostgreSQLContext_ConnectionString_Invalid(string connectionString)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddDataContext(DatabaseManagementSystem.PostgreSQL, connectionString));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddDataContext_AddRedisContext_Valid(string connectionString)
        {
            var services = new ServiceCollection();

            services.AddDataContext(DatabaseManagementSystem.Redis, connectionString);

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
        public void AddDataContext_AddRedisContext_ConnectionString_Invalid(string connectionString)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddDataContext(DatabaseManagementSystem.Redis, connectionString));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddDataContext_AddSQLiteContext_Valid(string connectionString)
        {
            var services = new ServiceCollection();

            services.AddDataContext(DatabaseManagementSystem.SQLite, connectionString);

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
        public void AddDataContext_AddSQLiteContext_ConnectionString_Invalid(string connectionString)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddDataContext(DatabaseManagementSystem.SQLite, connectionString));
        }

        [Test]
        [TestCase("connectionString1")]
        [TestCase("connectionString2")]
        [TestCase("connectionString3")]
        public void AddDataContext_AddSQLServerContext_Valid(string connectionString)
        {
            var services = new ServiceCollection();

            services.AddDataContext(DatabaseManagementSystem.SQLServer, connectionString);

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
        public void AddDataContext_AddSQLServerContext_ConnectionString_Invalid(string connectionString)
        {
            var services = new ServiceCollection();

            Assert.Throws<ArgumentException>(() => services.AddDataContext(DatabaseManagementSystem.SQLServer, connectionString));
        }
    }
}