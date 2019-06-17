using OpenQA.Selenium;
using System.Collections.Generic;

namespace Selenium.map
{
    class ResultMap
    {
        private IWebDriver _driver;

        public ResultMap(IWebDriver webDriver)
        {
            _driver = webDriver;
        }

        public IWebElement menuButton => _driver.FindElement(By.CssSelector
                                     ("div[id='container']>yt-icon-button>button > yt-icon[id='guide-icon']"));

        public IEnumerable<IWebElement> Result => _driver.FindElements(By.CssSelector
                                                 ("ytd-video-renderer.style-scope.ytd-item-section-renderer"));

        public IEnumerable<IWebElement> defaultResults => _driver.FindElements(By.CssSelector
                                                    ("ytd-grid-video-renderer.style-scope.ytd-grid-renderer"));

        public IWebElement WatchingLaterBotton => _driver.FindElement(By.CssSelector
                                               ("ytd-thumbnail-overlay-toggle-button-renderer"));
    }
}
