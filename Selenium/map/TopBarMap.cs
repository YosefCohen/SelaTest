using OpenQA.Selenium;
using Selenium.Properties;

namespace Selenium.map
{
    public class TopBarMap
    {
        Settings config = Settings.Default;
        private IWebDriver _webDriver;

        public TopBarMap(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public IWebElement menuButton => _webDriver.FindElement(By.CssSelector
                                     ("div[id='container']>yt-icon-button>button > yt-icon[id='guide-icon']"));

        public IWebElement logoIcon => _webDriver.FindElement(By.CssSelector
                                                  ("ytd-topbar-logo-renderer#logo>a>div#logo-icon-container"));

        public IWebElement SearchLine => _webDriver.FindElement(By.CssSelector("input[id='search']"));

        public IWebElement SearchButton => _webDriver.FindElement(By.CssSelector("#search-icon-legacy"));

        public IWebElement LogInButton => _webDriver.FindElement(By.CssSelector
                                                           ("div#buttons>ytd-button-renderer>a>paper-button"));
    }

}
