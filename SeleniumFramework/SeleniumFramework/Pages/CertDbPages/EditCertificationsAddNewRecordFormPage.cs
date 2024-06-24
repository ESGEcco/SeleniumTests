using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Controls;
using SeleniumFramework.SeleniumFramework.Helpers;

namespace SeleniumFramework.Pages.CertDbPages
{
    public class EditCertificationsAddNewRecordFormPage
    {
        #region ControlDefinitions

        WaitFor waitFor = new WaitFor();
        By editFormTitleLabel = By.XPath("//span[contains(text(), 'Edit')]");
        By passedCheckbox = By.Id("HasPassed");
        By certificationTypeDropdown = By.XPath("//span[contains(@aria-controls, 'CertificationType_listbox')]");
        By testCertificationsDropdown = By.XPath("//span[contains(@aria-controls, 'CertificationList_listbox')]");
        By testReportDropdown = By.XPath("//span[contains(@aria-controls, 'ReportList_listbox')]");
        By editCommentTextbox = By.Id("Comment");
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

        public CheckboxBase PassedCheckbox
        {
            get
            {
                IWebElement element = waitFor.Element(passedCheckbox);

                return new CheckboxBase(element);
            }
        }

        public DropdownBase CertificationTypeCombobox
        {
            get
            {
                IWebElement element = waitFor.Element(certificationTypeDropdown);

                return new DropdownBase(element);
            }
        }

        public DropdownBase TestCertificationsCombobox
        {
            get
            {
                IWebElement element = waitFor.Element(testCertificationsDropdown);

                return new DropdownBase(element);
            }
        }

        public DropdownBase TestReportDropdown
        {
            get
            {
                IWebElement element = waitFor.Element(testReportDropdown);

                return new DropdownBase(element);
            }
        }

        public TextboxBase EditCommentTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(editCommentTextbox);

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
