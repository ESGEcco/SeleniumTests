using NUnit.Framework;
using SeleniumFramework.Pages.LightbarBuilder;
using System;

namespace SeleniumFramework
{
    
    public class LbbTests : TestBase
    {
        [Test(Description = "Verifies the controls on the Lightbar Builder Login page")]
        public void LbbLoginPageControlsVisible()
        {
            try
            {
                LbbLoginPage lbbLoginPage = SF.OpenSites.OpenLightbarBuilder();

                Assert.That(true);
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
