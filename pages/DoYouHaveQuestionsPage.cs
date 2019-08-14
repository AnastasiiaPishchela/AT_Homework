using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowTests.pages
{
    public class DoYouHaveQuestionsPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Name']")]
        private IWebElement nameField;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email address']")]
        private IWebElement emailAddressField;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Age']")]
        private IWebElement ageField;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Postcode']")]
        private IWebElement postCodeField;
        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='What questions would you like us to investigate?']")]
        private IWebElement questionToInvestigateField;
        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']")]
        private IWebElement signMeUpForBBCNewsDailyCheckbox;
        [FindsBy(How = How.XPath, Using = "//button[@class='button']")]
        private IWebElement SubmitButton;
        [FindsBy(How = How.XPath, Using = "//div[@class='input-error-message']")]
        private IWebElement EmptyFieldError;
        

        public DoYouHaveQuestionsPage(IWebDriver driver) : base(driver) { }

        public void typeTextToNameField(string text)
        {
            nameField.SendKeys(text);
        }

        public void typeTextToEmailAddressField(string text)
        {
            emailAddressField.SendKeys(text);
        }

        public void typeTextToAgeField(string text)
        {
            ageField.SendKeys(text);
        }

        public void typeTextToPostCodeField(string text)
        {
            postCodeField.SendKeys(text);
        }

        public void typeTextToQuestionToInvestigateField(string text)
        {
            questionToInvestigateField.SendKeys(text);
        }

        public void clickOnSignMeUpForBBCNewsDailyCheckbox()
        {
            signMeUpForBBCNewsDailyCheckbox.Click();
        }

        public void clickOnSubmitButton()
        {
            SubmitButton.Click();
        }

        public string getErrorEmptyField()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => EmptyFieldError.Displayed);
            return EmptyFieldError.Text;
        }

    }
}
