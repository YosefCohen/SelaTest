using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Selenium.page;
using YouTubeTestSela.Properties;

namespace YouTubeTestSela
{
    [TestClass]
    public class SecondUserTest
    {
        Settings config = Settings.Default;
        WebDriverFactory factory = new WebDriverFactory();
        IWebDriver _driver;
        private PageFacade _pageFacade;

        [TestInitialize]
        public void TestInitialize()
        {
            /*
            _driver = factory.CreateInstance(config.Browser);
            _pageFacade = new PageFacade(_driver);
            _pageFacade.topBarPage.GoToUrl();
            _pageFacade.topBarPage.MakeLogIn();
            _pageFacade.logInPage.EnterEmailToFild(config.Name2, config.Password2);
            */

        }
        [TestCleanup]
        public void TestCleanup()
        {
            /*
            _driver.Close();
            */
        }


        [TestMethod]
        public void SecondTest_ChecksCheangeSongInPlaylist()
        {
            _pageFacade.menuPage.ClickOnHeaderButton();
            _pageFacade.hearderPage.ClickRandomPlaylist();
            Thread.Sleep(5000);
            string url = _driver.Url.ToLowerInvariant();
            _pageFacade.playerPage.ClickOnNextButton();
            Assert.IsTrue(_pageFacade.playerPage.IsSongChanged(url));
        }

        [TestMethod]
        public void FourthTest_CheckIfWatchLaterShow()
        {
            Console.WriteLine(  "ddsfsdfsdfsd");
            Assert.IsTrue(_pageFacade.resultPage.CheckIfBottonWatchingLaterExist());
        }

        [TestMethod]
        public void babab()
        {
            Console.WriteLine("ddsfsdfsdfsd");
            Trace.WriteLine("second");
            Assert.IsTrue(true);
                }

    }
}
