using Faker;
using GrouponAutomation.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace GrouponAutomation.Steps
{
    [Binding]

   public sealed class NavigationSteps
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        IWebDriver driver = ScenarioContext.Current.Get<IWebDriver>("IWebDriver");
        




        [Given(@"I go to the Groupon HomePage")]
        public void GivenIGoToTheGrouponHomePage()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["HomePageURL"]);
            driver.FindElement(By.Id("nothx")).Click();
            driver.FindElement(By.Id("ls-user-signup")).Click();
        }


        [When(@"I Click on Sign up page")]
        public void WhenIClickOnSignUpPage()
        {
            driver.FindElement(By.Id("nothx")).Click();

            //Finding the Signup Link
            driver.FindElement(By.Id("ls-user-signup")).Click();
        }

        [Then(@"the signup page should be displayed")]
        public void ThenTheSignupPageShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"I create a new account")]
        public void WhenICreateANewAccount()
        {

            //IWebElement FullnameTextBox = driver.FindElement(By.Id("full-name-input"));
            IWebElement EmailTextBox = driver.FindElement(By.Id("email-input"));
            IWebElement PasswordTextBox = driver.FindElement(By.Id("password-input"));
            IWebElement ConfirmPasswordTextBox = driver.FindElement(By.Id("password-confirmation-input"));
            IWebElement TermsofUseCheckBox = driver.FindElement(By.Id("terms-checkbox"));

            IWebElement SubmitButton = driver.FindElement(By.Name("submit"));

            string email = Internet.Email();
            string password = "sara2606";


            //FullnameTextBox.SendKeys("aaaaa");
            Pages.CreateaccountPage.typeFirstName();
            EmailTextBox.SendKeys(email);
            PasswordTextBox.SendKeys("Sara2606");
            ConfirmPasswordTextBox.SendKeys("Sara2606");



            //TermsofUseCheckBox.Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", TermsofUseCheckBox);
            SubmitButton.Click();
        }

        [Then(@"the Groupon user should be created")]
        public void ThenTheGrouponUserShouldBeCreated()
        {
            ScenarioContext.Current.Pending();
        }



        //Signup page//
        [Given(@"I go to the Signup Page")]
        public void GivenIGoToTheSignupPage()
        {
            IWebElement SignupLink = driver.FindElement(By.Id("UserSignUp"));
            SignupLink.Click();
            driver.FindElement(By.Id("section-title"));
        }

    }

}
  

