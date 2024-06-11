using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Controls;
using SeleniumFramework.SeleniumFramework.Helpers;
using System.Configuration;
using System.Threading;

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
        By certificationsTabSection = By.Id("Certifications");
        By primarySpecificationsTab = By.XPath("//div[contains(text(), 'Primary Specifications')]");
        By primarySpecificationsTabSection = By.Id("PrimarySpecifications");
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
        By increaseValueButton = By.XPath("//button[contains(@title, 'Increase')]");
        By decreaseValueButton = By.XPath("//button[contains(@title, 'Decrease')]");
        By secondarySpecificationsTab = By.XPath("//div[contains(text(), 'Secondary Specifications')]");
        By secondarySpecificationsTabSection = By.Id("SecondarySpecifications");
        By crossReferencesTab = By.XPath("//div[contains(text(), 'Cross References')]");
        By crossReferencesTabSection = By.Id("CrossReferences");
        By submitTwoButton = By.Id("productSubmit2");
        By cancelProductTwoButton = By.Id("cancelSubmit2");

        #region ControlDefinitions

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

        public LabelBase CertificationsTabSection
        {
            get
            {
                IWebElement element = waitFor.Element(certificationsTabSection);

                return new LabelBase(element);
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

        public LabelBase PrimarySpecificationsTabSection
        {
            get
            {
                IWebElement element = waitFor.Element(primarySpecificationsTabSection);

                return new LabelBase(element);
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

        public ButtonBase IncreaseValueButtonZero
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(increaseValueButton, 0);

                return new ButtonBase(element);
            }
        }

        public ButtonBase DecreaseValueButtonZero
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(decreaseValueButton, 0);

                return new ButtonBase(element);
            }
        }

        public ButtonBase IncreaseValueButtonOne
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(increaseValueButton, 1);

                return new ButtonBase(element);
            }
        }

        public ButtonBase DecreaseValueButtonOne
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(decreaseValueButton, 1);

                return new ButtonBase(element);
            }
        }

        public ButtonBase IncreaseValueButtonTwo
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(increaseValueButton, 2);

                return new ButtonBase(element);
            }
        }

        public ButtonBase DecreaseValueButtonTwo
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(decreaseValueButton, 2);

                return new ButtonBase(element);
            }
        }

        public ButtonBase IncreaseValueButtonThree
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(increaseValueButton, 3);

                return new ButtonBase(element);
            }
        }

        public ButtonBase DecreaseValueButtonThree
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(decreaseValueButton, 3);

                return new ButtonBase(element);
            }
        }

        public ButtonBase IncreaseValueButtonFour
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(increaseValueButton, 4);

                return new ButtonBase(element);
            }
        }

        public ButtonBase DecreaseValueButtonFour
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(decreaseValueButton, 4);

                return new ButtonBase(element);
            }
        }

        public ButtonBase IncreaseValueButtonFive
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(increaseValueButton, 5);

                return new ButtonBase(element);
            }
        }

        public ButtonBase DecreaseValueButtonFive
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(decreaseValueButton, 5);

                return new ButtonBase(element);
            }
        }

        public ButtonBase IncreaseValueButtonSix
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(increaseValueButton, 6);

                return new ButtonBase(element);
            }
        }

        public ButtonBase DecreaseValueButtonSix
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(decreaseValueButton, 6);

                return new ButtonBase(element);
            }
        }

        public ButtonBase IncreaseValueButtonSeven
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(increaseValueButton, 7);

                return new ButtonBase(element);
            }
        }

        public ButtonBase DecreaseValueButtonSeven
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(decreaseValueButton, 7);

                return new ButtonBase(element);
            }
        }

        public ButtonBase IncreaseValueButtonEight
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(increaseValueButton, 8);

                return new ButtonBase(element);
            }
        }

        public ButtonBase DecreaseValueButtonEight
        {
            get
            {
                IWebElement element = waitFor.ElementsArray(decreaseValueButton, 8);

                return new ButtonBase(element);
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

        public LabelBase SecondarySpecificationsTabSection
        {
            get
            {
                IWebElement element = waitFor.Element(secondarySpecificationsTabSection);

                return new LabelBase(element);
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

        public LabelBase CrossReferencesTabSection
        {
            get
            {
                IWebElement element = waitFor.Element(crossReferencesTabSection);

                return new LabelBase(element);
            }
        }

        public ButtonBase SubmitTwoButton
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

        #endregion ControlDefinitions

        public bool IsAddProductPageLoaded()
        {
            if (AddProductLabel.Visible && CertificationsTab.Visible && PrimarySpecificationsTab.Visible && SecondarySpecificationsTab.Visible && CrossReferencesTab.Visible && SubmitFormsOneButton.Visible && CancelProductTwoButton.Visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerifyCollapseAll()
        {
            ExpandCollapseAllButton.Click();

            while (CertificationsTabSection.Visible)
            {
                Thread.Sleep(250);
            }

            if (!CertificationsTabSection.Visible && !PrimarySpecificationsTabSection.Visible && !SecondarySpecificationsTabSection.Visible && !CrossReferencesTabSection.Visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
