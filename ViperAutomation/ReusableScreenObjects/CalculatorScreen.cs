using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViperAutomation.ReusableScreenObjects
{
    class CalculatorScreen
    {
        public void buttonClick (String Button_Caption, dynamic Session)
        {
            Session.FindElementByName(Button_Caption).Click();
        }
    }
}
