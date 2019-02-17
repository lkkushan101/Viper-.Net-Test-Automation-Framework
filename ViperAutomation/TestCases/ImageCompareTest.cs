
using XnaFan.ImageComparison;
using NUnit.Framework;
using System;
using ViperAutomation.Utility;
using System.Drawing;

namespace ViperAutomation.TestCases
{
    class ImageCompareTest
    {

        [Test]
        public void test()
        {
            ImageCompare imc = new ImageCompare();
            float diff = imc.ImageComparing("D:\\download.jpg", "D:\\download.jpg");
           
            Console.WriteLine(diff.ToString());

        }
    }
}
