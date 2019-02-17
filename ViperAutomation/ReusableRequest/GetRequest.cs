using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Collections.Generic;
using ViperAutomation.Utility;

namespace ViperAutomation.ReusableRequest
{

    class GetRequest
    {
        public void getRequest(string url)
        {

            ExtentReporting extRept = new ExtentReporting();
            var client = new RestClient(url);
            var request = new RestRequest("", Method.GET);
            IRestResponse response = client.Execute(request);
            extRept.setupExtentReport("Welcome to Viper", "Welcome to Viper");
            extRept.createTest("Get Test");
            extRept.logReportStatement(AventStack.ExtentReports.Status.Pass, response.Content);
            extRept.flushReport();
        }
    }
}