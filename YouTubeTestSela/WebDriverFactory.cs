using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System.IO;
using YouTubeTestSela.Properties;

namespace YouTubeTestSela
{
    public class WebDriverFactory
    {
        Settings config = Settings.Default;
        string path = Directory.GetCurrentDirectory() + "..\\..\\..\\" + "drivers";

        public IWebDriver CreateInstance(string browser)
        {
            if ("Chrome".ToLower() == browser.ToLower())
            {
                var options = new ChromeOptions();
                options.AddArguments("--test-type", "--start-maximized");
                options.AddArguments("--test-type", "--ignore-certificate-errors");
                options.AddArguments("--disable-notifications");
                return new ChromeDriver(path, options);
            }
            else if ("Edge".ToLower() == browser.ToLower())
            {
                return new EdgeDriver(path);
            }
            else
            {
                return new FirefoxDriver(path);
            }
        }
    }
}
