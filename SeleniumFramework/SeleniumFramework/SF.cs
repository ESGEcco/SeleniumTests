using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using SeleniumFramework.SeleniumFramework.Enums;
using SeleniumFramework.SeleniumFramework.Helpers;
using System;
using System.Configuration;

namespace SeleniumFramework
{
    public class SF
    {
        private static IWebDriver driver = null;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    TimeSpan pageLoadTimeout = TimeSpan.FromSeconds(60);
                    Browser browser = GetBrowserFromRunSettings();

                    driver = GetDriver(browser);
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().PageLoad = pageLoadTimeout;
                }
                return driver;
            }
            set
            {
                driver = value;
            }
        }

        public static OpenSites OpenSites
        {
            get
            {
                return new OpenSites(Driver);
            }
        }

        public static HelpersBase Helpers
        {
            get
            {
                return new HelpersBase();
            }
        }

        private static Browser GetBrowserFromRunSettings()
        {
            AppSettingsReader appSettings = new AppSettingsReader();
            string browserAsString = (string)appSettings.GetValue("browser", typeof(string));

            browserAsString = browserAsString.Replace(" ", "").ToUpper();

            Browser retval;
            switch (browserAsString)
            {
                case "CHROME":
                    retval = Browser.Chrome;
                    break;
                case "FF":
                case "FIREFOX":
                    retval = Browser.FireFox;
                    break;
                case "EDGE":
                    retval = Browser.Edge;
                    break;
                default:
                    throw new ApplicationException("Unsupported web driver browser requested.");
            }

            return retval;
        }

        private static IWebDriver GetDriver(Browser browser)
        {
            IWebDriver retval;

            switch (browser)
            {
                case Browser.Chrome:
                    ChromeOptions chromeOptions = new ChromeOptions();

                    chromeOptions.AddArgument("headless");
                    chromeOptions.AddArgument("start-maximized"); // https://stackoverflow.com/a/26283818/1689770
                    chromeOptions.AddArgument("--no-sandbox"); //https://stackoverflow.com/a/50725918/1689770
                    chromeOptions.AddArgument("--disable-infobars"); //https://stackoverflow.com/a/43840128/1689770
                    chromeOptions.AddArgument("--disable-dev-shm-usage"); //https://stackoverflow.com/a/50725918/1689770
                    chromeOptions.AddArgument("--disable-browser-side-navigation"); //https://stackoverflow.com/a/49123152/1689770
                    chromeOptions.AddArgument("--disable-gpu"); //https://stackoverflow.com/questions/51959986/how-to-solve-selenium-chromedriver-timed-out-receiving-message-from-renderer-exc
                    chromeOptions.AddArguments("--incognito");
                    retval = new ChromeDriver(chromeOptions);
                    break;
                case Browser.FireFox:
                    FirefoxOptions options = new FirefoxOptions();
                    options.Profile = new FirefoxProfile();
                    options.AcceptInsecureCertificates = true;
                    retval = new FirefoxDriver(options);
                    break;
                case Browser.Edge:
                    retval = new EdgeDriver();
                    break;
                default:
                    throw new ApplicationException("Unsupported web driver browser requested by Config.cs");
            }
            return retval;
        }
    }
}
