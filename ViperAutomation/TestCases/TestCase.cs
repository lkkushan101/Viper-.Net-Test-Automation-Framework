using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ViperAutomation.PageObjects;
using ViperAutomation.Utility;
using NUnit.Framework;
namespace ViperAutomation.TestCases
{
    class TestCase
    {

        [Test]
        public void Test()
        {
            JSONReader jsonRead = new JSONReader();
            SpeechReporter spr = new SpeechReporter();
            IWebDriver driver ;
            BrowserFactory.InitBrowser("Chrome");
            driver = BrowserFactory.LoadApplication(jsonRead.jsonReader("../ViperAutomation/Data/json1.json", "URL"));

            
            ExtentReporting exp = new ExtentReporting();

            exp.setupExtentReport("Welcome to Viper", "Welcome to Viper");
            exp.createTest("Guru 99 Login");
            var loginPage = new StoreLogin();
            PageFactory.InitElements(driver, loginPage);
            spr.SpeechReport("Navigated to Guru 99 Login Page");
            loginPage.UserName.SendKeys(jsonRead.jsonReader("../ViperAutomation/Data/json1.json", "User_Name"));
            loginPage.Password.SendKeys(jsonRead.jsonReader("../ViperAutomation/Data/json1.json", "password"));
            loginPage.Submit.Submit();

            spr.SpeechReport("Logged in Successfully");
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            Assert.AreEqual(homePage.MyAccount.Text, "Guru99 Bank");
            exp.logReportStatement(AventStack.ExtentReports.Status.Pass, "Successfully Logged in");
            exp.flushReport();
            BrowserFactory.CloseAllDrivers();
        }
    }
}
