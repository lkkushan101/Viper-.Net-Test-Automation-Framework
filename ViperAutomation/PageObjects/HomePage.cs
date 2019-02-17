using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace ViperAutomation.PageObjects
{
   
        class HomePage
        {
            private IWebDriver driver;

            [FindsBy(How = How.XPath, Using = "/html/body/div[2]/h2")]
            public IWebElement MyAccount { get; set; }
        }
  
}
