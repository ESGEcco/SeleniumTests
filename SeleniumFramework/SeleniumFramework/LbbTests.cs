using NUnit.Framework;
using SeleniumFramework.Pages.LightbarBuilder;
using System;

namespace SeleniumFramework
{
    
    public class LbbTests : TestBase
    {
        [Test(Description ="Verifies a successful login")]
        public void GreenLogin()
        {
            try
            {
                LbbLoginPage lbbLoginPage = SF.OpenSites.OpenLightbarBuilder();
                LightbarBuilderPage lightbarBuilderPage = lbbLoginPage.CorrectLogin();

                Assert.That(lightbarBuilderPage.IsQuoteButtonVisible());
            }
            catch (Exception e)
            {
                CaptureScreenshot(TestContext.CurrentContext.Test.Name);

                throw new Exception(e.Message);
            }
        }
        
        [Test(Description = "Verifies the controls on the Lightbar Builder Login page")]
        public void LbbLoginPageControlsVisible()
        {
            try
            {
                LbbLoginPage lbbLoginPage = SF.OpenSites.OpenLightbarBuilder();
                LightbarBuilderPage lightbarBuildcrPage = lbbLoginPage.CorrectLogin();
                
                Assert.That(lightbarBuildcrPage.IsQuoteButtonVisible());
            }
            catch (Exception e)
            {
                CaptureScreenshot(TestContext.CurrentContext.Test.Name);

                throw new Exception(e.Message);
            }
        }

        [Test(Description = "Verifies the action when the Username is missing")]
        public void MissingUsername()
        {
            try
            {
                LbbLoginPage lbbLoginPage = SF.OpenSites.OpenLightbarBuilder();
                
                Assert.That(lbbLoginPage.IsUsernameMissing());
            }
            catch (Exception e)
            {
                CaptureScreenshot(TestContext.CurrentContext.Test.Name);

                throw new Exception(e.Message);
            }
        }

        [TearDown]
        public void DeleteDriver()
        {
            TestCleanup();
        }
    }
}
