using System.Collections.Generic;

namespace Framework.BilietaiPOM
{
    public class DovanuCekiai
    {
        private static string url = "https://www.bilietai.lt/lit/renginiai/dovanu-cekiai/";
        private static string dataPagalDidejimoTvarkaDropdownArrowLocator = "//*[@class='dropdown_arrow']";
        private static string pagalPavadinimaAZOptionLocator = "//*[@class='dropdown_option' and contains(text(),'Pagal')]";
        private static string dovanuCekiaiTextLocator = "//*[@class='concertslist_pages']//*[@class='event_short_title']";
        private static string spinerLocator = "//*[@class='content_modules']//*[@class='loader']";

        public static void Open()
        {
            Driver.OpenPage(url);
            CommonBilietai.WaitTheCookieTableAppears();
            CommonBilietai.ClickLeistiVisusSlapukusButton();
        }

        //GiftCardsSortingByName test methods
        public static void ClickDataPagalDidejimoTvarkaDropdownArrow()
        {
            Common.WaitForElementToBeClickable(dataPagalDidejimoTvarkaDropdownArrowLocator);
            Common.ClickElement(dataPagalDidejimoTvarkaDropdownArrowLocator);
        }

        public static void ClickPagalPavadinimaAZOption()
        {
            Common.WaitForElementToBeVisible(pagalPavadinimaAZOptionLocator);
            Common.ClickElement(pagalPavadinimaAZOptionLocator);
            Common.WaitForElementToBeInvisible(spinerLocator);
        }

        public static List<string> GetDovanuCekiaiList()
        {
            Common.WaitForElementToBeVisible(dovanuCekiaiTextLocator);
            return Common.GetElementsTextToList(dovanuCekiaiTextLocator);
        }
    }
}
