using OpenQA.Selenium;
using SpecFlowTests.pages;

namespace SpecFlowTests.steps
{
    public class LoremIpsumSteps
    {
        private IWebDriver driver;
        public LoremIpsumSteps(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string getLoremIpsumString(string length)
        {
            LorenIpsumPage lorenIpsumPage = new LorenIpsumPage(driver);
            lorenIpsumPage.goToPage();
            lorenIpsumPage.setAmountField(length);
            lorenIpsumPage.clickOnBytesRadioButton();
            LoremIpsumFeedPage loremIpsumFeedPage = lorenIpsumPage.clickGenerateButton();
            return loremIpsumFeedPage.getGeneratedText();
        }
    }
}
