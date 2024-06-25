using OpenQA.Selenium;
using System;
using System.Threading;

namespace SeleniumFramework.SeleniumFramework.Helpers
{
    public class JavascriptHelpers
    {
        private IWebDriver Driver = SF.Driver;

        public IAlert WaitForAlert()
        {
            IAlert retval = null;
            int timeout = 10;
            bool foundAlert = false;

            OpenQA.Selenium.Support.UI.IWait<IWebDriver> wait =
                new OpenQA.Selenium.Support.UI.WebDriverWait(Driver, TimeSpan.FromSeconds(timeout));
            wait.Until(driver =>
            {
                try
                {
                    retval = driver.SwitchTo().Alert();
                    foundAlert = true;
                }
                catch (Exception)
                {
                    Thread.Sleep(500);
                }
                return foundAlert;
            });

            return retval;
        }

        public bool IsAlertPresent()
        {
            bool retval = false;

            try
            {
                Driver.SwitchTo().Alert();
                retval = true;
            }
            catch (Exception)
            {
                retval = false;
            }
            return retval;
        }

        public void Click(IWebElement element)
        {
            IJavaScriptExecutor javaScriptExecutor = Driver as IJavaScriptExecutor;
            javaScriptExecutor.ExecuteScript("arguments[0].click();", element);
            WaitFor waitFor = new WaitFor();
            waitFor.Load();
        }

        public void SwitchToReportsTab()
        {
            IJavaScriptExecutor javaScriptExecutor = Driver as IJavaScriptExecutor;
            javaScriptExecutor.ExecuteScript("RibbonNavigation.SetActiveTab(RibbonNavigation.GetTabByName('Reports'))");
            WaitFor waitFor = new WaitFor();
            waitFor.Load();
        }

        /// <summary>
        /// Waits for ajax calls to finish and spinner to disappear
        /// 
        /// Note:  This should be in a separate class
        /// </summary>
        /// <param name="secondsToWait">Amount of time to wait for ajax and spinner to finish</param>
        public void WaitForAjaxToComplete(int secondsToWait = 30)
        {
            bool isAjaxFinished = false;
            bool isLoaderHidden = false;

            OpenQA.Selenium.Support.UI.IWait<IWebDriver> wait =
                new OpenQA.Selenium.Support.UI.WebDriverWait(Driver, TimeSpan.FromSeconds(secondsToWait));
            wait.Until(driver =>
            {
                try
                {
                    bool jQueryDefined = (bool)((IJavaScriptExecutor)driver).
                            ExecuteScript("return window.jQuery != undefined");
                    if (!jQueryDefined)
                    {
                        isAjaxFinished = true;
                        isLoaderHidden = true;
                    }
                    else
                    {
                        isAjaxFinished = (bool)((IJavaScriptExecutor)driver).
                            ExecuteScript("return jQuery.active == 0");
                        isLoaderHidden = (bool)((IJavaScriptExecutor)driver).
                            ExecuteScript("return $('.spinner').is(':visible') == false");
                    }
                }
                catch
                {
                    Thread.Sleep(100);
                }

                return isAjaxFinished & isLoaderHidden;
            });
        }

        /// <summary>
        /// Waits for spinner to finish
        /// 
        /// </summary>
        /// <param name="secondsToWait"></param>
        public void WaitForSpinner(int secondsToWait = 10)
        {
            bool isLoaderHidden = false;

            OpenQA.Selenium.Support.UI.IWait<IWebDriver> wait =
                new OpenQA.Selenium.Support.UI.WebDriverWait(Driver, TimeSpan.FromSeconds(30.00));
            wait.Until(driver =>
            {
                try
                {
                    isLoaderHidden = (bool)((IJavaScriptExecutor)driver).
                        ExecuteScript("return $('.spinner').is(':visible') == false");
                }
                catch (Exception)
                {
                    Thread.Sleep(100);
                }

                return isLoaderHidden;
            });
        }

        public string GetAlertText()
        {
            //WaitForAlert();
            return Driver.SwitchTo().ActiveElement().Text;
        }

        public void AcceptAlert()
        {
            AcceptAlert(false);
        }

        public void AcceptAlert(bool closeIframe)
        {
            IAlert alert = Driver.SwitchTo().Alert();
            alert.Accept();
            WaitForAjaxToComplete();  //If in an iframe we need to wait for the Iframe to finish processing

            if (closeIframe)
            {
                //driver.SwitchToDefaultWindow();
                WaitForAjaxToComplete();
            }
        }

        public void DismissAlert()
        {
            IAlert alert = Driver.SwitchTo().Alert();
            alert.Dismiss();
            WaitForAjaxToComplete();
        }

        public void ScrollIntoView(IWebElement element)
        {
            IJavaScriptExecutor javaScriptExecutor = Driver as IJavaScriptExecutor;
            javaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public bool ImageLoaded(IWebElement element)
        {
            Object result = ((IJavaScriptExecutor)Driver).ExecuteScript(
               "return arguments[0].complete && " +
               "typeof arguments[0].naturalWidth != \"undefined\" && " +
               "arguments[0].naturalWidth > 0", element);

            return (Boolean)result;
        }
    }
}
