using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace ViperAutomation.Utility
{
    class ReadOCR
    {
        public String OCRToText(String imagePath, String testDataPath)
        {
            var image = new Bitmap(imagePath);
            var ocrtext = string.Empty;
            using (var engine = new TesseractEngine(testDataPath, "eng", EngineMode.Default))
            {
                using (var img = PixConverter.ToPix(image))
                {
                    using (var page = engine.Process(img))
                    {
                        return ocrtext = page.GetText();
                       
                    }
                }
            }
        }
    }
}
