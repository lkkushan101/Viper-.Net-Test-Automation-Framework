using NUnit.Framework;
using ViperAutomation.Utility;

namespace ViperAutomation.TestCases
{
   
    class ReadBarcodeTest
    {
        private object txtDecoderType;

        [Test]
        public void testBarCode()
        {
            BarcodeVerify BF = new BarcodeVerify();
            BF.testBarCode("671860013624", "download.png");
        }
  }
}
