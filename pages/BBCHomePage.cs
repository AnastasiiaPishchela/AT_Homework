using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowTests.pages
{
    public class BBCHomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//li[@class='orb-nav-newsdotcom']/a")]
        private IWebElement newsLink;

        public BBCHomePage(IWebDriver driver) : base(driver) { }
        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://www.bbc.com");
        }

        public NewsPage openNewsPage()
        {
            newsLink.Click();
            return new NewsPage(driver);
        }
    }
}
