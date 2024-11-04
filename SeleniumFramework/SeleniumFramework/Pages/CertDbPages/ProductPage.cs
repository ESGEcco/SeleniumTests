using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Controls;
using SeleniumFramework.SeleniumFramework.Helpers;
using System.Configuration;

namespace SeleniumFramework.Pages.CertDbPages
{
    public class ProductPage
    {
        #region ControlDefinitions

        WaitFor waitFor = new WaitFor();
        By titleLabel = By.Id("title");
        By addNewProductButton = By.Id("addProductButton");
        By optionsHeaderSection = By.ClassName("expansion-panel-section");
        By groupSection = By.Id("Options");
        By groupOptionsDropdown = By.ClassName("k-input-inner");
        By clearAllFiltersButton = By.XPath("//button[contains(text(), 'Clear all Filters')]");
        By searchByPartIdTextbox = By.XPath("//input[contains(@title, 'Search by')]");
        By regionFilterIcon = By.XPath("//a[contains(@title, 'Region')]");
        By productTypeFilterIcon = By.XPath("//a[contains(@title, 'Product')]");
        By editRecordButton = By.XPath("//span[contains(text(), 'Edit')]");
        By pageOneLink = By.XPath("//button[contains(@title, 'Page 1')]");
        By pageTwoLink = By.XPath("//button[contains(@title, 'Page 2')]");
        By pageThreeLink = By.XPath("//button[contains(@title, 'Page 3')]");
        By privacyPolicyPageLink = By.XPath("//a[contains(text(), 'Privacy')]");
        By accountButton = By.XPath("//a[contains(text(), 'Account')]");
        By logoutButton = By.XPath("//a[contains(text(), 'Logout')]");

        #endregion ControlDefinitions

        #region ControlInstantiations

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

        public LabelBase GroupSection
        {
            get
            {
                IWebElement element = waitFor.Element(groupSection);

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

        public ButtonBase RegionFilterIcon
        {
            get
            {
                IWebElement element = waitFor.Element(regionFilterIcon);

                return new ButtonBase(element);
            }
        }

        public ButtonBase ProductTypeFilterIcon
        {
            get
            {
                IWebElement element = waitFor.Element(productTypeFilterIcon);

                return new ButtonBase(element);
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

        public ButtonBase AccountButton
        {
            get
            {
                IWebElement element = waitFor.Element(accountButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase LogoutButton
        {
            get
            {
                IWebElement element = waitFor.Element(logoutButton);

                return new ButtonBase(element);
            }
        }

        #endregion ControlInstantiations

        public AddProductPage NavigateToAddProductPage()
        {
            AddNewProductButton.WaitForClickable();
            AddNewProductButton.Click();

            return new AddProductPage();
        }

        public ProductPage ExpandOptionsSection()
        {
            OptionsHeaderSection.WaitForClickable();
            OptionsHeaderSection.Click();

            return new ProductPage();
        }

        public PrivacyPage NavigateToPrivacyPage()
        {
            PrivacyPolicyPageLink.WaitForClickable();
            PrivacyPolicyPageLink.Click();

            return new PrivacyPage();
        }

        public EditProductPage NavigateToEditProductPage()
        {
            EditRecordButton.WaitForClickable();
            EditRecordButton.Click();

            return new EditProductPage();
        }

        public LogoutPage LogoutOfDB()
        {
            AccountButton.WaitForClickable();
            AccountButton.Click();
            LogoutButton.Click();

            return new LogoutPage();
        }

        public bool AreProductPageControlsVisible()
        {
            if (TitleLabel.Visible && AddNewProductButton.Visible && ClearAllFiltersButton.Visible && EditRecordButton.Visible && SearchByPartIdTextbox.Visible)
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
            return GroupSection.Visible;
        }

        public bool IsProductPageDisplayed()
        {
            return AddNewProductButton.Visible;
        }

        public bool VerifySearchByPartIdTooltip()
        {
            string searchByPartIdToolTip = SearchByPartIdTextbox.GetTitleAttribute();

            return searchByPartIdToolTip.Equals("Search by PartId");
        }

        public bool VerifyRegionFilterTooltip()
        {
            string regionToolTip = RegionFilterIcon.GetTitleAttribute();

            return regionToolTip.Equals("Region filter column settings");
        }

        public bool VerifyProdctFilterTooltip()
        {
            string regionToolTip = ProductTypeFilterIcon.GetTitleAttribute();

            return regionToolTip.Equals("Product Type filter column settings");
        }
    }
}
