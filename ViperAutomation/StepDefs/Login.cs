using System;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using ViperAutomation.PageObjects;
using ViperAutomation.Utility;
using NUnit.Framework;
namespace ViperAutomation.StepDefs
{
    [Binding]
    public class BankLoginSteps
    {
        ExtentReporting exp = new ExtentReporting();
        IWebDriver driver;
        JSONReader jsonRead = new JSONReader();
        [Given(@"I'm in the bank URL")]
        public void GivenIMInTheBankURL()
        {
         
            driver = new ChromeDriver();


            driver.Url = jsonRead.jsonReader("json1.json", "URL");
        }
        
        [When(@"I enter the user name and the password")]
        public void WhenIEnterTheUserNameAndThePassword()
        {
            exp.setupExtentReport("Welcome to Viper", "Welcome to Viper");
            exp.createTest("Guru 99 Login");
            var loginPage = new StoreLogin();
            PageFactory.InitElements(driver, loginPage);
            loginPage.UserName.SendKeys(jsonRead.jsonReader("json1.json", "User_Name"));
            loginPage.Password.SendKeys(jsonRead.jsonReader("json1.json", "password"));
            loginPage.Submit.Submit();
        }
        
        [Then(@"I should succesfully login")]
        public void ThenIShouldSuccesfullyLogin()
        {
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            Assert.AreEqual(homePage.MyAccount.Text, "Guru99 Bank");
            exp.logReportStatement(AventStack.ExtentReports.Status.Pass, "Successfully Logged in");
            exp.flushReport();
            driver.Close();
        }
    }
}

           



          