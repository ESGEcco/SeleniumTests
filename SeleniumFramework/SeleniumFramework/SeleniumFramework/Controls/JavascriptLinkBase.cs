using OpenQA.Selenium;
using System;

namespace SeleniumFramework.SeleniumFramework.Controls
{
    public class JavascriptLinkBase<T> : LinkBase<T>
    {
        #region Constructor
        public JavascriptLinkBase(IWebElement element) : base(element)
        {

        }

        #endregion Constructor

        public override T Click()
        {
            SF.Helpers.Javascript.Click(element);
            SF.Helpers.WaitFor.Load();

            return Activator.CreateInstance<T>();
        }
    }
}
