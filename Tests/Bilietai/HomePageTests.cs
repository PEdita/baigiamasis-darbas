using Framework.BilietaiPOM;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    internal class HomePageTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            HomePage.Open();
            HomePage.WaitTheCookieTableAppears();
            HomePage.ClickLeistiVisusSlapukusButton();
            HomePage.WaitThePopUpBannerAppears();
            HomePage.ClickPopUpBannerCloseButton();
            HomePage.WaitTheGalleryAppears();
        }

        [Test]
        public void AddATicketToTheCart()
        {
            string email = "jurgita@gmail.com";
            string expectedResult = "(1)";

            HomePage.ClickOnTheTicketName();
            HomePage.ClickPirktiBilietaButton();
            HomePage.ClickStovimasParterisOption();
            HomePage.ClickPlusButton();
            HomePage.ClickTinkaButton();
            HomePage.ClickTheNextOneTinkaButton();
            HomePage.EnterValidEmail(email);
            HomePage.ClickApmoketiButton();
            string actualResult = HomePage.GetTheAmauntOfTicketsInTheCart();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ChangeTheLanguageToEnglish()
        {
            string expectedText = "Recommended";

            HomePage.HoverTheMouseOverTheWordLietuviskai();
            HomePage.ClickTheOptionInEnglish();
            string actualText = HomePage.GetTheSelectedText();

            Assert.AreEqual(expectedText, actualText);
        }

        [Test]
        public void SearchByDate()
        {
            HomePage.ClickPasirinkitePeriodaButton();
            HomePage.ClickArtejantisSavaitgalisRadioButton();
            HomePage.ClickRodytiRenginiusOption();
            string responseNuo = HomePage.GetSelectedDate();
            string responseIki = HomePage.GetSecondSelectedDate();

            Assert.IsTrue(responseNuo.Contains("21.01.2023"));
            Assert.IsTrue(responseIki.Contains("22.01.2023"));
        }

        [Test]
        public void SearchByWord()
        {
            string expectedWord = "spektaklis";

            HomePage.EnterText(expectedWord);

            List<string> actualWord = HomePage.GetResultsOfSearchWord();

            foreach (string word in actualWord)
            {
                Assert.AreEqual(expectedWord, word);
            }
        }
    }
}
