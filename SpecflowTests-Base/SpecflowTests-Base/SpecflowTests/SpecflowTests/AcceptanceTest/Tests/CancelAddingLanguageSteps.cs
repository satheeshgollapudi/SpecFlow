using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class CancelAddingLanguageSteps
    {
        [When(@"I cancel adding a new language")]
        public void WhenICancelAddingANewLanguage()
        {
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")).Click();

            //Add Language

            Driver.driver.FindElement(By.XPath("//input[@name='name']")).SendKeys("french");

            //Click on Language Level
            Thread.Sleep(3000);
            Driver.driver.FindElement(By.XPath("//select[@name='level']")).Click();

            Thread.Sleep(3000);
            //Choose the language level
            IWebElement lang = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option"))[3];
            lang.Click();

            //Click on Cancel Button
            Thread.Sleep(3000);
           
           Driver.driver.FindElement(By.XPath("//input[@value='Cancel']")).Click();
            Thread.Sleep(3000);

        }
        [Then(@"cancelled language should not be displayed on my listings")]
        public void ThenCancelledLanguageShouldNotBeDisplayedOnMyListings()
        {
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("cancel addind a Language");
                //Start the Reports

                IList<IWebElement> Languages = Driver.driver.FindElements(By.XPath("//th[text()='Language']//ancestor::thead//following-sibling::tbody"));
                int count = Languages.Count();
                String beforeXPath = "//th[contains(text(),'Language')]//ancestor::thead//following-sibling::tbody[";
                String AfterXPath = "]/tr/td";
                bool LangFound;

                for (int i = 0; i <= count; i++)
                {

                    if (Driver.driver.FindElement(By.XPath(beforeXPath + i + AfterXPath)).Text == "french")
                    {
                        LangFound = true;
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                    }
                    else
                    {
                        LangFound = false;
                        Console.WriteLine("Adding language cancelled successfully");
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Cancelled a Language Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageCancelled");
                    }

                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

    }

}

