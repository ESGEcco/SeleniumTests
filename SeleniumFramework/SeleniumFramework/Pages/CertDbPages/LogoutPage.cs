using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Controls;
using SeleniumFramework.SeleniumFramework.Helpers;
using System.Configuration;

namespace SeleniumFramework.Pages.CertDbPages
{
    public class LogoutPage
    {
        #region ControlDefinitions

        WaitFor waitFor = new WaitFor();
        By logoutLabel = By.XPath("//h1[contains(text(), 'Logout')]");

        #endregion ControlDefinitions

        #region ControlInstantiations

        public LabelBase LogoutLabel
        {
            get
            {
                IWebElement element = waitFor.Element(logoutLabel);

                return new LabelBase(element);
            }
        }

        #endregion ControlInstantiations

        public bool IsLogoutLabelDisplayed()
        {
            return LogoutLabel.Visible;
        }
    }
}
