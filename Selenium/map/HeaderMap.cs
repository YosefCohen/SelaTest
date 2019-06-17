using OpenQA.Selenium;
using Selenium.Properties;
using System.Collections.Generic;

namespace Selenium.map
{
    public class HeaderMap
    {
        Settings config = Settings.Default;
        private IWebDriver _webDriver;

        public HeaderMap(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public IEnumerable<IWebElement> PlayList => _webDriver.FindElements(By.CssSelector
                                ("ytd-grid-radio-renderer.style-scope.ytd-grid-renderer"));

    }
}
