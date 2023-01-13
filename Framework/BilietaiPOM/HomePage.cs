using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Framework.BilietaiPOM
{
    public class HomePage
    {
        private static string url = "https://www.bilietai.lt/lit/";
        private static string buttonLocator = "//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']";
        private static string leistiVisusSlapukusButtonLocator = "//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']";
        private static string ticketNameLocator = "//span[contains(text(),'Sisters') and not(contains(@class,'mobile'))]";
        private static string pirktiBilietaButtonLocator = "(//span[contains(text(),'Pirkti bilietą')])[1]";
        private static string stovimasParterisOptionLocator = "//*[contains(text(),'Stovimas parteris')]";
        private static string plusButtonLocator = "//*[@name='plus']";
        private static string tinkaButtonLocator = "//*[contains(text(), 'Tinka')]";
        private static string theNextOneTinkaButtonLocator = "(//*[contains(text(), 'Tinka')])[2]";
        private static string inputEmailLocator = "//*[@name='email']";
        private static string apmoketiButtonLocator = "//*[contains(text(), 'Apmokėti')]";
        private static string elementTextLocator = "//*[contains(text(), '(1)')]";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void WaitTheCookieTableAppears()
        {
            Common.WaitForElementToBeClickable(buttonLocator);
        }

        public static void ClickLeistiVisusSlapukusButton()
        {
            Common.ClickElement(leistiVisusSlapukusButtonLocator);
        }

        public static void ClickOnTheTicketName()
        {
            Common.ClickElement(ticketNameLocator);
        }

        public static void ClickPirktiBilietaButton()
        {
            Common.ClickElement(pirktiBilietaButtonLocator);
        }

        public static void ClickStovimasParterisOption()
        {
            Common.WaitForElementToBeClickable(stovimasParterisOptionLocator);
            Common.ClickElement(stovimasParterisOptionLocator);
        }

        public static void ClickPlusButton()
        {
            Common.WaitForElementToBeClickable(plusButtonLocator);
            Common.ClickElement(plusButtonLocator);
        }

        public static void ClickTinkaButton()
        {
            Common.ClickElement(tinkaButtonLocator);
        }

        public static void ClickTheNextOneTinkaButton()
        {
            Common.WaitForElementToBeClickable(theNextOneTinkaButtonLocator);
            Common.ClickElement(theNextOneTinkaButtonLocator);
        }

        public static void EnterValidEmail(string email)
        {
            Common.WaitForElementToBeVisible(inputEmailLocator);
            Common.SendKeysToElement(inputEmailLocator, email);
        }

        public static void ClickApmoketiButton()
        {
            Common.ClickElement(apmoketiButtonLocator);
        }

        public static string GetTheAmauntOfTicketsInTheCart()
        {
            Common.WaitForElementToBeVisible(elementTextLocator);
            return Common.GetElementText(elementTextLocator);
        }
    }
}
