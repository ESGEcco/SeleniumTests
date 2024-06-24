using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Controls;
using SeleniumFramework.SeleniumFramework.Helpers;

namespace SeleniumFramework.Pages.CertDbPages
{
    public class AddProductPage
    {
        #region ControlDefinitions

        WaitFor waitFor = new WaitFor();
        By addProductLabel = By.XPath("//h1[contains(text(), 'Add Product')]");
        By selectATypeButton = By.XPath("//span[contains(text(), 'Select a')]");
        By alarmTypeSelectionButton = By.XPath("//span[contains(text(), 'Alarm')]");
        By cameraTypeSelectionButton = By.XPath("//span[contains(text(), 'Camera')]");
        By lightTypeSelectionButton = By.XPath("//span[contains(text(), 'Light')]");
        By sirenSpeakerSelectionButton = By.XPath("//span[contains(text(), 'Siren Speaker')]");
        By workLampSelectionButton = By.XPath("//span[contains(text(), 'Work Lamp')]");
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
        By spl1Textbox = By.Id("Spl1");
        By spl2Textbox = By.Id("Spl2");
        By spl3Textbox = By.Id("Spl3");
        By frequencyTextbox = By.Id("Frequency");
        By toleranceTextbox = By.Id("Tolerance");
        By mountingTextbox = By.Id("Mounting");
        By housingMaterialTextbox = By.Id("HousingMaterial");
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

        public LabelBase AddProductLabel
        {
            get
            {
                IWebElement element = waitFor.Element(addProductLabel);

                return new LabelBase(element);
            }
        }

        public ButtonBase SelectATypeButton
        {
            get
            {
                IWebElement element = waitFor.Element(selectATypeButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase AlarmTypeSelectionButton
        {
            get
            {
                IWebElement element = waitFor.Element(alarmTypeSelectionButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase CameraTypeSelectionButton
        {
            get
            {
                IWebElement element = waitFor.Element(cameraTypeSelectionButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase LightTypeSelectionButton
        {
            get
            {
                IWebElement element = waitFor.Element(lightTypeSelectionButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase SirenSpeakerSelectionButton
        {
            get
            {
                IWebElement element = waitFor.Element(sirenSpeakerSelectionButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase WorkLampSelectionButton
        {
            get
            {
                IWebElement element = waitFor.Element(workLampSelectionButton);

                return new ButtonBase(element);
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

        public ButtonBase CancelProductOneButton
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

        public EditProductPage NavigateToEditProductPageAfterAlarmType()
        {
            SelectATypeButton.Click();
            AlarmTypeSelectionButton.Click();
            SubmitFormsOneButton.Click();

            return new EditProductPage();
        }

        public EditProductPage NavigateToEditProductPageAfterCameraType()
        {
            SelectATypeButton.Click();
            CameraTypeSelectionButton.Click();
            SubmitFormsOneButton.Click();

            return new EditProductPage();
        }

        public EditProductPage NavigateToEditProductPageAfterLightType()
        {
            SelectATypeButton.Click();
            LightTypeSelectionButton.Click();
            SubmitFormsOneButton.Click();

            return new EditProductPage();
        }

        public EditProductPage NavigateToEditProductPageAfterSirenSpeakerType()
        {
            SelectATypeButton.Click();
            SirenSpeakerSelectionButton.Click();
            SubmitFormsOneButton.Click();

            return new EditProductPage();
        }

        public EditProductPage NavigateToEditProductPageAfterWorkLampType()
        {
            SelectATypeButton.Click();
            WorkLampSelectionButton.Click();
            SubmitFormsOneButton.Click();

            return new EditProductPage();
        }

        public bool IsAddProductPageLoaded()
        {
            if (AddProductLabel.Visible && CertificationsTab.Visible && PrimarySpecificationsTab.Visible && SecondarySpecificationsTab.Visible
                && CrossReferencesTab.Visible && SubmitFormsOneButton.Visible && CancelProductTwoButton.Visible)
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
            CertificationsTabSection.WaitForNotVisible();

            if (!CertificationsTabSection.Visible && !PrimarySpecificationsTabSection.Visible && 
                !SecondarySpecificationsTabSection.Visible && !CrossReferencesTabSection.Visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerifyCertificationsTabSectionCollapse()
        {
            CertificationsTab.Click();
            CertificationsTabSection.WaitForNotVisible();

            if (!CertificationsTabSection.Visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerifyPrimarySpecificationsTabSectionCollapse()
        {
            PrimarySpecificationsTab.Click();
            PrimarySpecificationsTabSection.WaitForNotVisible();

            if (!PrimarySpecificationsTabSection.Visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerifySecondarySpecificationsTabSectionCollapse()
        {
            SecondarySpecificationsTab.Click();
            SecondarySpecificationsTabSection.WaitForNotVisible();

            if (!SecondarySpecificationsTabSection.Visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerifyCrossReferencesTabSectionCollapse()
        {
            CrossReferencesTab.Click();
            CrossReferencesTabSection.WaitForNotVisible();

            if (!CrossReferencesTabSection.Visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ProductPage CancelButtonReturnsToProductPage()
        {
            CancelProductOneButton.Click();

            return new ProductPage();
        }

        public AddProductPage SelectAlarmType()
        {
            SelectATypeButton.Click();
            AlarmTypeSelectionButton.Click();

            return new AddProductPage();
        }

        public bool AreAlarmControlsVisible()
        {
            if (Spl1Textbox.Visible && Spl2Textbox.Visible && Spl3Textbox.Visible && FrequencyTextbox.Visible &&
                ToleranceTextbox.Visible && MountingTextbox.Visible && HousingMaterialTextbox.Visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public AddProductPage SelectCameraType()
        {
            SelectATypeButton.Click();
            CameraTypeSelectionButton.WaitForClickable();
            CameraTypeSelectionButton.Click();

            return new AddProductPage();
        }

        public bool AreCameraControlsVisible()
        {
            if (CameraMountingTextbox.Visible && MonitorMountingTextbox.Visible && ColorSystemTextbox.Visible &&
                ScreenSizeTextbox.Visible && ScreenRatioTextbox.Visible && ResolutionTextbox.Visible &&
                LensAngleTextbox.Visible && InfraRedLedTextbox.Visible && WirelessSlider.Visible && AudioInputSlider.Visible &&
                DayNightSensorSlider.Visible && MirrorNormalImageSlider.Visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public AddProductPage SelectLightType()
        {
            SelectATypeButton.Click();
            LightTypeSelectionButton.WaitForClickable();
            LightTypeSelectionButton.Click();

            return new AddProductPage();
        }

        public bool AreLightControlsVisible()
        {
            if (LumensTextbox.Visible && ColorTextbox.Visible && LightMountingTextbox.Visible && BaseMaterialTextbox.Visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public AddProductPage SelectSirenSpeakerType()
        {
            SelectATypeButton.Click();
            SirenSpeakerSelectionButton.WaitForClickable();
            SirenSpeakerSelectionButton.Click();

            return new AddProductPage();
        }

        public bool AreSirenSpeakerControlsVisible()
        {
            if (StandbyCurrentTextbox.Visible && RatedPowerMaximumTextbox.Visible &&
                SirenSpeakerMountingTextbox.Visible && SirenSpeakerHousingMaterialTextbox.Visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public AddProductPage SelectWorkLampType()
        {
            SelectATypeButton.Click();
            WorkLampSelectionButton.WaitForClickable();
            WorkLampSelectionButton.Click();

            return new AddProductPage();
        }

        public bool AreWorkLampControlsVisible()
        {
            if (CalculatedLumensTextbox.Visible && RawLumensTextbox.Visible && EffectiveLumensTextbox.Visible &&
                IlluminanceTextbox.Visible && IntensityTextbox.Visible && CctTextbox.Visible && WorkLampMountingTextbox.Visible &&
                BaseMaterialTextbox.Visible && LensMaterialTextbox.Visible)
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
