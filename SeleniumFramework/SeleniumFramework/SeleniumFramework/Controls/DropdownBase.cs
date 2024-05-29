using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumFramework.SeleniumFramework.Helpers;

namespace SeleniumFramework.SeleniumFramework.Controls
{
    public class DropdownBase : BaseControl
    {
        WaitFor waitFor = new WaitFor();
        protected SelectElement selectElement;

        #region Constructor

        public DropdownBase(IWebElement element) : base(element)
        {
            selectElement = new SelectElement(element);
        }
        #endregion Constructor

        public void SelectByText(string text)
        {
            selectElement.SelectByText(text);
        }

        public void SelectByValue(string value)
        {
            selectElement.SelectByValue(value);

        }
    }
}
