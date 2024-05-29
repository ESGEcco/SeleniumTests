using OpenQA.Selenium;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace SeleniumFramework.SeleniumFramework.Helpers
{
    public class CaptureScreenshots
    {
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
