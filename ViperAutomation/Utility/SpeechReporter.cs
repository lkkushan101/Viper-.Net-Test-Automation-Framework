using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace ViperAutomation.Utility
{
    class SpeechReporter
    {
        public void SpeechReport(string reportingContent)
        { 
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -2;     // -10...10

            // Synchronous
            synthesizer.Speak(reportingContent);

            // Asynchronous
           // synthesizer.SpeakAsync("Hello World");
        }
    }
}
