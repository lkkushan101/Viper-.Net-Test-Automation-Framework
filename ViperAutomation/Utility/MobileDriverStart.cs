using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViperAutomation.Utility
{
    class MobileDriverStart
    {
        public IWebDriver startMobileDriver()
        {
            IWebDriver driver;
            JSONReader jsonRead = new JSONReader();
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("platformName", jsonRead.jsonReader("../ViperAutomation/Data/MobileData.json", "platformName"));
            // capabilities.SetCapability("platformVersion", "8.1");
            // capabilities.SetCapability("platform", "Mac");
            capabilities.SetCapability("deviceName", jsonRead.jsonReader("../ViperAutomation/Data/MobileData.json", "deviceName"));
            capabilities.SetCapability("appPackage", jsonRead.jsonReader("../ViperAutomation/Data/MobileData.json", "appPackage"));
            capabilities.SetCapability("appActivity", jsonRead.jsonReader("../ViperAutomation/Data/MobileData.json", "appActivity"));
            //Connecting to Appium Server
            driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
            return driver;
        }
    }
}
