using OpenQA.Selenium;
using System;

namespace SeleniumFramework.SeleniumFramework.Controls
{
    public class JavascriptLinkNewTab<T> : LinkBase<T>
    {
        #region Constructor
        public JavascriptLinkNewTab(IWebElement element) : base(element)
        {

        }
        #endregion Constructor

        public override T Click()
        {
            SF.Helpers.Javascript.Click(element);
            SF.Driver.SwitchTo().Window(SF.Driver.WindowHandles[1]);
            SF.Driver.Manage().Window.Maximize();

            return Activator.CreateInstance<T>();
        }
    }
}
