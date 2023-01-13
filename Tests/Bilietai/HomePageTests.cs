using Framework.BilietaiPOM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            System.Threading.Thread.Sleep(5000);
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
            string response = HomePage.GetSelectedDate();

            Assert.IsTrue(response.Contains("21.01.2023"));
        }
    }
}
