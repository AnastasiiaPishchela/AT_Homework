using OpenQA.Selenium;

namespace SpecFlowTests.steps
{
    class UtilSteps
    {
        private IWebDriver driver;
        public UtilSteps(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void takeScreenShot()
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("screenshot.png", ScreenshotImageFormat.Png);
        }
    }
}
