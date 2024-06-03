using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Controls;
using SeleniumFramework.SeleniumFramework.Helpers;
using System.Configuration;

namespace SeleniumFramework.Pages.CertDbPages
{
    public class EditProductPage
    {
        WaitFor waitFor = new WaitFor();
        By titleLabel = By.XPath("//h1[contains(text(), 'Edit Product')]");

        public LabelBase TitleLabel
        {
            get
            {
                IWebElement element = waitFor.Element(titleLabel);

                return new LabelBase(element);
            }
        }

        public bool IsEditProductPageTitle()
        {
            return TitleLabel.Visible;
        }
    }
}
