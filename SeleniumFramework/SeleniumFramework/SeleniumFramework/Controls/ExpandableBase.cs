using OpenQA.Selenium;
using System.Diagnostics;
using System.Threading;

namespace SeleniumFramework.SeleniumFramework.Controls
{
    public class ExpandableBase
    {
        protected By locator;
        protected IWebElement element
        {
            get
            {
                IWebElement element = SF.Helpers.WaitFor.Element(locator);

                return element;
            }
        }

        #region Constructor

        public ExpandableBase()
        {

        }

        public ExpandableBase(By locator)
        {
            this.locator = locator;
        }

        #endregion Constructor

        /// <summary>
        /// Checks to see if element is expanded.  May need overidden.
        /// </summary>
        /// <returns></returns>
        public virtual bool IsExpanded()
        {
            bool retval = false;
            bool selected;
            bool expanded;

            bool.TryParse(element.GetAttribute("aria-selected"), out selected);
            bool.TryParse(element.GetAttribute("aria-expanded"), out expanded);

            if (selected || expanded)
            {
                retval = true;
            }

            return retval;
        }

        /// <summary>
        /// Expands the element
        /// </summary>
        public void Expand()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            if (!IsExpanded()) //Don't want to sleep on the first click
            {
                SF.Helpers.Javascript.ScrollIntoView(element);
                element.Click();
                SF.Helpers.WaitFor.Load();
            }
        }

        /// <summary>
        /// Collapses the element
        /// </summary>
        public void Collapse()
        {
            if (IsExpanded())
            {
                SF.Helpers.Javascript.ScrollIntoView(element);
                element.Click();
            }
            SF.Helpers.WaitFor.Load();
        }

        public void WaitForVisible()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            while (!Visible() && watch.Elapsed.TotalSeconds < 30)
            {
                Thread.Sleep(1000);
            }

            watch.Stop();
            watch.Reset();
        }

        public bool Visible()
        {
            return element.Displayed;
        }
    }
}
