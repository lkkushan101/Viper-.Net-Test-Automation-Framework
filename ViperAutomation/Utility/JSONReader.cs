using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace ViperAutomation.Utility
{
    class JSONReader
    {
        public string jsonReader(string fileName, object itemName)
        {
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;


            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));

            string projectPath = new Uri(actualPath).LocalPath;
            string reportPath = projectPath + fileName;


            // read JSON directly from a file
            StreamReader file = File.OpenText(reportPath);

            JsonTextReader reader = new JsonTextReader(file);
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);

                dynamic fileContents = JArray.Parse("[" + o2.ToString() + "]");
                dynamic fileContent = fileContents[0];




                var value = o2[itemName].ToString();


                return value;
            }
        }
    }
}

