using OpenQA.Selenium;
using SeleniumFramework.Pages.CertDbPages;
using SeleniumFramework.Pages.LightbarBuilder;
using System.Configuration;

namespace SeleniumFramework
{
    public class OpenSites
    {
        private AppSettingsReader appSettings = new AppSettingsReader();
        IWebDriver driver;

        public OpenSites(IWebDriver driver)
        {
            this.driver = driver;
        }
                
        public LoginPage OpenCertDB()
        {
            string baseURL = (string)appSettings.GetValue("CertDbLaunchUrl", typeof(string));

            driver.Navigate().GoToUrl(baseURL);

            return new LoginPage();
        }

        public ProductPage OpenCertDBToProductPage()
        {
            string baseURL = (string)appSettings.GetValue("CertDbProductPage", typeof(string));

            driver.Navigate().GoToUrl(baseURL);

            return new ProductPage();
        }

        public LbbLoginPage OpenLightbarBuilder()
        {
            string baseURL = (string)appSettings.GetValue("LbbLaunchUrl", typeof(string));

            driver.Navigate().GoToUrl(baseURL);

            return new LbbLoginPage();
        }
    }
}
