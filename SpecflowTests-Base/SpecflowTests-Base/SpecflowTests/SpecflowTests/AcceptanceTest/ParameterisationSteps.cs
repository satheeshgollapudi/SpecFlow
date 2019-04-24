using OpenQA.Selenium;
using SpecflowPages;
using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class ParameterisationSteps
    {
        [When(@"I add a new language '(.*)' by using parameter")]
        public void WhenIAddANewLanguageByUsingParameter(string Language)
        {

            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys(Language);

        }
      

        }

    }

