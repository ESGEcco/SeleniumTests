using OpenQA.Selenium;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace SeleniumFramework.SeleniumFramework.Controls
{
    public class LinkNewTab<T> : LinkBase<T>
    {
        #region Constructor
        public LinkNewTab(IWebElement element) : base(element)
        {

        }
        #endregion Constructor

        public override T Click()
        {
            var handles = SF.Driver.WindowHandles.ToList();
            int numberOfHandles = handles.Count;
            this.ClickBaseWithoutWait();

            Stopwatch watch = new Stopwatch();
            watch.Start();

            while (numberOfHandles == handles.Count && watch.Elapsed.TotalSeconds < 30)
            {
                Thread.Sleep(1000);
                handles = SF.Driver.WindowHandles.ToList();
            }

            watch.Stop();

            SF.Driver.SwitchTo().Window(SF.Driver.WindowHandles.Last());
            SF.Driver.Manage().Window.Maximize();
            SF.Helpers.WaitFor.Load(5);

            return Activator.CreateInstance<T>();
        }
    }
}
