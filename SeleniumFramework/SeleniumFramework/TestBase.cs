using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Helpers;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace SeleniumFramework
{
    public class TestBase
    {
        [TestCleanup]
        public void TestCleanup()
        {
            SF.Driver.Quit();
            SF.Driver = null; //Resets the driver on the next run
        }

        public void CaptureScreenshot(string path = @".\Screenshots")
        {
            ScreenShotRemoteWebDriver screenShotRemoteWebDriver = new ScreenShotRemoteWebDriver();

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            screenShotRemoteWebDriver.TakeScreenshot(path, "ErrorScreenshot ");
        }

        public void CaptureElementScreenshot(IWebElement element)
        {
            string fileName = "ElementScreenshot " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss.jpg");
            byte[] byteArray = ((ITakesScreenshot)SF.Driver).GetScreenshot().AsByteArray;
            Bitmap screenShot = new Bitmap(new MemoryStream(byteArray));
            Rectangle croppedImage = new Rectangle(element.Location.X, element.Location.Y, element.Size.Width, element.Size.Height);

            screenShot = screenShot.Clone(croppedImage, screenShot.PixelFormat);
            screenShot.Save(string.Format(fileName, ImageFormat.Jpeg));
        }
    }
}
