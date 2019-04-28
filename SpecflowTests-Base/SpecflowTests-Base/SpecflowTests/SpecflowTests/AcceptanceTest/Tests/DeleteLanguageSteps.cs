﻿using OpenQA.Selenium;
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
    public class DeleteLanguageSteps
    {
        [When(@"Try to Delete the language")]
        public void WhenTryToDeleteTheLanguage()
        {
            IList<IWebElement> Languages = Driver.driver.FindElements(By.XPath("//th[text()='Language']//ancestor::thead//following-sibling::tbody"));
            int count = Languages.Count();
            String beforeXPath = "//th[contains(text(),'Language')]//ancestor::thead//following-sibling::tbody[";
            String AfterXPath = "]/tr/td";
            bool LangFound;

            for (int i = 1; i <= count; i++)
            {

                if (Driver.driver.FindElement(By.XPath(beforeXPath + i + AfterXPath)).Text == "English")

                    Thread.Sleep(3000);
                Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//i[@class='remove icon']")).Click();

            }
        }



        [Then(@"that language should not be displayed on my listings")]
        public void ThenThatLanguageShouldNotBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete a Language");



                IList<IWebElement> Languages = Driver.driver.FindElements(By.XPath("//th[text()='Language']//ancestor::thead//following-sibling::tbody"));
                int count = Languages.Count();
                String beforeXPath = "//th[contains(text(),'Language')]//ancestor::thead//following-sibling::tbody[";
                String AfterXPath = "]/tr/td";
                bool LangFound;

                for (int i = 1; i <= count; i++)
                {

                    if (Driver.driver.FindElement(By.XPath(beforeXPath + i + AfterXPath)).Text == "English")
                    {
                        LangFound = true;
                    }
                    else
                    {
                        LangFound = false;
                        Console.WriteLine("language deleted successfully");
                    }
                    if (LangFound)
                    {
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                    }
                    else
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted a Language Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageDeleted");
                    }

                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
            }
        }
    }

}

