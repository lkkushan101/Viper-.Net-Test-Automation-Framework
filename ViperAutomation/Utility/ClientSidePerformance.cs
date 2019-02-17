using System;
using AutomatedTester.BrowserMob;
using AutomatedTester.BrowserMob.HAR;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.IO;
using Hyperlinq;
using System.Reflection;
using System.Text;

namespace ViperAutomation.Utility
{
    class ClientSidePerformance
    {
        public void captureClientSidePerformance(string browserMobProxyPath, string url_site)
        {
            Server server =
      new Server(
            browserMobProxyPath);
            server.Start();

            Client client = server.CreateProxy();
            client.RemapHost("host", "ip address");
            client.NewHar("google");

            var seleniumProxy = new Proxy { HttpProxy = client.SeleniumProxy };

            Proxy proxy = new Proxy();
            proxy.HttpProxy = seleniumProxy.HttpProxy;
            ChromeOptions options = new ChromeOptions();
            options.Proxy = proxy;


            IWebDriver driver = new ChromeDriver(options);
            // Navigate to the page to retrieve performance stats for
            //var driver = new FirefoxDriver(profile);
            driver.Navigate().GoToUrl(url_site);


            // Get the performance stats
            HarResult harData = client.GetHar();

            AutomatedTester.BrowserMob.HAR.Log log = harData.Log;
            AutomatedTester.BrowserMob.HAR.Entry[] entries = log.Entries;
            DirectoryInfo assemblyPath = new DirectoryInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            DirectoryInfo binPath = Directory.GetParent(assemblyPath.ToString());
            DirectoryInfo solutionPath = Directory.GetParent(binPath.ToString());
            string currentTime = DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");


            using (FileStream fs = new FileStream(Directory.GetParent(binPath.ToString()) + "\\ClientPerformace_Reports\\" + currentTime + ".html", FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    w.WriteLine(H.head(
                    H.title("Viper Test Automation Client Side Performance Report for " + driver.Url),
                    H.h1("Viper Test Automation Client Side Performance Report for " + driver.Url),
                    H.link(a => a.href("/favicon.ico")
                      .rel("shortcut icon")
                      .type("image/x-icon"))
                ));
                    foreach (var entry in entries)
                    {
                        AutomatedTester.BrowserMob.HAR.Request request = entry.Request;
                        var url = request.Url;
                        var time = entry.Time;

                        w.WriteLine(H.body(
                           H.h5("URL: " + request.Url + " - Time: " + entry.Time + " s")));
                    }
                }
            }



            driver.Close();
            client.Close();
            server.Stop();
        }
    }
 }

