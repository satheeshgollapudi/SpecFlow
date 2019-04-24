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
    public class CertificateTabProfilePageSteps
    {
        [Given(@"I clicked on the Certifications tab under Profile page")]
        public void GivenIClickedOnTheCertificationsTabUnderProfilePage()
        {

            // Click on Profile tab
            // Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
            //Wait
            Thread.Sleep(3000);

            // Click on Certification tab
            Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[4]")).Click();
            
        }
        
        [When(@"I add a new Certification")]
        public void WhenIAddANewCertification()
        {
            //Click on Add new Button
            Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[4]/div[1]")).Click();
            //Certificate
            Driver.driver.FindElement(By.Name("certificationName")).SendKeys("Excel");
            //Certified From
            Driver.driver.FindElement(By.XPath("//input[@name='certificationFrom']")).SendKeys("MICROSOFT");
            //Click on year
            Driver.driver.FindElement(By.Name("certificationYear")).Click();
           
            //Choose Skill Level
            IWebElement certification = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option"))[5];
                                                                             
            certification.Click();
            //Click on Add Button
            Driver.driver.FindElement(By.XPath("//div[@class='five wide field']//input[@value='Add']")).Click();
        }

        [Then(@"that Certifcation should be displayed on my listings")]
        public void ThenThatCertifcationShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Certificate");

                Thread.Sleep(1000);
                string ExpectedValue = "Excel";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[contains(text(),'Excel')]")).Text;

                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Certificate Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Certificate Added");
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
