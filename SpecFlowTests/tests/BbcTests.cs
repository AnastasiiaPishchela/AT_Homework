using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using SpecFlowTests.steps;
using System;
using System.IO;
using TechTalk.SpecFlow;

namespace SpecFlowTests.tests
{
    [Binding]
    public class BbcTests
    {
        private ChromeDriver driver;
        LoremIpsumSteps loremIpsumSteps;
        BbcPagesSteps bbcPagesSteps;
        UtilSteps utilSteps;
        string textToSet;

        [BeforeScenario()]
        public void Setup1()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            bbcPagesSteps = new BbcPagesSteps(driver);
        }

        [Given(@"User generates text with length (.*) symbols")]
        public void generateText(string length)
        {
            loremIpsumSteps = new LoremIpsumSteps(driver);
            textToSet = loremIpsumSteps.getLoremIpsumString(length);
        }

        [When(@"User navigates to question form on BBC, enter generated text and fill other fields with following details")]
        public void TestBbcQuestionsFormLorenIS140(Table table)
        {
            bbcPagesSteps.navigateToBbcDoYouHaveQuestionsPage();
            bbcPagesSteps.fillQuestionsForm(table.Rows[0]["name"], table.Rows[0]["email"], table.Rows[0]["age"], table.Rows[0]["postalCode"], textToSet.Substring(0, 140));
        }

        [Then(@"User takes screenshot")]
        public void takeScreenShot()
        {
            utilSteps = new UtilSteps(driver);
            utilSteps.takeScreenShot();
            string pathToFile = Environment.CurrentDirectory + "\\screenshot.png";
            Assert.IsTrue(File.Exists(pathToFile));
        }

        [When(@"User presses submit button")]
        public void pressSubmitButton()
        {
            bbcPagesSteps.submitQuestion();
        }

        [Then(@"User sees error '(.*)' for '(.*)' field")]
        public void checkErrorForEmailField(string expectedError, string fieldName)
        {
            string actualError = bbcPagesSteps.getErrorForField();
            Assert.AreEqual(expectedError, actualError, "Error message is not as expected for field " + fieldName);
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
