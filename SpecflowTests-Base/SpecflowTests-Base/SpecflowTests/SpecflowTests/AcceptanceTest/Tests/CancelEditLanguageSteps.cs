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
    public class CancelEditLanguageSteps
    {
        [When(@"I tried to click on Edit and click on cancel button")]
        public void WhenITriedToClickOnEditAndClickOnCancelButton()
        {
            Thread.Sleep(3000);
            //Click on Edit  

            Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//i[@class='outline write icon']")).Click();

            Thread.Sleep(3000);
            //Cancel Button
            Driver.driver.FindElement(By.XPath("//input[@class='ui button']")).Click();
        }
        
        [Then(@"that same language details should be displayed on my listing")]
        public void ThenThatSameLanguageDetailsShouldBeDisplayedOnMyListing()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Cancel Edit Language");

                Thread.Sleep(1000);
                string ExpectedValue = "English";

                string ActualValue = Driver.driver.FindElement(By.XPath("//td[text()='English']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Cancel Edit Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Cancelled Edit");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }




        }
    }
}
