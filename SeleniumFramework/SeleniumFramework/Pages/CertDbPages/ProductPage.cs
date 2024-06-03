using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Controls;
using SeleniumFramework.SeleniumFramework.Helpers;
using System.Configuration;

namespace SeleniumFramework.Pages.CertDbPages
{
    public class ProductPage
    {
        WaitFor waitFor = new WaitFor();
        By titleLabel = By.Id("title");
        By addNewProductButton = By.Id("addProductButton");
        By optionsHeaderSection = By.ClassName("expansion-panel-section");
        By groupSectionLabel = By.XPath("//p[contains(text(), 'Group Options')]");
        By groupOptionsDropdown = By.ClassName("k-input-inner");
        By clearAllFiltersButton = By.XPath("//button[contains(text(), 'Clear all Filters')]");
        By searchByPartIdTextbox = By.XPath("//span[contains(title, 'Search by PartId')]");
        By editRecordButton = By.XPath("//span[contains(text(), 'Edit')]");
        By pageOneLink = By.XPath("//button[contains(title, 'Page 1')]");
        By pageTwoLink = By.XPath("//button[contains(title, 'Page 2')]");
        By pageThreeLink = By.XPath("//button[contains(title, 'Page 3')]");
        By privacyPolicyPageLink = By.XPath("//a[contains(text(), 'Privacy')]");

        public LabelBase TitleLabel
        {
            get
            {
                IWebElement element = waitFor.Element(titleLabel);

                return new LabelBase(element);
            }
        }
        
        public ButtonBase AddNewProductButton
        {
            get
            {
                IWebElement element = waitFor.Element(addNewProductButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase OptionsHeaderSection
        {
            get
            {
                IWebElement element = waitFor.Element(optionsHeaderSection);

                return new ButtonBase(element);
            }
        }

        public LabelBase GroupSectionLabel
        {
            get
            {
                IWebElement element = waitFor.Element(groupSectionLabel);

                return new LabelBase(element);
            }
        }

        public DropdownBase GroupOptionsDropdown
        {
            get
            {
                IWebElement element = waitFor.Element(groupOptionsDropdown);

                return new DropdownBase(element);
            }
        }

        public ButtonBase ClearAllFiltersButton
        {
            get
            {
                IWebElement element = waitFor.Element(clearAllFiltersButton);

                return new ButtonBase(element);
            }
        }

        public TextboxBase SearchByPartIdTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(searchByPartIdTextbox);

                return new TextboxBase(element);
            }
        }

        public ButtonBase EditRecordButton
        {
            get
            {
                IWebElement element = waitFor.Element(editRecordButton);

                return new ButtonBase(element);
            }
        }

        public LinkBase PageOneLink
        {
            get
            {
                IWebElement element = waitFor.Element(pageOneLink);

                return new LinkBase(element);
            }
        }

        public LinkBase PageTwoLink
        {
            get
            {
                IWebElement element = waitFor.Element(pageTwoLink);

                return new LinkBase(element);
            }
        }

        public LinkBase PageThreeLink
        {
            get
            {
                IWebElement element = waitFor.Element(pageThreeLink);

                return new LinkBase(element);
            }
        }

        public LinkBase PrivacyPolicyPageLink
        {
            get
            {
                IWebElement element = waitFor.Element(privacyPolicyPageLink);

                return new LinkBase(element);
            }
        }

        public AddProductPage NavigateToAddProductPage()
        {
            AddNewProductButton.Click();

            return new AddProductPage();
        }

        public ProductPage ExpandOptionsSection()
        {
            OptionsHeaderSection.Click();

            return new ProductPage();
        }

        public PrivacyPage NavigateToPrivacyPage()
        {
            PrivacyPolicyPageLink.Click();

            return new PrivacyPage();
        }

        public EditProductPage NavigateToEditProductPage()
        {
            EditRecordButton.Click();

            return new EditProductPage();
        }

        public bool AreProductPageControlsVisible()
        {
            if (TitleLabel.Visible && AddNewProductButton.Visible && ClearAllFiltersButton.Visible && EditRecordButton.Visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsGroupOptionLabelVisible()
        {
            return GroupSectionLabel.Visible;
        }

        public bool IsProductPageDisplayed()
        {
            return AddNewProductButton.Visible;
        }
    }
}
