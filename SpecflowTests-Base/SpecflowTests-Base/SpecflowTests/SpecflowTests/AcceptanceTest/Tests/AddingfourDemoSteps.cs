using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;
using System.Collections.Generic;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class AddingfourDemoSteps
    {
        [When(@"I add more than four new languages (.*)")]
        public void WhenIAddMoreThanFourNewLanguages(String Language)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add four Languages");
                IList<IWebElement> Languages = Driver.driver.FindElements(By.XPath("//th[text()='Language']//ancestor::thead//following-sibling::tbody"));
                int count = Languages.Count();
                // String beforeXPath = "//th[contains(text(),'Language')]//ancestor::thead//following-sibling::tbody[";
                //String AfterXPath = "]/tr/td";
                IWebElement AddNewBtn = Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]"));

                for (int i = 1; i <= count; i++)
                {

                    if (AddNewBtn.Displayed)
                    {
                        Thread.Sleep(2000);
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
                    else
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, max four Languages");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "four Languages");
                    }
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Pass, "Test failed, four Languages");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "fourLanguages");
            }
        }

        [Then(@"fifth language should not get added")]
        public void ThenFifthLanguageShouldNotGetAdded()
        {

        }
    }

}
