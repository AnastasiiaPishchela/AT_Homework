using OpenQA.Selenium;
using SpecFlowTests.pages;

namespace SpecFlowTests.steps
{
    class BbcPagesSteps
    {
        private IWebDriver driver;
        DoYouHaveQuestionsPage doYouHaveQuestionsPage;
        BBCHomePage homePage;
        NewsPage newsPage;
        HaveYouSayPage haveYouSayPage;


        public BbcPagesSteps(IWebDriver driver)
        {
            this.driver = driver;
            doYouHaveQuestionsPage = new DoYouHaveQuestionsPage(driver);
            homePage = new BBCHomePage(driver);
        }
        public void navigateToBbcDoYouHaveQuestionsPage()
        {
            homePage.goToPage();
            newsPage = homePage.openNewsPage();
            newsPage.openMoreMenu();
            haveYouSayPage = newsPage.openHaveYourSayPage();
            haveYouSayPage.openDoYouHaveQuestionsPage();
        }

        public void fillQuestionsForm(string name, string email, string age, string postCode, string question)
        {
            doYouHaveQuestionsPage = new DoYouHaveQuestionsPage(driver);
            doYouHaveQuestionsPage.typeTextToNameField(name);
            doYouHaveQuestionsPage.typeTextToEmailAddressField(email);
            doYouHaveQuestionsPage.typeTextToAgeField(age);
            doYouHaveQuestionsPage.typeTextToPostCodeField(postCode);
            doYouHaveQuestionsPage.typeTextToQuestionToInvestigateField(question);
            doYouHaveQuestionsPage.clickOnSignMeUpForBBCNewsDailyCheckbox();
        }

        public void submitQuestion()
        {
            doYouHaveQuestionsPage.clickOnSubmitButton();
        }

        public string getErrorForField()
        {
            return doYouHaveQuestionsPage.getErrorEmptyField();
        }

    }
}
