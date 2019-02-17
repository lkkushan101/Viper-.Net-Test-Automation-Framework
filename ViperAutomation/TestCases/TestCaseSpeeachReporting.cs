using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace ViperAutomation.TestCases
{
    class TestCaseSpeeachReporting
    {
        [Test]
        public void speechTest()
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -2;     // -10...10

            // Synchronous
            synthesizer.Speak("Hello World");

            // Asynchronous
            synthesizer.SpeakAsync("Hello World");

        }
    }
}
