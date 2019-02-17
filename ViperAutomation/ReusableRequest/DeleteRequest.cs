using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ViperAutomation.Utility;
namespace ViperAutomation.ReusableRequest
{
    class DeleteRequest
    {
        public void deleteRequest(string url)
        {
            ExtentReporting extRept = new ExtentReporting();
            var client = new RestClient(url);
            var request = new RestRequest("", Method.DELETE);
            IRestResponse response = client.Execute(request);
            extRept.setupExtentReport("Welcome to Viper", "Welcome to Viper");
            extRept.createTest("Delete Test");
            extRept.logReportStatement(AventStack.ExtentReports.Status.Pass, response.Content);
            extRept.flushReport();
        }
    }
}