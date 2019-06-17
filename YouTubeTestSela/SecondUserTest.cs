using System;
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
        private TestContext testContext;
        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }

        [TestInitialize]
        public void TestInitialize()
        {
            _driver = factory.CreateInstance(config.Browser);
            _pageFacade = new PageFacade(_driver);
            _pageFacade.topBarPage.GoToUrl();
            _pageFacade.topBarPage.MakeLogIn();
            _pageFacade.logInPage.EnterEmailToFild(config.Name2, config.Password2);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _driver.Close();
            Console.WriteLine(TestContext.TestName + " " + TestContext.CurrentTestOutcome);
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
            Assert.IsTrue(_pageFacade.resultPage.CheckIfBottonWatchingLaterExist());
        }

    }
}
