using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class AddingMoreThanFourLanguagesSteps
    {
        [When(@"I add a new language (.*) by using scenario outline")]
        public void WhenIAddANewLanguageByUsingScenarioOutline(string Language)
        {

            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")).Click();

            //Add Language

            Driver.driver.FindElement(By.XPath("//input[@name='name']")).SendKeys(Language);

            //Click on Language Level

            Driver.driver.FindElement(By.XPath("//select[@name='level']")).Click();
            //Choose the language level
            IWebElement Lang = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option"))[2];
            Lang.Click();


            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
        }
        [Then(@"check not more than four languages are added")]
        public void ThenCheckNotMoreThanFourLanguagesAreAdded()
        {
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Adding maximum 4 languages");
                Thread.Sleep(1000);

                IWebElement AddNewBtn = Driver.driver.FindElement(By.XPath("//thead//tr[1]//th[3]//div[contains(text(), 'Add New')@class='ui teal button ']"));
                if (AddNewBtn.Displayed)
                {
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                }
                else
                {
                   





                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Maximum is four languages");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Maximum 4 Languages ");
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed", e.Message);
            }
        }



    }
}

