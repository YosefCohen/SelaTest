using OpenQA.Selenium;

namespace Selenium.page
{
    public class PageFacade
    {
        private IWebDriver _driver;
        public HearderPage hearderPage;
        public TopBarPage topBarPage;
        public LogInPage logInPage;
        public ResultPage resultPage;
        public PlayerPage playerPage;
        public MenuPage menuPage;
        public PageFacade(IWebDriver driver)
        {
            _driver = driver;
            hearderPage = new HearderPage(_driver);
            topBarPage = new TopBarPage(_driver);
            logInPage = new LogInPage(_driver);
            resultPage = new ResultPage(_driver);
            playerPage = new PlayerPage(_driver);
            menuPage = new MenuPage(_driver);
        }
    }
}
