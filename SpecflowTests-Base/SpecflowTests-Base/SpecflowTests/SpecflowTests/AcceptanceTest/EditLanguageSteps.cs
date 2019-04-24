using OpenQA.Selenium;
using SpecflowPages;
using System.Threading;
using TechTalk.SpecFlow;

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
           
            //Click on Language Level

            Driver.driver.FindElement(By.XPath("//select[@name='level']")).Click();
            Thread.Sleep(3000);
            //Choose the language level
            IWebElement Lang = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option"))[1];
            Lang.Click();
            Thread.Sleep(3000);
            //Click on Update Button
            Driver.driver.FindElement(By.XPath("//input[@class='ui teal button']")).Click();
        }

        [Then(@"that new language should be displayed on my listings")]
        public void ThenThatNewLanguageShouldBeDisplayedOnMyListings()
        {
            
        }
    }
}
