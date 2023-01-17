using Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework;

namespace Tests
{
    internal class BaseTest
    {
        [SetUp]
        public virtual void SetUp()
        {
            Driver.Initialize();
        }

        [TearDown]
        public virtual void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
            }
            Driver.CloseDriver();
        }
    }
}
