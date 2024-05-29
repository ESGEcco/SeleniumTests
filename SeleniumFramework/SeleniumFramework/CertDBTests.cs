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
    }
}
