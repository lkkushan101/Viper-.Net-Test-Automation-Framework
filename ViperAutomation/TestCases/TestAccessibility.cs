using NUnit.Framework;
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
