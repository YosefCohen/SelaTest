using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Properties;

namespace Selenium.map
{
    public class LogInMap
    {
        private IWebDriver _webDriver;

        public LogInMap(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public IWebElement EmailFild => _webDriver.FindElement(By.CssSelector("#identifierId.whsOnd.zHQkBf"));

        public IWebElement EmailNextButton => _webDriver.FindElement(By.CssSelector("#identifierNext"));

        public IWebElement PasswordFild => _webDriver.FindElement(By.CssSelector("[type='password'].whsOnd.zHQkBf"));

        public IWebElement PasswordNextButton => _webDriver.FindElement(By.CssSelector("#passwordNext")); 


    }

}
