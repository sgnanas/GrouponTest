using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Configuration;
using TechTalk.SpecRun.Common.Helper;
using System.Reflection;

namespace GrouponAutomation.Hooks
{
    [Binding]
    public class Hooks1
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
           
            string browser = string.Empty;

            try
            {
                if (ConfigurationManager.AppSettings["Browser"].ToLower().IsNotNullOrEmpty())
                {
                    browser = ConfigurationManager.AppSettings["Browser"].ToLower();
                }

            }

            catch (Exception ex)
            {
                browser = string.Empty;
                Console.WriteLine(ex.Message);
            }
            ScenarioContext.Current.Set(
               GetWebDriver(browser),
               "IWebDriver");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //Close the Driver
            ScenarioContext.Current.Get<IWebDriver>("IWebDriver")
                .Close();

        }

        public static IWebDriver GetWebDriver(string browser)
        {
            ChromeOptions options = new ChromeOptions();
            IWebDriver driver;

            switch (browser)
            {
                case "chrome":

                    // Open a Chrome browser.
                    options = new ChromeOptions();
                    options.AddArguments("--disable-extensions");
                    options.AddArguments("disable-infobars");
                    options.AddUserProfilePreference("credentials_enable_service", false);

                    //Instantiate Driver
                    driver = new ChromeDriver(Path.Combine(GetBasePath, @"Drivers\"), options);

                    //Set Implicit Wait time to 10 seconds
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    break;

                default:

                    // Open a Chrome browser.
                    options = new ChromeOptions();
                    options.AddArguments("--disable-extensions");
                    options.AddArguments("disable-infobars");
                    options.AddUserProfilePreference("credentials_enable_service", false);

                    //Instantiate Driver
                    driver = new ChromeDriver(Path.Combine(GetBasePath, @"Drivers\"), options);

                    //Set Implicit Wait time to 10 seconds
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    break;

            }

            return driver; 
           
        }


        public static string GetBasePath
        {
            get
            {
                var basePath =
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                basePath = basePath.Substring(0, basePath.Length - 10);
                return basePath;
            }
        }
    }
}


    