using System;
using System.Text;
using Globant.Selenium.Axe;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Hyperlinq;
using System.IO;
using System.Reflection;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace ViperAutomation.Utility
{
    class Accessibility
    {
        public void testAccessibility(String url)
        {

            new DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver webDriver = new ChromeDriver();
            
            DirectoryInfo assemblyPath = new DirectoryInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            DirectoryInfo binPath = Directory.GetParent(assemblyPath.ToString());
            DirectoryInfo solutionPath = Directory.GetParent(binPath.ToString());

            webDriver.Url = url;

            //excelRead.readExcel(Directory.GetParent(binPath.ToString()) + "\\Accessibility_Data\\URLList.xlsx", "Sheet1", 1, 2); 
            string currentTime = DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");
            AxeResult results = webDriver.Analyze();
            using (FileStream fs = new FileStream(Directory.GetParent(binPath.ToString()) + "\\Accessibility_Reports\\" + currentTime + ".html", FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    w.WriteLine(H.head(
                    H.title("Viper Test Automation Accessibility Report for " + webDriver.Url),
                    H.h1("Viper Test Automation Accessibility Report for " + webDriver.Url),
                    H.link(a => a.href("/favicon.ico")
                      .rel("shortcut icon")
                      .type("image/x-icon"))
                ));
                    foreach (var entries in results.Violations)
                    {
                        w.WriteLine(H.body(
                        H.h3(entries.Impact.ToString()),
                        H.h5(entries.Description.ToString()),
                        H.h5(entries.Id.ToString())
                        ));
                    }
                }
            }
            webDriver.Close();
        }
    }
}