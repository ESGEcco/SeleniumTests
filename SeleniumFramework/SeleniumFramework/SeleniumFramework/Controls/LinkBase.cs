using OpenQA.Selenium;
using System;

namespace SeleniumFramework.SeleniumFramework.Controls
{
    public class LinkBase : BaseControl
    {
        #region Constructor
        public LinkBase(IWebElement element) : base(element)
        {

        }

        public LinkBase(IWebElement element, bool scrollIntoView = true) : base(element)
        {
            this.scrollIntoView = scrollIntoView;
        }

        public virtual void Click()
        {
            base.ClickBase();
        }

        #endregion Constructor
    }
}
