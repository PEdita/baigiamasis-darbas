using Framework.BilietaiPOM;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests.Bilietai
{
    internal class DovanuCekiaiTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            DovanuCekiai.Open();
            DovanuCekiai.WaitTheCookieTableAppears();
            DovanuCekiai.ClickLeistiVisusSlapukusButton();
        }

        [Test]
        public void GiftCardsSortingByName()
        {
            DovanuCekiai.ClickDataPagalDidejimoTvarkaDropdownArrow();
            DovanuCekiai.ClickPagalPavadinimaAZOption();
            List<string> actualResult = DovanuCekiai.GetDovanuCekiaiList();

            for (int i = 1; i < actualResult.Count; i++)
            {
                Assert.IsTrue(String.Compare(actualResult[i - 1], actualResult[i]) <= 0);
            }
        }
    }
}
