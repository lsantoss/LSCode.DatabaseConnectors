using NUnit.Framework;

namespace LSCode.DatabaseConnectors.Test.Tools.Base.Common
{
    [TestFixture]
    public class BaseTest : Startup
    {
        public BaseTest() : base() { }

        [OneTimeSetUp]
        protected virtual void OneTimeSetUp() { }

        [OneTimeTearDown]
        protected virtual void OneTimeTearDown() { }

        [SetUp]
        protected virtual void SetUp() { }

        [TearDown]
        protected virtual void TearDown() { }
    }
}