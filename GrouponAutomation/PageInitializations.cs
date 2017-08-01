using GrouponAutomation.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace GrouponAutomation
{
    public static class Pages
    {
        public static CreateaccountPage CreateaccountPage
        {
            get
            {
                var createaccount = new CreateaccountPage(ScenarioContext.Current.Get<IWebDriver>("IWebDriver"));
                
                return createaccount;
            }
        }
    }
}
