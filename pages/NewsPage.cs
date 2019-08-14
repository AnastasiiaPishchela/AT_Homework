using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowTests.pages
{
    public class NewsPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='orb-modules']/header/div[2]/div/div[1]/nav/ul/li[15]/span/button/span[1]")]
        private IWebElement moreMenu;
        [FindsBy(How = How.XPath, Using = "//*[@id='orb-modules']/header/div[2]/div/div[2]/div/div/ul[4]/li/a/span")]
        private IWebElement haveYourSayLink;

        public NewsPage(IWebDriver driver) : base(driver) { }

        public void openMoreMenu()
        {
            moreMenu.Click();
        }

        public HaveYouSayPage openHaveYourSayPage()
        {
            haveYourSayLink.Click();
            return new HaveYouSayPage(driver);
        }
    }
}
