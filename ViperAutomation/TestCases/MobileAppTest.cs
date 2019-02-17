using System;

using OpenQA.Selenium; /* Appium is based on Selenium, we need to include it */
using ViperAutomation.Utility;
using ViperAutomation.MobileScreenObjects;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;

namespace ViperAutomation.TestCases
{
    class MobileAppTest
    {
        public IWebDriver driver;
        [Test]
        public void testMobile()
        {
            JSONReader jsonRead = new JSONReader();
            MobileDriverStart ms = new MobileDriverStart();
            driver = ms.startMobileDriver();
            var loginPage = new LoginScreen();
            PageFactory.InitElements(driver, loginPage);
            loginPage.UserName.SendKeys(jsonRead.jsonReader("../ViperAutomation/Data/MobileData.json", "User"));
            loginPage.Password.SendKeys(jsonRead.jsonReader("../ViperAutomation/Data/MobileData.json", "User"));
            loginPage.Submit.Click();
            var makePayment = new MakePaymentScreen();
            PageFactory.InitElements(driver, makePayment);

            makePayment.MakePaymentBtn.Click();
        }
    }
}
