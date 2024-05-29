using OpenQA.Selenium;
using System;
using System.Diagnostics;
using System.Threading;

namespace SeleniumFramework.SeleniumFramework.Controls
{
    public class BaseControl
    {
        protected IWebElement element;
        protected bool scrollIntoView;
        #region Constructor

        public BaseControl(IWebElement element)
        {
            this.element = element;
        }

        public BaseControl(IWebElement element, bool scrollIntoView = true)
        {
            this.element = element;
            this.scrollIntoView = scrollIntoView;
        }

        #endregion Constructor

        public bool Visible
        {
            get
            {
                return element.Displayed;
            }
        }

        public void WaitForVisible(int secondsToWait = 30)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            if (!Visible && watch.Elapsed.TotalSeconds < secondsToWait)
            {
                Thread.Sleep(1000);
            }

            if (!Visible)
            {
                throw new Exception("Element did not become visible after: " + secondsToWait + " seconds");
            }
        }

        public bool Enabled
        {
            get
            {
                return element.Enabled;
            }
        }

        public void WaitForEnabled(int secondsToWait = 30)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            if (!Enabled && watch.Elapsed.TotalSeconds < secondsToWait)
            {
                Thread.Sleep(1000);
            }

            if (!Visible)
            {
                throw new Exception("Element did not become visible after: " + secondsToWait + " seconds");
            }
        }

        public void WaitForClickable()
        {
            SF.Helpers.Javascript.ScrollIntoView(element);
            WaitForVisible();
            WaitForEnabled();
        }

        public virtual string Text
        {
            get
            {
                string retval = element.Text;

                if (retval == null || retval == string.Empty)
                {
                    retval = element.GetAttribute("value");
                }

                return retval;
            }
            set
            {
                WaitForClickable();
                this.ClickBase();
                element.Clear();
                element.SendKeys(Keys.Home);
                element.SendKeys(value);
            }
        }

        /// <summary>
        /// Clicks the element 
        /// </summary>
        protected virtual void ClickBase()
        {
            SF.Helpers.Javascript.ScrollIntoView(element);
            SF.Helpers.WaitFor.Clickable(element);
            TryClick(element, 0, 3);
            SF.Helpers.WaitFor.Load();
        }

        private void TryClick(IWebElement element, int currentRetries, int totalRetries)
        {
            if (currentRetries < totalRetries)
            {
                try
                {
                    element.Click();
                }
                catch (WebDriverException)  //Some dropdowns don't disappear right away blocking the element from being clicked.  This should fix the issue.
                {
                    currentRetries++;
                    Thread.Sleep(500);
                    TryClick(element, totalRetries, currentRetries);
                }
            }
        }

        /// <summary>
        /// Clicks the element 
        /// </summary>
        protected virtual void ClickBaseWithoutWait()
        {
            SF.Helpers.Javascript.ScrollIntoView(element);
            element.Click();
        }
    }
}
