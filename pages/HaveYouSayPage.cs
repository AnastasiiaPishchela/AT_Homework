using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowTests.pages
{
    public class HaveYouSayPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "(//a[contains(@href,'/news/uk-47933096')])[3]")]  //By. LinkText'....'"(//a[contains(@href,'/news/uk-47933096')])[3]"
        private IWebElement doYourHaveQuestionsLink;
        public HaveYouSayPage(IWebDriver driver) : base(driver) { }

        public DoYouHaveQuestionsPage openDoYouHaveQuestionsPage()
        {
            doYourHaveQuestionsLink.Click();
            return new DoYouHaveQuestionsPage(driver);
        }
    }
}
