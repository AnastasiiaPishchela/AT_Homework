using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowTests.pages
{
    public class LorenIpsumPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "amount")]
        private IWebElement amountField;
        [FindsBy(How = How.Id, Using = "bytes")]
        private IWebElement bytesRadioButton;
        [FindsBy(How = How.Id, Using = "generate")]
        private IWebElement generateButton;
        public LorenIpsumPage(IWebDriver driver) : base(driver) { }

        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://www.lipsum.com");
        }

        public void setAmountField(string amount)
        {
            amountField.Clear();
            amountField.SendKeys(amount);
        }

        public void clickOnBytesRadioButton()
        {
            bytesRadioButton.Click();
        }

        public LoremIpsumFeedPage clickGenerateButton()
        {
            generateButton.Click();
            return new LoremIpsumFeedPage(driver);
        }

    }
}
