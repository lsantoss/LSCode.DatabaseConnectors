using LSCode.DatabaseConnectors.Test.Tools.Base.Common;
using NUnit.Framework;

namespace LSCode.DatabaseConnectors.Test.Tools.Base.Unit
{
    [TestFixture]
    public class UnitTest : BaseTest
    {
        public UnitTest() : base() { }

        [OneTimeSetUp]
        protected override void OneTimeSetUp() => base.OneTimeSetUp();

        [OneTimeTearDown]
        protected override void OneTimeTearDown() => base.OneTimeTearDown();

        [SetUp]
        protected override void SetUp() => base.SetUp();

        [TearDown]
        protected override void TearDown() => base.TearDown();
    }
}