using Framework.BilietaiPOM;
using NUnit.Framework;

namespace Tests.Bilietai
{
    internal class DovanuCekiaiTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            DovanuCekiai.Open();
        }

        [Test]
        public void GiftCardsSortingByName()
        {
            DovanuCekiai.ClickDataPagalDidejimoTvarkaDropdownArrow();
            DovanuCekiai.ClickPagalPavadinimaAZOption();

            Assert.IsTrue(DovanuCekiai.CheckIfDovanuCekiaiListIsAlphabetical());
        }
    }
}
