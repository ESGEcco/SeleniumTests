using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Controls;
using SeleniumFramework.SeleniumFramework.Helpers;
using System.Configuration;

namespace SeleniumFramework.Pages.CertDbPages
{
    public class AddProductPage
    {
        WaitFor waitFor = new WaitFor();
        By addProductLabel = By.XPath("//h1[contains(text(), 'Add Product')]");

        public LabelBase AddProductLabel
        {
            get
            {
                IWebElement element = waitFor.Element(addProductLabel);

                return new LabelBase(element);
            }
        }

        public bool IsAddProductPageLoaded()
        {
            return AddProductLabel.Visible;
        }
    }
}
