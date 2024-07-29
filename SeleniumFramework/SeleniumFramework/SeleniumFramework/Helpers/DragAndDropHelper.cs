using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumFramework.SeleniumFramework.Helpers
{
    public class DragAndDropHelper : HelpersBase
    {
        public void DragAndDropElement(IWebElement fromElement, IWebElement toElement, IWebDriver driver)
        {
            Actions builder = new Actions(driver);

            IAction dragAndDrop = builder.ClickAndHold(fromElement).MoveToElement(toElement).Release(toElement).Build();

            dragAndDrop.Perform();
        }

        public void DragAndDropWithLocator(By fromLocator, By toLocator, IWebDriver driver)
        {
            IWebElement fromElement = driver.FindElement(fromLocator);
            IWebElement toElement = driver.FindElement(toLocator);
            Actions builder = new Actions(driver);

            IAction dragAndDrop = builder.ClickAndHold(fromElement).MoveToElement(toElement).Release(toElement).Build();

            dragAndDrop.Perform();

        }
    }
}
