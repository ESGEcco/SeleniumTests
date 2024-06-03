using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Controls;
using SeleniumFramework.SeleniumFramework.Helpers;
using System.Configuration;

namespace SeleniumFramework.Pages.CertDbPages
{
    public class PrivacyPage
    {
        WaitFor waitFor = new WaitFor();
        By privacyPolicyTitle = By.XPath("//h1[contains(text(), 'Privacy Policy')]");

        public LabelBase PrivacyPolicyTitle
        {
            get
            {
                IWebElement element = waitFor.Element(privacyPolicyTitle);

                return new LabelBase(element);
            }
        }

        public bool IsPrivacyPolicyPageLoaded()
        {
            return PrivacyPolicyTitle.Visible;
        }
    }
}
