using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
namespace ViperAutomation.Utility
{
        class BrowserFactory
        {
            private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
            private static IWebDriver driver;

            public static IWebDriver Driver
            {
                get
                {
                    if (driver == null)
                        throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                    return driver;
                }
                private set
                {
                    driver = value;
                }
            }

            public static void InitBrowser(string browserName)
            {
                switch (browserName)
                {
                    case "Firefox":

                            new DriverManager().SetUpDriver(new FirefoxConfig());
                            driver = new FirefoxDriver();
                            Drivers.Add("Firefox", Driver);
                     
                        break;

                    case "IE":
                            new DriverManager().SetUpDriver(new InternetExplorerConfig());
                            driver = new InternetExplorerDriver();
                            Drivers.Add("IE", Driver);
                      
                        break;

                    case "Chrome":
                       
                            new DriverManager().SetUpDriver(new ChromeConfig());
                            driver = new ChromeDriver();
                            Drivers.Add("Chrome", Driver);
                       
                        break;
                   
            }
            
            }

            public static IWebDriver LoadApplication(string url)
            {
                Driver.Url = url;
                return Driver;
            }

            public static void CloseAllDrivers()
            {
                foreach (var key in Drivers.Keys)
                {
                    Drivers[key].Close();
                    Drivers[key].Quit();
                }
            }
        }
    }

