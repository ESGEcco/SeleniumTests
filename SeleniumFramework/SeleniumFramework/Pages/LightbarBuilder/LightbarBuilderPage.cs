using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Controls;
using SeleniumFramework.SeleniumFramework.Helpers;

namespace SeleniumFramework.Pages.LightbarBuilder
{    
    public class LightbarBuilderPage
    {
        WaitFor waitFor = new WaitFor();
        By requestQuoteButton = By.Id("requestQuote");


        public ButtonBase RequestQuoteButton
        {
            get
            {
                IWebElement element = waitFor.Element(requestQuoteButton);

                return new ButtonBase(element);
            }
        }

        public bool IsQuoteButtonVisible()
        {
            return RequestQuoteButton.Visible;
        }
    }
}
