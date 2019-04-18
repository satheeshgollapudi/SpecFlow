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
    public class SkillsTab_ProfilePageSteps
    {
        [Given(@"I clicked on the skills tab under Profile page")]
        public void GivenIClickedOnTheSkillsTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
          
        }

        [When(@"I add a new skill")]
        public void WhenIAddANewSkill()
        {
            Thread.Sleep(1000); 
            //Click on Skill Tab
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Skills')]")).Click();

            Thread.Sleep(3000);
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//div[@class='ui teal button']")).Click();

            //Add Skill
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).SendKeys("Manual");

            //Click on Skill Level
            Driver.driver.FindElement(By.XPath("//select[@name='level']")).Click();

            //Choose the Skill level
            IWebElement skill = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option"))[2];
                                                                     //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option"))[2];
            skill.Click();

            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();

        }

        [Then(@"that skill should be displayed on my listings")]
        public void ThenThatSkillShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Skill");

                Thread.Sleep(1000);
                string ExpectedValue = "Manual";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Manual')]")).Text;

                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Skill Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillAdded");
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
