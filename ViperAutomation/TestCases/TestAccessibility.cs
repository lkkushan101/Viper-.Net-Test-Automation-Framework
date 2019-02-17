using CodeHouseTestAutomationFramework.Utility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViperAutomation.Utility;
namespace ViperAutomation.TestCases
{
    class TestAccessibility
    {
        Accessibility ac = new Accessibility();
       
        [Test]
        public void testAccessibility()
        {
            JSONReader JSR = new JSONReader();

            ac.testAccessibility(JSR.jsonReader("../ViperAutomation/Data/AccessibilityConf.json", "URL"));
        }
    }
}
