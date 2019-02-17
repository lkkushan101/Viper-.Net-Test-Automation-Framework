using System;

using NUnit.Framework;
using ViperAutomation.Utility;

namespace ViperAutomation.TestCases
{
    
    class TestCaseBrowserMob
    {

        [Test]
        public void testMob()
        {
            string BrowserMobPath = "D:\\browsermob-proxy-2.1.4-bin\\browsermob-proxy-2.1.4\\bin\\browsermob-proxy";
            ClientSidePerformance cli = new ClientSidePerformance();
            cli.captureClientSidePerformance(BrowserMobPath,"http:\\www.trc.gov.lk");
        }
    }
}
