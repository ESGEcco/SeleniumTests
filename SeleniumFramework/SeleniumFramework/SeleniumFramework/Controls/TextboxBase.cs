using OpenQA.Selenium;
using System.Threading;

namespace SeleniumFramework.SeleniumFramework.Controls
{
    public class TextboxBase : BaseControl
    {
        #region Constructor

        public TextboxBase(IWebElement element) : base(element)
        {

        }

        #endregion Constructor

        /// <summary>
        /// Types each key individually instead of sending all keys together.
        /// </summary>
        public void TypeKeys(string keysToPress, int millisecondsBetweenKeys = 10)
        {
            int numberOfKeys = keysToPress.Length;

            for (int i = 0; i < numberOfKeys; i++)
            {
                element.SendKeys(keysToPress[i].ToString());
                Thread.Sleep(millisecondsBetweenKeys);
            }
        }
    }
}
