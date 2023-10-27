using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpAuto
{
    class BasePage
    {
        public static IWebDriver driver;

        public static void SeleniumInit(string browser)
        {
            if (string.IsNullOrEmpty(browser))
            {
                throw new ArgumentException($"'{nameof(browser)}' cannot be null or empty.", nameof(browser));
            }

            if (browser.Equals(BrowserOptions.Chrome, StringComparison.OrdinalIgnoreCase))
            {
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArguments("--start-maximized");
                chromeOptions.AddArguments("--incognito");

                IWebDriver chromeDriver = new ChromeDriver(chromeOptions);
                driver = chromeDriver;
            }
            else if (browser.Equals(BrowserOptions.FireFox, StringComparison.OrdinalIgnoreCase))
            {
                var firefoxOptions = new FirefoxOptions();
                firefoxOptions.AddArguments("");

                driver = new FirefoxDriver(firefoxOptions);
            }
            else if (browser.Equals(BrowserOptions.IE, StringComparison.OrdinalIgnoreCase))
            {

            }
            else if (browser.Equals(BrowserOptions.Edge, StringComparison.OrdinalIgnoreCase))
            {
                //driver = new MicrosoftEdgeDriver();
            }
            else
            {
                throw new Exception("Incorrect browser name specified!");
            }
        }


    }

    public static class BrowserOptions
    {
        public const string
            Chrome = "Chrome",
            FireFox = "FireFox",
            IE = "InternetExplorer",
            Edge = "MicrosoftEdge";

    }
}
