using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowTests.pages
{
    public class LoremIpsumFeedPage : BasePage
    {

        [FindsBy(How = How.Id, Using = "lipsum")]
        private IWebElement generatedTextElement;

        public LoremIpsumFeedPage(IWebDriver driver) : base(driver) { }
        public string getGeneratedText()  // метод класса
        {
            return generatedTextElement.Text;
        }
    }
}
