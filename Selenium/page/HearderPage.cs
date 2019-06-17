using System;
using System.Linq;
using OpenQA.Selenium;
using Selenium.map;

namespace Selenium.page
{
    public class HearderPage : BasePage
    {
        private IWebDriver _driver;
        private HeaderMap _headerMap;
        private Random _rand;
        public HearderPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
            _headerMap = new HeaderMap(_driver);
            _rand = new Random();
        }

        public void ClickRandomPlaylist()
        {
            WaitUntilElementExists(By.CssSelector("ytd-grid-radio-renderer.style-scope.ytd-grid-renderer"),5000);
            _headerMap.PlayList.ElementAt(_rand.Next(1)).Click();


        }
    }
}
