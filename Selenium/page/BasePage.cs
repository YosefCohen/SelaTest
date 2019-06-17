using Selenium.Properties;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenium.page
{
    public class BasePage
    {
        Settings config = Settings.Default;

        private IWebDriver _webDriver;
        private WebDriverWait _wait;

        public BasePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void GoToUrl()
        {
            _webDriver.Navigate().GoToUrl(config.youTubePath);
            _webDriver.Manage().Window.Maximize();
        }

        public void WaitUntilElementIsVisible(By by, int miliseconds = 5000)
        {
            _wait = new WebDriverWait(_webDriver, TimeSpan.FromMilliseconds(miliseconds));
            _wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
        public void WaitUntilElementInvisible(By by, int miliseconds = 5000)
        {
            _wait = new WebDriverWait(_webDriver, TimeSpan.FromMilliseconds(miliseconds));
            _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
        }
        public void WaitUntilElementToBeClickable(By by, int miliseconds = 5000)
        {
            _wait = new WebDriverWait(_webDriver, TimeSpan.FromMilliseconds(miliseconds));
            _wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public void WaitUntilElementExists(By by, int miliseconds = 5000)
        {
            _wait = new WebDriverWait(_webDriver, TimeSpan.FromMilliseconds(miliseconds));
            _wait.Until(ExpectedConditions.ElementExists(by));
        }

        public void WaitUntilUrlBeChanged(string url, int miliseconds = 5000)
        {
            _wait = new WebDriverWait(_webDriver, TimeSpan.FromMilliseconds(miliseconds));
            _wait.Until<bool>(x=> x.Url.ToLowerInvariant() != url.ToLowerInvariant());
        }

    }
}
