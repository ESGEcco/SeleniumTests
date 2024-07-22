using NUnit.Framework;
using SeleniumFramework.Pages.CertDbPages;
using System;

namespace SeleniumFramework
{
    [TestFixture]
    public class CertDBTests : TestBase
    {
        [Test(Description ="Verifies the controls on the Login page")]
        public void LoginPageControlsVisible()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                
                Assert.Equals(true, loginPage.AreLoginPageControlsDisplayed());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }
        
        [Test(Description ="Verifies the ability to login to the CertDB")]
        public void CertDBLogin()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();

                Assert.Equals(true, productPage.IsProductPageDisplayed());
            }
            catch(Exception e)
            {
                CaptureScreenshot();
                
                throw new Exception(e.Message);
            }            
        }

        [Test(Description ="Verifies the appropriate message is displayed for a missing UserName")]
        public void UsernameMissing()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();

                loginPage = loginPage.MissingUsername();

                Assert.Equals(true, loginPage.IsUsernameErrorLabelVisible());

            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the appropriate message is displayed for a missing Password")]
        public void PasswordMissing()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();

                loginPage = loginPage.MissingPassword();

                Assert.Equals(true, loginPage.IsPasswordErrorLabelVisible());

            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the appropriate message is displayed if both credentials are missing")]
        public void UsernameAndPasswordMissing()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();

                loginPage = loginPage.MissingUsernameAndPassword();

                Assert.Equals(true, loginPage.IsPasswordErrorLabelVisible());
                Assert.Equals(true, loginPage.IsUsernameErrorLabelVisible());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the appropriate message is displayed for having wrong credentials")]
        public void InvalidUsernameAndPassword()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();

                loginPage = loginPage.InvalidUsernameAndPassword();

                Assert.Equals(true, loginPage.IsInvalidUsernameAndPasswordLabelVisible());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies navigation to the appropriate page if canceling loggin in to CertDB")]
        public void CancelLogin()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();

                loginPage = loginPage.ClickCancelButton();

                Assert.Equals(true, loginPage.LoginPageLoaded());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies navigation to the correct page when the Forgot Password link is clicked")]
        public void NavigateToForgotPasswordPage()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ForgotPasswordPage forgotPasswordPage = loginPage.NavigateToForgotPasswordPage();

                //Assert.Equals(*****CREATE VERIFY METHOD ONCE PAGE IS CREATED*****);
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies that the login page is by passed if authorized credentials have been previously entered")]
        public void NavigateDirectlyToCertDBProductPage()
        {
            //This should only pass if the CertDB does not require credentials (Ex: previously logged in)
            try
            {
                ProductPage productPage = SF.OpenSites.OpenCertDBToProductPage();

                Assert.Equals(true, productPage.IsProductPageDisplayed());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies navigation to the Add Product page")]
        public void NavigateToAddProductPage()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                Assert.Equals(true, addProductPage.IsAddProductPageLoaded());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies Options section can successfully expand")]
        public void ExpandOptionsSection()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();

                productPage = productPage.ExpandOptionsSection();

                Assert.Equals(true, productPage.IsGroupOptionLabelVisible());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies successful navigation to the Privacy page")]
        public void NavigateToPrivacyPage()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                PrivacyPage privacyPage = productPage.NavigateToPrivacyPage();

                Assert.Equals(true, privacyPage.IsPrivacyPolicyPageLoaded());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies ability to navigate to the Edit Product page")]
        public void NavigateToEditProductPage()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                EditProductPage editProductPage = productPage.NavigateToEditProductPage();

                Assert.Equals(true, editProductPage.IsEditProductPageTitle());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the controls on the Product page")]
        public void VerifyProductPageControls()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();

                Assert.Equals(true, productPage.AreProductPageControlsVisible());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the Search by Part Id tooltip")]
        public void VerifySearchByPartIdToolTip()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();

                Assert.Equals(true, productPage.VerifySearchByPartIdTooltip());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the Region Filter tooltip")]
        public void VerifyRegionFilterToolTip()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();

                Assert.Equals(true, productPage.VerifyRegionFilterTooltip());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the Product Filter tooltip")]
        public void VerifyProductFilterToolTip()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();

                Assert.Equals(true, productPage.VerifyProdctFilterTooltip());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the Add Product tabs collapse correctly")]
        public void VerifyAddProductTabsCollapse()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                Assert.Equals(true, addProductPage.VerifyCollapseAll());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the Add Product Certifications tab collapses correctly")]
        public void VerifyAddProductCertificationsTabCollapse()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                Assert.Equals(true, addProductPage.VerifyCertificationsTabSectionCollapse());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the Add Products Primary Specifications tab collapses correctly")]
        public void VerifyAddProductsPrimarySpecificationsCollapse()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                Assert.Equals(true, addProductPage.VerifyPrimarySpecificationsTabSectionCollapse());
                
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the Add Products Secondary Specifications tab collapses correctly")]
        public void VerifyAddProductsSecondarySpecificationsCollapse()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                Assert.Equals(true, addProductPage.VerifySecondarySpecificationsTabSectionCollapse());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the Add Product Cross References tab collapses correctly")]
        public void VerifyAddProductsCrossReferencesCollapse()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                Assert.Equals(true, addProductPage.VerifyCrossReferencesTabSectionCollapse());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies clicking the Cancel button returns to the Product page")]
        public void VerifyCancelButtonReturnsToProductPage()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                productPage = addProductPage.CancelButtonReturnsToProductPage();

                Assert.Equals(true, productPage.IsProductPageDisplayed());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the controls displayed after selecting the Alarm type")]
        public void VerifyAlarmTypeControls()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                addProductPage = addProductPage.SelectAlarmType();

                Assert.Equals(true, addProductPage.AreAlarmControlsVisible());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the proper controls are displayed when selecting the Camera type")]
        public void VerifyCameraTypeControls()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                addProductPage = addProductPage.SelectCameraType();

                Assert.Equals(true, addProductPage.AreCameraControlsVisible());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the proper controls are displayed after selecting the Light type")]
        public void VerifyLightTypeControls()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                addProductPage = addProductPage.SelectLightType();

                Assert.Equals(true, addProductPage.AreLightControlsVisible());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the proper controls are displayed after selecting the Siren Speaker type")]
        public void VerifySirenSpeakerTypeControls()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                addProductPage = addProductPage.SelectSirenSpeakerType();

                Assert.Equals(true, addProductPage.AreSirenSpeakerControlsVisible());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the proper controls are displayed after selecting the Work Lamp type")]
        public void VerifyWorkLampTypeControls()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                addProductPage = addProductPage.SelectWorkLampType();

                Assert.Equals(true, addProductPage.AreWorkLampControlsVisible());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies navigation to the Edit Product page after selecting a type")]
        public void VerifyNavigateToEditProductPageAfterType()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();
                EditProductPage editProductPage = addProductPage.NavigateToEditProductPageAfterAlarmType();

                Assert.Equals(true, editProductPage.IsEditProductPageTitle());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies navigation back to the Product page after clicking the top Cancel button")]
        public void VerifyNavigateToProductPageAfterCancelOne()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();
                EditProductPage editProductPage = addProductPage.NavigateToEditProductPageAfterAlarmType();

                productPage = editProductPage.ClickCancelOneButton();

                Assert.Equals(true, productPage.IsProductPageDisplayed());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies navigation to the Product page after clicking the bottom Cancel button")]
        public void VerifyNavigateToProductPageAfterCancelTwo()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();
                EditProductPage editProductPage = addProductPage.NavigateToEditProductPageAfterAlarmType();

                productPage = editProductPage.ClickCancelTwoButton();

                Assert.Equals(true, productPage.IsProductPageDisplayed());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the Edit Product Add New Product form is displayed")]
        public void VerifyEditProductAddNewProductFormIsDisplayed()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();
                EditProductPage editProductPage = addProductPage.NavigateToEditProductPageAfterAlarmType();
                EditCertificationsAddNewRecordFormPage editAddNewRecordFormPage = editProductPage.NavigateToEditAddNewRecordFormPage();
                
                Assert.Equals(true, editAddNewRecordFormPage.IsEditAddNewRecordFormDisplayed());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the Cross Reference Add New Product form is displayed")]
        public void VerifyEditProductCrossReferencesAddNewProductFormIsDisplayed()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();
                EditProductPage editProductPage = addProductPage.NavigateToEditProductPageAfterAlarmType();
                EditCrossReferencesAddNewRecordPage editCrossReferencesAddNewRecordPage = editProductPage.NavigateToEditCrossReferencesAddNewRecordPage();

                Assert.Equals(true, editCrossReferencesAddNewRecordPage.IsEditAddNewRecordFormDisplayed());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the Duplicate Product form is displayed")]
        public void VerifyEditProductDuplicateProductFormIsDisplayed()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();
                EditProductPage editProductPage = addProductPage.NavigateToEditProductPageAfterAlarmType();
                EditProductDuplicateProductPage editProductDuplicateProductPage = editProductPage.NavigateToDuplicateProductPage();

                Assert.Equals(true, editProductDuplicateProductPage.IsDuplicateProductTitleVisible());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the Edit Product page collapses every tab")]
        public void VerifyEditProductPageCollapseAll()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();
                EditProductPage editProductPage = addProductPage.NavigateToEditProductPageAfterAlarmType();

                editProductPage = editProductPage.ExpandCollapseAll();

                Assert.Equals(true, editProductPage.IsFormCollapsed());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies the Type error dialogue is displayed properly")]
        public void VerifySelectTypeErrorDialogueDisplayed()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                addProductPage = addProductPage.ClickSubmitFormsNoType();

                Assert.Equals(true, addProductPage.IsErrorDialogueDisplayed());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [Test(Description ="Verifies successful logout of the CertDB")]
        public void LogoutOfCertDB()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                LogoutPage logoutPage = productPage.LogoutOfDB();

                Assert.Equals(true, logoutPage.IsLogoutLabelDisplayed());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }
    }
}
