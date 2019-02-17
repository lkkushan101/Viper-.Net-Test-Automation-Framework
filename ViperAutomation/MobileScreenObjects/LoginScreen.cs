using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace ViperAutomation.MobileScreenObjects
{
    class LoginScreen
    {

        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "com.experitest.ExperiBank:id/usernameTextField")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "com.experitest.ExperiBank:id/passwordTextField")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "com.experitest.ExperiBank:id/loginButton")]
        public IWebElement Submit { get; set; }

    }
}
