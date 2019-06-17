using OpenQA.Selenium;
using Selenium.map;

namespace Selenium.page
{
    public class TopBarPage : BasePage
    {
        private TopBarMap _topBarMap;
        private IWebDriver _driver;
        public TopBarPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
            _topBarMap = new TopBarMap(_driver);
        }

        public void clickOnBottonMenu()
        {
            WaitUntilElementToBeClickable(By.CssSelector
                ("div[id='container']>yt-icon-button>button > yt-icon[id='guide-icon']"));
            _topBarMap.menuButton.Click();
        }
        public void SearchWord(string searchWord)
        {
            WaitUntilElementIsVisible(By.CssSelector(" input[id = 'search']"));
            _topBarMap.SearchLine.SendKeys(searchWord);
            _topBarMap.SearchButton.Click();
        }

        public void MakeLogIn()
        {
            _topBarMap.LogInButton.Click();
        }
    }
}
