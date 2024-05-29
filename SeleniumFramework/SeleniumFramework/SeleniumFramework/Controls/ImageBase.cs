using OpenQA.Selenium;

namespace SeleniumFramework.SeleniumFramework.Controls
{
    public class ImageBase : BaseControl
    {
        #region Constructor

        /// <summary>
        /// Base object for images
        /// </summary>
        /// <param name="element">Element containing 'src' attribute</param>
        public ImageBase(IWebElement element) : base(element)
        {

        }

        #endregion Constructor

        public bool Loaded()
        {
            return SF.Helpers.Javascript.ImageLoaded(element);
        }
    }
}
