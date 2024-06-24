using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Controls;
using SeleniumFramework.SeleniumFramework.Helpers;

namespace SeleniumFramework.Pages.CertDbPages
{
    public class EditProductDuplicateProductPage
    {
        #region ControlDefinitions

        WaitFor waitFor = new WaitFor();
        By areYouSureLabel = By.XPath("//span[contains(text(), 'Are you sure?')]");
        By duplicateProductDialogueLabel = By.Id("duplicateProductDialog");
        By confirmButton = By.XPath("//button[contains(text(), 'Confirm')]");
        By cancelButton = By.XPath("//button[contains(text(), 'Cancel')]");

        #endregion ControlDefinitions

        #region ControlInstantiations

        public LabelBase AreYouSureLabel
        {
            get
            {
                IWebElement element = waitFor.Element(areYouSureLabel);

                return new LabelBase(element);
            }
        }

        public LabelBase DuplicateProductDialogueLabel
        {
            get
            {
                IWebElement element = waitFor.Element(duplicateProductDialogueLabel);

                return new LabelBase(element);
            }
        }

        public ButtonBase ConfirmButton
        {
            get
            {
                IWebElement element = waitFor.Element(confirmButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase CancelButton
        {
            get
            {
                IWebElement element = waitFor.Element(cancelButton);

                return new ButtonBase(element);
            }
        }

        #endregion ControlInstantiations

        public bool IsDuplicateProductTitleVisible()
        {
            AreYouSureLabel.WaitForVisible();
            
            return AreYouSureLabel.Visible;
        }
    }
}
