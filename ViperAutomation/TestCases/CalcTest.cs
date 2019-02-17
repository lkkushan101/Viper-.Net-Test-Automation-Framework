using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViperAutomation.Utility;
using ViperAutomation.ReusableScreenObjects;
namespace ViperAutomation.TestCases
{
    class CalcTest
    {
        private dynamic CalculatorSession;

        [Test]
        public void test()
        {
            JSONReader jsonRead = new JSONReader();
            WinAppDriverStart wst = new WinAppDriverStart();
           
            CalculatorSession = wst.StartWindowsApp(jsonRead.jsonReader("../ViperAutomation/Data/WindowsConf.json", "Driver_URL"), jsonRead.jsonReader("../ViperAutomation/Data/WindowsConf.json", "Application_exe"));
            CalculatorScreen sc = new CalculatorScreen();
            sc.buttonClick("One", CalculatorSession);
            sc.buttonClick("Plus", CalculatorSession);
            sc.buttonClick("Seven", CalculatorSession);
            sc.buttonClick("Equals", CalculatorSession);
            
            CalculatorSession.Close();
           
        }
    }
}
