using OpenQA.Selenium;
using System;

namespace SeleniumFramework.SeleniumFramework.Controls
{
    public class JavascriptLinkBase<T> : LinkBase
    {
        #region Constructor
        public JavascriptLinkBase(IWebElement element) : base(element)
        {

        }

        #endregion Constructor
    }
}
