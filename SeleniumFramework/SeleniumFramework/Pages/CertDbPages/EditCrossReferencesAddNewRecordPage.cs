using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Controls;
using SeleniumFramework.SeleniumFramework.Helpers;

namespace SeleniumFramework.Pages.CertDbPages
{
    public class EditCrossReferencesAddNewRecordPage
    {
        #region ControlDefinitions

        WaitFor waitFor = new WaitFor();
        By editFormTitleLabel = By.XPath("//span[contains(text(), 'Edit')]");
        By crossReferencesRegionDropdown = By.XPath("//span[contains(@aria-controls, 'Region_listbox')]");
        By partIdTextbox = By.Id("RegionPartId");
        By productLineTextbox = By.Id("ProductLine");
        By statusTextbox = By.Id("Status");
        By editSaveButton = By.XPath("//span[contains(text(), 'Save')]");
        By editCancelButton = By.XPath("//span[contains(text(), 'Cancel')]");

        #endregion ControlDefinitions

        #region ControlInstantiations

        public LabelBase EditFormTitleLabel
        {
            get
            {
                IWebElement element = waitFor.Element(editFormTitleLabel);

                return new LabelBase(element);
            }
        }

        public DropdownBase CrossReferencesRegionDropdown
        {
            get
            {
                IWebElement element = waitFor.Element(crossReferencesRegionDropdown);

                return new DropdownBase(element);
            }
        }

        public TextboxBase PartIdTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(partIdTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase ProductLineTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(productLineTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase StatusTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(statusTextbox);

                return new TextboxBase(element);
            }
        }

        public ButtonBase EditSaveButton
        {
            get
            {
                IWebElement element = waitFor.Element(editSaveButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase EditCancelButton
        {
            get
            {
                IWebElement element = waitFor.Element(editCancelButton);

                return new ButtonBase(element);
            }
        }

        #endregion ControlInstantiations

        public bool IsEditAddNewRecordFormDisplayed()
        {
            return EditFormTitleLabel.Visible;
        }
    }
}
