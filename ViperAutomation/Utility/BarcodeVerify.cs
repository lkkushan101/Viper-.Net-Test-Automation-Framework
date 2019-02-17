using NUnit.Framework;
using System;
using System.Drawing;
using ZXing;


namespace ViperAutomation.Utility
{
    class BarcodeVerify
    {
        public void testBarCode(String verificationText, String fileName)
        {
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;

            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));

            string projectPath = new Uri(actualPath).LocalPath;
            string filePath = projectPath+ "\\Barcodes\\"+ fileName;
            // create a barcode reader instance
            IBarcodeReader reader = new BarcodeReader();
            // load a bitmap
            var barcodeBitmap = (Bitmap)Bitmap.FromFile(filePath);
            // detect and decode the barcode inside the bitmap
            var result = reader.Decode(barcodeBitmap);
            // do something with the result
            if (result != null)
            {
                Assert.AreEqual(result.Text, verificationText);
                           
            }
        }
    }
}
