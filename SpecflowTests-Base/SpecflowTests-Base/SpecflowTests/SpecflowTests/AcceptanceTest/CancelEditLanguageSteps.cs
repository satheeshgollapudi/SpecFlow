using OpenQA.Selenium;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

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
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();
            //*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i
            //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[1]/i
            Driver.driver.FindElement(By.XPath("//input[@value='Cancel']")).Click();
        }
        
        [Then(@"that same language details should be displayed on my listing")]
        public void ThenThatSameLanguageDetailsShouldBeDisplayedOnMyListing()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
