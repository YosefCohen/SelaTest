using OpenQA.Selenium;
using Selenium.map;

namespace Selenium.page
{
    public class PlayerPage : BasePage
    {
        private IWebDriver _driver;
        private PlayerMap _playerMap;
        public PlayerPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
            _playerMap = new PlayerMap(_driver);
        }

        public bool IsSungPlay()
        {
            WaitUntilElementIsVisible(By.CssSelector(".playing-mode"),9000);
            bool isPlay = _playerMap.PlayMode.Enabled;

            return isPlay;

        }

        public void ClickOnNextButton()
        {
            string urlBefor = _driver.Url.ToLowerInvariant();
            WaitUntilElementToBeClickable(By.CssSelector("a.ytp-next-button.ytp-button"),8000);
            _playerMap.NextButton.Click();
            WaitUntilUrlBeChanged(urlBefor);
        }
        public bool IsSongChanged(string urlBefor)
        {
            if (urlBefor.ToLowerInvariant() == _driver.Url.ToLowerInvariant())
            {
                return false;
            }
            return true;
        }
    }
}
