using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace ViperAutomation.MobileScreenObjects
{
    class MakePaymentScreen
    {

        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "com.experitest.ExperiBank:id/makePaymentButton")]
        public IWebElement MakePaymentBtn { get; set; }

    }
}
