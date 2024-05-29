using OpenQA.Selenium;

namespace SeleniumFramework.SeleniumFramework.Controls
{
    public class JavascriptBaseControl : BaseControl
    {
        #region Constructor

        public JavascriptBaseControl(IWebElement element) : base(element)
        {
        }

        #endregion Constructor

        protected override void ClickBase()
        {
            SF.Helpers.Javascript.Click(element);
            SF.Helpers.WaitFor.Load();
        }
    }
}
