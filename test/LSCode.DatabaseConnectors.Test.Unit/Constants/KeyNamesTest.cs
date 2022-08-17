using LSCode.DatabaseConnectors.Constants;
using NUnit.Framework;

namespace LSCode.DatabaseConnectors.Test.Unit.Constants
{
    internal class KeyNamesTest
    {
        [Test]
        public void IConfigurationNull_Text_Valid()
        {
            Assert.That(
                KeyNames.ConnectionStringFirebird, 
                Is.EqualTo("ConnectionStringFirebird"));
        }

        [Test]
        public void ConnectionStringMongoDB_Text_Valid()
        {
            Assert.That(
                KeyNames.ConnectionStringMongoDB, 
                Is.EqualTo("ConnectionStringMongoDB"));
        }

        [Test]
        public void DatabaseNameMongoDB_Text_Valid()
        {
            Assert.That(
                KeyNames.DatabaseNameMongoDB, 
                Is.EqualTo("DatabaseNameMongoDB"));
        }

        [Test]
        public void ConnectionStringMySQL_Text_Valid()
        {
            Assert.That(
                KeyNames.ConnectionStringMySQL, 
                Is.EqualTo("ConnectionStringMySQL"));
        }

        [Test]
        public void ConnectionStringOracle_Text_Valid()
        {
            Assert.That(
                KeyNames.ConnectionStringOracle, 
                Is.EqualTo("ConnectionStringOracle"));
        }

        [Test]
        public void ConnectionStringPostgreSQL_Text_Valid()
        {
            Assert.That(
                KeyNames.ConnectionStringPostgreSQL, 
                Is.EqualTo("ConnectionStringPostgreSQL"));
        }

        [Test]
        public void ConnectionStringRedis_Text_Valid()
        {
            Assert.That(
                KeyNames.ConnectionStringRedis, 
                Is.EqualTo("ConnectionStringRedis"));
        }

        [Test]
        public void ConnectionStringSQLite_Text_Valid()
        {
            Assert.That(
                KeyNames.ConnectionStringSQLite, 
                Is.EqualTo("ConnectionStringSQLite"));
        }

        [Test]
        public void ConnectionStringSQLServer_Text_Valid()
        {
            Assert.That(
                KeyNames.ConnectionStringSQLServer, 
                Is.EqualTo("ConnectionStringSQLServer"));
        }
    }
}