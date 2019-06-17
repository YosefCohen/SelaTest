using OpenQA.Selenium;
using Selenium.map;

namespace Selenium.page
{
    public class MenuPage : BasePage
    {
        private IWebDriver _driver;
        private MenuMap _menuMap;

        public MenuPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
            _menuMap = new MenuMap(_driver);
        }

        public void ClickOnHeaderButton()
        {
            WaitUntilElementToBeClickable(By.CssSelector
                         ("div#header.style-scope.ytd-guide-collapsible-section-entry-renderer"),8000);
            _menuMap.HeaderButton.Click();
        }
    }
}
