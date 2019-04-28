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
    public class EditLanguageSteps
    {
        [When(@"Try to Edit the language and update")]
        public void WhenTryToEditTheLanguageAndUpdate()
        {
            Thread.Sleep(3000);
            //Click on Edit Button
            Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//i[@class='outline write icon']")).Click();
            Thread.Sleep(3000);
            //Click on Language Level

           // Driver.driver.FindElement(By.XPath("//select[@name='level']")).Click();
            Thread.Sleep(3000);
            //Choose the language level
           // IWebElement Lang = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option"))[3];
           // Lang.Click();
           
            Thread.Sleep(3000);
            //Click on Update Button
            Driver.driver.FindElement(By.XPath("//input[@class='ui teal button']")).Click();
        }

        [Then(@"that new language should be displayed on my listings")]
        public void ThenThatNewLanguageShouldBeDisplayedOnMyListings()
        {
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Edit a Language");
                //Start the Reports


                Thread.Sleep(1000);
                string ExpectedValue = "English";

                string ActualValue = Driver.driver.FindElement(By.XPath("//td[text()='English']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Editted a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageEditted");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.StackTrace);
            }


        }
    }
}
