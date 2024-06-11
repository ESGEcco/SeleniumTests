using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Controls;
using SeleniumFramework.SeleniumFramework.Helpers;
using System.Configuration;

namespace SeleniumFramework.Pages.CertDbPages
{
    public class AddProductPage
    {
        WaitFor waitFor = new WaitFor();
        By addProductLabel = By.XPath("//h1[contains(text(), 'Add Product')]");
        By selectATypeDropdown = By.XPath("//span[contains(text(), 'Select a')]");
        By expandCollapseAllButton = By.Id("expandCollapse");
        By submitFormsOneButton = By.Id("productSubmit1");
        By cancelOneButton = By.XPath("//span[contains(text(), 'Cancel')]");
        By certificationsTab = By.XPath("//div[contains(text(), 'Certifications')]");
        By primarySpecificationsTab = By.XPath("//div[contains(text(), 'Primary Specifications')]");
        By currentTextbox = By.Id("Current");
        By powerTextbox = By.Id("Power");
        By lowTempTextbox = By.Id("LowTemp");
        By highTempTextbox = By.Id("HighTemp");
        By nominalVoltageTextbox = By.Id("NominalVoltage");
        By extremeVoltageTextbox = By.Id("ExtremeVoltage");
        By productWeightTextbox = By.Id("ProductWeight");
        By shippingWeightTextbox = By.Id("ShippingWeight");
        By warrantyTextbox = By.Id("Warranty");
        By lengthTextbox = By.Id("Length");
        By widthTextbox = By.Id("Width");
        By heightTextbox = By.Id("Height");
        By commentsTextbox = By.Id("Comments");
        By secondarySpecificationsTab = By.XPath("//div[contains(text(), 'Secondary Specifications')]");
        By crossReferencesTab = By.XPath("//div[contains(text(), 'Cross References')]");
        By submitTwoButton = By.Id("productSubmit2");
        By cancelProductTwoButton = By.Id("cancelSubmit2");


        public LabelBase AddProductLabel
        {
            get
            {
                IWebElement element = waitFor.Element(addProductLabel);

                return new LabelBase(element);
            }
        }

        public DropdownBase SelectATypeDropdown
        {
            get
            {
                IWebElement element = waitFor.Element(selectATypeDropdown);

                return new DropdownBase(element);
            }
        }

        public ButtonBase ExpandCollapseAllButton
        {
            get
            {
                IWebElement element = waitFor.Element(expandCollapseAllButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase SubmitFormsOneButton
        {
            get
            {
                IWebElement element = waitFor.Element(submitFormsOneButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase CancelOneButton
        {
            get
            {
                IWebElement element = waitFor.Element(cancelOneButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase CertificationsTab
        {
            get
            {
                IWebElement element = waitFor.Element(certificationsTab);

                return new ButtonBase(element);
            }
        }

        public ButtonBase PrimarySpecificationsTab
        {
            get
            {
                IWebElement element = waitFor.Element(primarySpecificationsTab);

                return new ButtonBase(element);
            }
        }

        public TextboxBase CurrentTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(currentTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase PowerTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(powerTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase LowTempTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(lowTempTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase HighTempTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(highTempTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase NominalVoltageTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(nominalVoltageTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase ExtremeVoltageTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(extremeVoltageTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase ProductWeightTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(productWeightTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase ShippingWeightTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(shippingWeightTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase WarrantyTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(warrantyTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase LengthTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(lengthTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase WidthTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(widthTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase HeightTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(heightTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase CommentsTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(commentsTextbox);

                return new TextboxBase(element);
            }
        }

        public ButtonBase SecondarySpecificationsTab
        {
            get
            {
                IWebElement element = waitFor.Element(secondarySpecificationsTab);

                return new ButtonBase(element);
            }
        }

        public ButtonBase CrossReferencesTab
        {
            get
            {
                IWebElement element = waitFor.Element(crossReferencesTab);

                return new ButtonBase(element);
            }
        }

        public ButtonBase DubmitTwoButton
        {
            get
            {
                IWebElement element = waitFor.Element(submitTwoButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase CancelProductTwoButton
        {
            get
            {
                IWebElement element = waitFor.Element(cancelProductTwoButton);

                return new ButtonBase(element);
            }
        }

        public bool IsAddProductPageLoaded()
        {
            return AddProductLabel.Visible;
        }
    }
}
