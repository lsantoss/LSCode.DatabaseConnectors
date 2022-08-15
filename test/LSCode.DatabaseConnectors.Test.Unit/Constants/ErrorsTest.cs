using LSCode.DatabaseConnectors.Constants;
using NUnit.Framework;

namespace LSCode.DatabaseConnectors.Test.Unit.Constants
{
    internal class ErrorsTest
    {
        private readonly string IConfigurationNull = "The configuration parameter cannot be null";
        private readonly string KeyNullEmptyOrWhiteSpace = @"The key must contain values. Check if this property exists, if it contains a value or if it has the wrong name.";

        [Test]
        public void IConfigurationNull_Text_Valid()
        {
            Assert.That(Errors.IConfigurationNull, Is.EqualTo(IConfigurationNull));
        }

        [Test]
        public void KeyNullEmptyOrWhiteSpace_Text_Valid()
        {
            Assert.That(Errors.KeyNullEmptyOrWhiteSpace, Is.EqualTo(KeyNullEmptyOrWhiteSpace));
        }
    }
}