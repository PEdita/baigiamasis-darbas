﻿using System.Collections.Generic;

namespace Framework.BilietaiPOM
{
    public class HomePage
    {
        private static string url = "https://www.bilietai.lt/lit/";
        private static string popUpBannerCloseLocator = "//*[@class='popupbanner_close']";
        private static string galleryLocator = "//*[@class='gallery_description']";
        
        private static string ticketNameLocator = "//span[contains(text(),'Sisters') and not(contains(@class,'mobile'))]";
        private static string pirktiBilietaButtonLocator = "(//span[contains(text(),'Pirkti bilietą')])[1]";
        private static string stovimasParterisOptionLocator = "//*[contains(text(),'Stovimas parteris')]";
        private static string plusButtonLocator = "//*[@name='plus']";
        private static string tinkaButtonLocator = "//*[contains(text(), 'Tinka')]";
        private static string theNextOneTinkaButtonLocator = "(//*[contains(text(), 'Tinka')])[2]";
        private static string inputEmailLocator = "//*[@name='email']";
        private static string apmoketiButtonLocator = "//*[contains(text(), 'Apmokėti')]";
        private static string elementTextLocator = "//*[contains(text(), '(1)')]";

        private static string elementLocator = "(//*[@class='lang_select_current'])[1]";
        private static string inEnglishOptionLocator = "(//*[@title='In English'])[1]";
        private static string selectedTextLocator = "//*[@class='content_module_heading' and contains (text(), 'Recommended')]";

        private static string pasirinkitePeriodaButtonLocator = "(//*[@class='date_search_button'])[1]";
        private static string artejantisSavaitgalisRadioButtonLocator = "//*[text()='Artėjantis savaitgalis']";
        private static string rodytiRenginiusButtonLocator = "//*[@class='date_search_popup_button button']";
        private static string dateLocator = "//*[@class='concerts_filter_date_wrapper date_wrapper_from']";
        private static string secondDateLocator = "//*[@class='concerts_filter_date_wrapper date_wrapper_to']";
        
        public static void Open()
        {
            Driver.OpenPage(url);
            CommonBilietai.WaitTheCookieTableAppears();
            CommonBilietai.ClickLeistiVisusSlapukusButton();
            WaitThePopUpBannerAppears();
            ClickPopUpBannerCloseButton();
            WaitTheGalleryAppears();
        }

        public static void WaitThePopUpBannerAppears()
        {
            Common.WaitForElementToBeClickable(popUpBannerCloseLocator);
        }

        public static void ClickPopUpBannerCloseButton()
        {
            System.Threading.Thread.Sleep(2000);
            Common.ClickElement(popUpBannerCloseLocator);
        }

        public static void WaitTheGalleryAppears()
        {
            Common.WaitForElementToBeVisible(galleryLocator);
        }

        //AddATicketToTheCart test methods
        public static void ClickOnTheTicketName()
        {
            Common.ClickElement(ticketNameLocator);
        }

        public static void ClickPirktiBilietaButton()
        {
            Common.WaitForElementToBeClickable(pirktiBilietaButtonLocator);
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

        public static string GetTheAmountOfTicketsInTheCart()
        {
            Common.WaitForElementToBeVisible(elementTextLocator);
            return Common.GetElementText(elementTextLocator);
        }

        //SearchByDate Test methods
        public static void ClickPasirinkitePeriodaButton()
        {
            Common.ClickElement(pasirinkitePeriodaButtonLocator);
        }

        public static void ClickArtejantisSavaitgalisRadioButton()
        {
            Common.ClickElement(artejantisSavaitgalisRadioButtonLocator);
        }

        public static void ClickRodytiRenginiusOption()
        {
            Common.ClickElement(rodytiRenginiusButtonLocator);
        }

        public static string GetSelectedDate()
        {
            return Common.GetElementText(dateLocator);
        }
        public static string GetSecondSelectedDate()
        {
            return Common.GetElementText(secondDateLocator);
        }

        //ChangeTheLanguageToEnglish test methods
        public static void HoverOnLanguageDropdown()
        {
            Common.HoverTheMouseOverTheElement(elementLocator);
        }

        public static void ClickEnglishOption()
        {
            Common.WaitForElementToBeVisible(elementLocator);
            Common.ClickElement(inEnglishOptionLocator);
        }

        public static string GetSelectedText()
        {
            return Common.GetElementText(selectedTextLocator);
        }

        //SearchByWord test methods
        public static void EnterText(string expectedText)
        {
            Common.SendKeysToElement("//*[@name='search']", expectedText);
        }

        public static List<string> GetSearchResults()
        {
            return Common.GetElementsTextToList("//*[@class='searchresult_foundword']");
        }
    }
}
