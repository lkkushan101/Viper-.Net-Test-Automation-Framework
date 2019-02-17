using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using NUnit.Framework;
using ViperAutomation.Utility;

namespace ViperAutomation.TestCases
{
    class OCRTest
    {
       [Test]

        public void testOCR ()
        {
            ReadOCR ocr = new ReadOCR();

            ocr.OCRToText("D:\\ss.png", "D:\\Tesseract-OCR\\tessdata");
            Console.WriteLine(ocr.OCRToText("D:\\ss.png", "D:\\Tesseract-OCR\\tessdata"));
        }
     
    }
}
