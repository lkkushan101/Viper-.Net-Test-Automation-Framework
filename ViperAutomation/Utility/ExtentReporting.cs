using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using System.IO;

namespace ViperAutomation.Utility
{
    class ExtentReporting
    {
        public static ExtentReports extRptDrv;
        private ExtentReports extent;
        ExtentReports report;
        ExtentHtmlReporter htmlReporter;
        // ExtentTest test;
        private static ExtentTest testCase;

       

        public object LogStatus { get; private set; }

        public void setupExtentReport(string reportName, string documentTitle)
        {



            string currentTime = DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");

            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;


            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));

            string projectPath = new Uri(actualPath).LocalPath;

            htmlReporter = new ExtentHtmlReporter(projectPath);
            htmlReporter.Config.Theme = Theme.Dark;
            htmlReporter.Config.DocumentTitle = documentTitle;
            htmlReporter.Config.ReportName = reportName ;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extRptDrv = extent;

        }

        public void createTest(string testName)
        {
            ExtentTest test;
            testCase = extent.CreateTest(testName);

        }

        public void logReportStatement(Status status, string message)
        {
            testCase.Log(status, message);
        }

        public void flushReport()
        {
            extent.Flush();
        }

       

        public void testStatusWithMsg(string status, string message)
        {
            if (status.Equals("Pass"))
            {
                testCase.Pass(message);
            }
            else
            {
                testCase.Fail(message);
            }
        }
    }
}
