using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ViperAutomation.Utility;
namespace ViperAutomation.ReusableRequest
{
    class PutRequest
    {
        public void putRequest(string url, object body)
        {
            ExtentReporting extRept = new ExtentReporting();
            var client = new RestClient(url);
            var request = new RestRequest("", Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(body);

            client.Execute(request);
            IRestResponse response = client.Execute(request);
            extRept.setupExtentReport("Welcome to Viper", "Welcome to Viper");
            extRept.createTest("Put Test");
            extRept.logReportStatement(AventStack.ExtentReports.Status.Pass, response.Content);
            extRept.flushReport();
        }
    }
}