using LSCode.DatabaseConnectors.DataContexts.Constants;
using NUnit.Framework;

namespace LSCode.DatabaseConnectors.Test.Unit.DataContexts.Constants
{
    internal class ErrorsTest
    {
        [Test]
        public void ConnectionStingNullEmptyOrWhiteSpace_Text_Valid()
        {
            Assert.That(
                Errors.ConnectionStingNullEmptyOrWhiteSpace,
                Is.EqualTo("The parameter connectionString must contain values. Cannot be null, empty or consists only of white-space characters."));
        }

        [Test]
        public void DatabaseNameNullEmptyOrWhiteSpace_Text_Valid()
        {
            Assert.That(
                Errors.DatabaseNameNullEmptyOrWhiteSpace,
                Is.EqualTo("The parameter databaseName must contain values. Cannot be null, empty or consists only of white-space characters."));
        }
    }
}