using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Controls;
using SeleniumFramework.SeleniumFramework.Helpers;
using System.Threading;

namespace SeleniumFramework.Pages.CertDbPages
{
    public class EditProductPage
    {
        #region ControlDefinitions

        WaitFor waitFor = new WaitFor();
        By titleLabel = By.XPath("//h1[contains(text(), 'Edit Product')]");
        By expandCollapseAllButton = By.Id("expandCollapse");
        By submitFormsOneButton = By.Id("productSubmit1");
        By cancelOneButton = By.Id("cancelSubmit1");
        By duplicateProductButton = By.Id("productDuplicate");
        By certificationsAddNewProductButton = By.XPath("//span[contains(text(), 'Add new record')]");
        By certificationCommentTextbox = By.Id("CertificationCommentPlaceHolder");
        By certificationConnectorTextbox = By.Id("CertificationConnectorPlaceHolder");
        By certificationDisclosureCheckbox = By.Id("CertificationDisclosurePlaceHolder");
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
        By primarySpecificationsCommmentTextbox = By.Id("Comments");
        By spl1Textbox = By.Id("Spl1");
        By spl2Textbox = By.Id("Spl2");
        By spl3Textbox = By.Id("Spl3");
        By frequencyTextbox = By.Id("Frequency");
        By toleranceTextbox = By.Id("Tolerance");
        By mountingTextbox = By.Id("Mounting");
        By housingMaterialTextbox = By.Id("HousingMaterial");
        By crossReferencesAddNewRecordButton = By.XPath("//span[contains(text(), 'Add new record')]");
        By submitFormsTwoButton = By.Id("productSubmit2");
        By cancelTwoButton = By.Id("cancelSubmit2");
        By cameraMountingTextbox = By.Id("CameraMounting");
        By monitorMountingTextbox = By.Id("MonitorMounting");
        By colorSystemTextbox = By.Id("ColorSystem");
        By screenSizeTextbox = By.Id("ScreenSize");
        By screenRatioTextbox = By.Id("ScreenRatio");
        By resolutionTextbox = By.Id("Resolution");
        By lensAngleTextbox = By.Id("LensAngle");
        By infraRedLedTextbox = By.Id("InfraredLed");
        By wirelessSlider = By.Id("Wireless");
        By audioInputSlider = By.Id("AudioInput");
        By dayNightSensorSlider = By.Id("DayNightSensor");
        By mirrorNormalImageSlider = By.Id("MirrorNormalImage");
        By lumensTextbox = By.Id("Lumens");
        By colorTextbox = By.Id("Color");
        By lightMountingTextbox = By.Id("Mounting");
        By baseMaterialTextbox = By.Id("BaseMaterial");
        By standbyCurrentTextbox = By.Id("StandbyCurrent");
        By ratedPowerMaximumTextbox = By.Id("RatedPowerMaximum");
        By sirenSpeakerMountingTextbox = By.Id("Mounting");
        By sirenSpeakerHousingMaterialTextbox = By.Id("HousingMaterial");
        By calculatedLumensTextbox = By.Id("CalculatedLumens");
        By rawLumensTextbox = By.Id("RawLumens");
        By effectiveLumensTextbox = By.Id("EffectiveLumens");
        By illuminanceTextbox = By.Id("Illuminance");
        By intensityTextbox = By.Id("Intensity");
        By cctTextbox = By.Id("Cct");
        By workLampMountingTextbox = By.Id("Mounting");
        By workLampBaseMaterialTextbox = By.Id("BaseMaterial");
        By lensMaterialTextbox = By.Id("LensMaterial");

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

        public ButtonBase DuplicateProductButton
        {
            get
            {
                IWebElement element = waitFor.Element(duplicateProductButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase CertificationsAddNewProductButton
        {
            get
            {
                IWebElement element = waitFor.Element(certificationsAddNewProductButton);

                return new ButtonBase(element);
            }
        }

        public TextboxBase CertificationCommentTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(certificationCommentTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase CertificationConnectorTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(certificationConnectorTextbox);

                return new TextboxBase(element);
            }
        }

        public CheckboxBase CertificationDisclosureCheckbox
        {
            get
            {
                IWebElement element = waitFor.Element(certificationDisclosureCheckbox);

                return new CheckboxBase(element);
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

        public TextboxBase PrimarySpecificationsCommmentTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(primarySpecificationsCommmentTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase Spl1Textbox
        {
            get
            {
                IWebElement element = waitFor.Element(spl1Textbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase Spl2Textbox
        {
            get
            {
                IWebElement element = waitFor.Element(spl2Textbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase Spl3Textbox
        {
            get
            {
                IWebElement element = waitFor.Element(spl3Textbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase FrequencyTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(frequencyTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase ToleranceTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(toleranceTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase MountingTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(mountingTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase HousingMaterialTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(housingMaterialTextbox);

                return new TextboxBase(element);
            }
        }

        public ButtonBase CrossReferencesAddNewRecordButton
        {
            get
            {
                IWebElement element = waitFor.Element(crossReferencesAddNewRecordButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase SubmitFormsTwoButton
        {
            get
            {
                IWebElement element = waitFor.Element(submitFormsTwoButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase CancelTwoButton
        {
            get
            {
                IWebElement element = waitFor.Element(cancelTwoButton);

                return new ButtonBase(element);
            }
        }

        public TextboxBase CameraMountingTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(cameraMountingTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase MonitorMountingTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(monitorMountingTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase ColorSystemTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(colorSystemTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase ScreenSizeTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(screenSizeTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase ScreenRatioTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(screenRatioTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase ResolutionTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(resolutionTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase LensAngleTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(lensAngleTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase InfraRedLedTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(infraRedLedTextbox);

                return new TextboxBase(element);
            }
        }

        public ButtonBase WirelessSlider
        {
            get
            {
                IWebElement element = waitFor.Element(wirelessSlider);

                return new ButtonBase(element);
            }
        }

        public ButtonBase AudioInputSlider
        {
            get
            {
                IWebElement element = waitFor.Element(audioInputSlider);

                return new ButtonBase(element);
            }
        }

        public ButtonBase DayNightSensorSlider
        {
            get
            {
                IWebElement element = waitFor.Element(dayNightSensorSlider);

                return new ButtonBase(element);
            }
        }

        public ButtonBase MirrorNormalImageSlider
        {
            get
            {
                IWebElement element = waitFor.Element(mirrorNormalImageSlider);

                return new ButtonBase(element);
            }
        }

        public TextboxBase LumensTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(lumensTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase ColorTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(colorTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase LightMountingTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(lightMountingTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase BaseMaterialTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(baseMaterialTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase StandbyCurrentTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(standbyCurrentTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase RatedPowerMaximumTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(ratedPowerMaximumTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase SirenSpeakerMountingTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(sirenSpeakerMountingTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase SirenSpeakerHousingMaterialTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(sirenSpeakerHousingMaterialTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase CalculatedLumensTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(calculatedLumensTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase RawLumensTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(rawLumensTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase EffectiveLumensTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(effectiveLumensTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase IlluminanceTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(illuminanceTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase IntensityTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(intensityTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase CctTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(cctTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase WorkLampMountingTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(workLampMountingTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase WorkLampBaseMaterialTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(workLampBaseMaterialTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase LensMaterialTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(lensMaterialTextbox);

                return new TextboxBase(element);
            }
        }

        #endregion ControlInstantiations

        public ProductPage ClickCancelOneButton()
        {
            CancelOneButton.Click();

            return new ProductPage();
        }

        public ProductPage ClickCancelTwoButton()
        {
            CancelOneButton.Click();

            return new ProductPage();
        }

        public EditProductPage ExpandCollapseAll()
        {
            ExpandCollapseAllButton.Click();

            return new EditProductPage();
        }

        public EditCertificationsAddNewRecordFormPage NavigateToEditAddNewRecordFormPage()
        {
            CertificationsAddNewProductButton.Click();

            return new EditCertificationsAddNewRecordFormPage();
        }

        public EditCrossReferencesAddNewRecordPage NavigateToEditCrossReferencesAddNewRecordPage()
        {
            CrossReferencesAddNewRecordButton.Click();

            return new EditCrossReferencesAddNewRecordPage();
        }

        public EditProductDuplicateProductPage NavigateToDuplicateProductPage()
        {
            DuplicateProductButton.Click();

            return new EditProductDuplicateProductPage();
        }

        public bool IsEditProductPageTitle()
        {
            return TitleLabel.Visible;
        }

        public bool IsFormCollapsed()
        {
            if (!CertificationConnectorTextbox.Visible && !CurrentTextbox.Visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFormExpanded()
        {
            if (CertificationConnectorTextbox.Visible && CurrentTextbox.Visible)
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
