using System;
using System.Drawing;
using XnaFan.ImageComparison;

namespace ViperAutomation.Utility
{
    class ImageCompare
    {
        public float ImageComparing(String sourceImagePath, String destinationImagePath)
        {
            Bitmap firstBmp = (Bitmap)Image.FromFile(sourceImagePath);
            Bitmap secondBmp = (Bitmap)Image.FromFile(destinationImagePath);
            return firstBmp.PercentageDifference(secondBmp);
        }
    }
}
