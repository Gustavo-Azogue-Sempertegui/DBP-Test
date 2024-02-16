using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoDi;
using System.Runtime.CompilerServices;

namespace DBPE2E.Support
{
    public sealed class Setup
    {
        private string base_url = string.Empty;
        public WebDriver driver;
        public Setup() 
        {
            string projectRoot = AppContext.BaseDirectory.Substring(AppContext.BaseDirectory.IndexOf("bin"));
            string paramsPath = Path.Combine(projectRoot, @"Params.json");
            string paramsText = File.ReadAllText(paramsPath);
            var RuntimeParams = JsonConvert.DeserializeObject<dynamic>(paramsText);
            string environment = RuntimeParams.Params.Environment.ToString();
            string browserName = RuntimeParams.Params.BrowserName.ToString();

            switch (environment)
            {
                case "test":
                default:
                    base_url = "https://www.demoblaze.com/";
                    break;
            }

            switch (browserName)
            {
                case "FireFox":
                    this.driver = new FirefoxDriver();
                    break;
                case "IE":
                    this.driver = new InternetExplorerDriver();
                    break;
                case "Edge":
                    this.driver = new EdgeDriver();
                    break;
                case "Chrome":
                default:
                    this.driver = new ChromeDriver();
                    break;
            }
        }

        public string BaseUrl
        {
            get => base_url;
        }

        private static readonly object locker = new object();
        private static Setup? instance = null;

        public static Setup Instance
        {
            get
            {
                lock (locker)
                {
                    if(instance == null)
                    {
                        instance = new Setup();
                    }

                    return instance;
                }
            }
        }
    }
}
