using OpenQA.Selenium;
using Selenium.Properties;

namespace Selenium.map
{
    class MenuMap
    {
        Settings config = Settings.Default;
        private IWebDriver _webDriver;

        public MenuMap(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public IWebElement HeaderButton => _webDriver.FindElement(By.CssSelector
                             ("div#header.style-scope.ytd-guide-collapsible-section-entry-renderer"));
    }
}
