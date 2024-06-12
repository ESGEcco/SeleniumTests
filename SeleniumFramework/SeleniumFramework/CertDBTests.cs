using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumFramework.Pages.CertDbPages;
using SeleniumFramework.SeleniumFramework.Helpers;
using System;

namespace SeleniumFramework
{
    [TestClass]
    public class CertDBTests : TestBase
    {
        [TestMethod]
        public void LoginPageControlsVisible()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                
                Assert.IsTrue(loginPage.AreLoginPageControlsDisplayed());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }
        
        [TestMethod]
        public void CertDBLogin()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();

                Assert.IsTrue(productPage.IsProductPageDisplayed());
            }
            catch(Exception e)
            {
                CaptureScreenshot();
                
                throw new Exception(e.Message);
            }            
        }

        [TestMethod]
        public void UsernameMissing()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();

                loginPage = loginPage.MissingUsername();

                Assert.IsTrue(loginPage.IsUsernameErrorLabelVisible());

            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void PasswordMissing()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();

                loginPage = loginPage.MissingPassword();

                Assert.IsTrue(loginPage.IsPasswordErrorLabelVisible());

            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void UsernameAndPasswordMissing()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();

                loginPage = loginPage.MissingUsernameAndPassword();

                Assert.IsTrue(loginPage.IsPasswordErrorLabelVisible());
                Assert.IsTrue(loginPage.IsUsernameErrorLabelVisible());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void InvalidUsernameAndPassword()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();

                loginPage = loginPage.InvalidUsernameAndPassword();

                Assert.IsTrue(loginPage.IsInvalidUsernameAndPasswordLabelVisible());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void CancelLogin()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();

                loginPage = loginPage.ClickCancelButton();

                Assert.IsTrue(loginPage.LoginPageLoaded());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void NavigateToForgotPasswordPage()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ForgotPasswordPage forgotPasswordPage = loginPage.NavigateToForgotPasswordPage();

                //Assert.IsTrue(*****CREATE VERIFY METHOD ONCE PAGE IS CREATED*****);
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void NavigateDirectlyToCertDBProductPage()
        {
            //This should only pass if the CertDB does not require credentials (Ex: previously logged in)
            try
            {
                ProductPage productPage = SF.OpenSites.OpenCertDBToProductPage();

                Assert.IsTrue(productPage.IsProductPageDisplayed());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void NavigateToAddProductPage()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                Assert.IsTrue(addProductPage.IsAddProductPageLoaded());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void ExpandOptionsSection()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();

                productPage = productPage.ExpandOptionsSection();

                Assert.IsTrue(productPage.IsGroupOptionLabelVisible());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void NavigateToPrivacyPage()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                PrivacyPage privacyPage = productPage.NavigateToPrivacyPage();

                Assert.IsTrue(privacyPage.IsPrivacyPolicyPageLoaded());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void NavigateToEditProductPage()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                EditProductPage editProductPage = productPage.NavigateToEditProductPage();

                Assert.IsTrue(editProductPage.IsEditProductPageTitle());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void VerifyProductPageControls()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();

                Assert.IsTrue(productPage.AreProductPageControlsVisible());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void VerifySearchByPartIdToolTip()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();

                Assert.IsTrue(productPage.VerifySearchByPartIdTooltip());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void VerifyRegionFilterToolTip()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();

                Assert.IsTrue(productPage.VerifyRegionFilterTooltip());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void VerifyProductFilterToolTip()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();

                Assert.IsTrue(productPage.VerifyProdctFilterTooltip());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void VerifyAddProductTabsCollapse()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                Assert.IsTrue(addProductPage.VerifyCollapseAll());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void VerifyAddProductCertificationsTabCollapse()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                Assert.IsTrue(addProductPage.VerifyCertificationsTabSectionCollapse());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void VerifyAddProductsPrimarySpecificationsCollapse()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                Assert.IsTrue(addProductPage.VerifyPrimarySpecificationsTabSectionCollapse());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void VerifyAddProductsSecondarySpecificationsCollapse()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                Assert.IsTrue(addProductPage.VerifySecondarySpecificationsTabSectionCollapse());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void VerifyAddProductsCrossReferencesCollapse()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                Assert.IsTrue(addProductPage.VerifyCrossReferencesTabSectionCollapse());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }

        [TestMethod]
        public void VerifyCancelButtonReturnsToProductPage()
        {
            try
            {
                LoginPage loginPage = SF.OpenSites.OpenCertDB();
                ProductPage productPage = loginPage.Login();
                AddProductPage addProductPage = productPage.NavigateToAddProductPage();

                productPage = addProductPage.CancelButtonReturnsToProductPage();

                Assert.IsTrue(productPage.IsProductPageDisplayed());
            }
            catch (Exception e)
            {
                CaptureScreenshot();

                throw new Exception(e.Message);
            }
        }
    }
}
