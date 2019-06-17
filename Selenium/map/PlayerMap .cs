using OpenQA.Selenium;
using Selenium.Properties;

namespace Selenium.map
{
    class PlayerMap
    {
        Settings config = Settings.Default;
        private IWebDriver _webDriver;

        public PlayerMap(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public IWebElement NextButton => _webDriver.FindElement(By.CssSelector("a.ytp-next-button.ytp-button"));

        public IWebElement PlayMode => _webDriver.FindElement(By.CssSelector(".playing-mode"));

    }
}
