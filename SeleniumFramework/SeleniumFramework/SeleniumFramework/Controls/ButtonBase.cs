using OpenQA.Selenium;

namespace SeleniumFramework.SeleniumFramework.Controls
{
    public class ButtonBase : BaseControl
    {
        #region Constructor

        public ButtonBase(IWebElement element) : base(element)
        {

        }

        #endregion Constructor

        public void Click()
        {
            base.ClickBase();
        }
    }
}
