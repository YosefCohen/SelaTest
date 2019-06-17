using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Selenium.map;

namespace Selenium.page
{
    public class ResultPage : BasePage
    {
        private IWebDriver _driver;
        private ResultMap _resultMap;
        private Random _rand;
        private Actions _action;
        public ResultPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
            _resultMap = new ResultMap(_driver);
            _rand = new Random();
            _action = new Actions(_driver);

        }

        public void PlaySongFromeResultByIndex(int index)
        {
            WaitUntilElementIsVisible(By.CssSelector("ytd-video-renderer.style-scope.ytd-item-section-renderer"), 5000);
           List<IWebElement> resultList = _resultMap.Result.ToList();
            resultList[index].Click();
        }

        public bool PlaySungFromeResultByNameContain(string specificSong)
        {
            WaitUntilElementIsVisible(By.CssSelector("ytd-video-renderer.style-scope.ytd-item-section-renderer"), 5000);
            List<IWebElement> resultList = _resultMap.Result.ToList();
            foreach (var item in resultList)
            {
                string str = item.Text.ToLower();
                if (item.Text.ToLower().Contains(specificSong.ToLower()))
                {
                    item.Click();
                    return true;
                }
            }
            return false;
        }

        public bool CheckIfBottonWatchingLaterExist()
        {
            WaitUntilElementIsVisible(By.CssSelector("ytd-grid-video-renderer.style-scope.ytd-grid-renderer"), 5000);
            IWebElement randomResult = _resultMap.defaultResults.ElementAt(_rand.Next(10));
            _action.MoveToElement(randomResult).Perform();
            bool IsWatchingLaterEnabled = _resultMap.WatchingLaterBotton.Enabled;
            return IsWatchingLaterEnabled;
        }
    }
}
