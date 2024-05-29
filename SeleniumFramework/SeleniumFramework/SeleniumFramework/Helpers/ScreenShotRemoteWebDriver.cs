using OpenQA.Selenium;
using System;
using System.IO;

namespace SeleniumFramework.SeleniumFramework.Helpers
{
    public class ScreenShotRemoteWebDriver
    {
        public void TakeScreenshot()
        {
            string screenshotPath = @"C:\Netacent\NetacentStartFramework\Screenshots";
            string filename = "SeleniumScreenshot" + "-" + DateTime.Now.ToString("ddMMyy-HHmmss");

            TakeScreenshot(screenshotPath, filename);
        }

        public void TakeScreenshot(string fileName)
        {
            TakeScreenshot(Path.GetTempPath());
        }

        public void TakeScreenshot(string path, string fileName)
        {
            var screenshotDriver = SF.Driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            string fileExtension = ".jpg";

            fileName = fileName + "_" + DateTime.Now.ToString("ddMMyy-HHmmss");
            screenshot.SaveAsFile(Path.Combine(path, fileName + fileExtension));

            Console.WriteLine("Captured: {0}", Path.Combine(path, fileName));
        }
    }
}
