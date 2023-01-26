namespace Framework.BilietaiPOM
{
    internal class CommonBilietai
    {
        private static string buttonLocator = "//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']";
        private static string leistiVisusSlapukusButtonLocator = "//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']";

        internal static void WaitTheCookieTableAppears()
        {
            Common.WaitForElementToBeClickable(buttonLocator);
        }

        internal static void ClickLeistiVisusSlapukusButton()
        {
            Common.ClickElement(leistiVisusSlapukusButtonLocator);
        }
    }
}
