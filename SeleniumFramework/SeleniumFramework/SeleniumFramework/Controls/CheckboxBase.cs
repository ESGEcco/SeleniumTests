using OpenQA.Selenium;

namespace SeleniumFramework.SeleniumFramework.Controls
{
    public class CheckboxBase : BaseControl
    {
        #region Constructor

        public CheckboxBase(IWebElement element) : base(element)
        {

        }

        #endregion Constructor

        public bool IsChecked
        {
            get
            {
                bool retval = element.Selected;

                if (!retval)
                    if (element.GetAttribute("class").Contains("checked")) //some checkboxes have the "check" in the class
                        retval = true;

                return retval;
            }
        }

        public void Check()
        {
            if (!IsChecked)
            {
                SF.Helpers.WaitFor.Clickable(element);
                base.ClickBase();
                SF.Helpers.WaitFor.Load();
            }
        }

        public void Uncheck()
        {
            if (IsChecked)
            {
                SF.Helpers.WaitFor.Clickable(element);
                base.ClickBase();
                SF.Helpers.WaitFor.Load();
            }
        }
    }
}
