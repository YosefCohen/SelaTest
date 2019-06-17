using OpenQA.Selenium;
using Selenium.map;

namespace Selenium.page
{
    public class LogInPage : BasePage
    {
        private LogInMap _logInMap;
        private IWebDriver _driver;
        public LogInPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
            _logInMap = new LogInMap(_driver);
        }

        public void EnterEmailToFild(string email, string password)
        {
            WaitUntilElementIsVisible(By.CssSelector("#identifierId.whsOnd.zHQkBf"), 5000);
            _logInMap.EmailFild.SendKeys(email);
            _logInMap.EmailNextButton.Click();
            WaitUntilElementIsVisible(By.CssSelector("[type='password'].whsOnd.zHQkBf"), 5000);
            _logInMap.PasswordFild.Clear();
            _logInMap.PasswordFild.SendKeys(password);
            _logInMap.PasswordNextButton.Click();
        }

            


    }
}
