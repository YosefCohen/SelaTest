using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Selenium.page;
using System;
using YouTubeTestSela.Properties;

namespace YouTubeTestSela
{
    [TestClass]
    public class FirstUserTest
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
            _pageFacade.logInPage.EnterEmailToFild(config.Name1, config.Password1);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _driver.Close();
            Console.WriteLine(TestContext.TestName + " " + TestContext.CurrentTestOutcome);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "..\\..\\songs.csv", "songs#csv", DataAccessMethod.Sequential)]
        public void FirstTest_CheckIfSongPlaying()
        {
            _pageFacade.topBarPage.SearchWord(TestContext.DataRow["song"].ToString());
            _pageFacade.resultPage.PlaySongFromeResultByIndex(2);
            Assert.IsTrue(_pageFacade.playerPage.IsSungPlay());
        }

        [TestMethod]
        public void ThirdTest_CheckingSpecificSongSelection()
        {
            _pageFacade.topBarPage.SearchWord(config.SongName);
            bool isSOngFound = _pageFacade.resultPage.PlaySungFromeResultByNameContain(config.SpecificSong);
            Assert.IsTrue(isSOngFound, "The song not found in list result");
        }
    }
}
