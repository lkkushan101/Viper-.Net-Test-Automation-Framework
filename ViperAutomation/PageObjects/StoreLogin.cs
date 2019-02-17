using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace ViperAutomation.PageObjects
{
    class StoreLogin
    {

        private IWebDriver driver;

        [FindsBy(How = How.Name, Using = "uid")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "btnLogin")]
        public IWebElement Submit { get; set; }
    }
}
