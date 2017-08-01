using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrouponAutomation.PageObjects
{
    public class CreateaccountPage
    {

        [FindsBy(How = How.Id, Using = "full-name-input")]
        IWebElement FullnameTextBox { get; set; }


        public IWebDriver WebDriver { get; set; }

        public CreateaccountPage(IWebDriver driver)
        {
            this.WebDriver = driver;
            PageFactory.InitElements(WebDriver, this);
        }


        public void typeFirstName()
        {
            FullnameTextBox.SendKeys("aaaaa");
        }
    }
}
