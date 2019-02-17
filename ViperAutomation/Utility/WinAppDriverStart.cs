using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViperAutomation.Utility
{
    class WinAppDriverStart
    {
        public dynamic StartWindowsApp (String WinAppDrvURL, String Application)
        {
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", Application);
            var CalculatorSession = new RemoteWebDriver(new Uri(WinAppDrvURL), appCapabilities);
            return CalculatorSession;
        }
    }
}
