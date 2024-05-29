using OpenQA.Selenium;
using System;

namespace SeleniumFramework.SeleniumFramework.Controls
{
    public class CheckboxLink<T> : CheckboxBase
    {
        #region Constructor

        public CheckboxLink(IWebElement element) : base(element)
        {

        }

        #endregion Constructor


        public new T Check()
        {
            base.Check();
            SF.Helpers.WaitFor.Load();
            return Activator.CreateInstance<T>();
        }

        public new T Uncheck()
        {
            base.Uncheck();
            SF.Helpers.WaitFor.Load();
            return Activator.CreateInstance<T>();
        }
    }
}
