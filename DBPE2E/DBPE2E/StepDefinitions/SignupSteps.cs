using DBPE2E.Helper;
using DBPE2E.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPE2E.StepDefinitions
{
    [Binding]
    public class SignupSteps
    {
        private WebDriver _driver;
        private NavBarPage _navBarPage => new NavBarPage(_driver);
        private SignupPage _signupPage => new SignupPage(_driver);

        public SignupSteps(WebDriver driver)
        {
            this._driver = driver;
        }

        [Given("Go to Signup")]
        public void GivenGoToSignup()
        {
            _navBarPage.GoToSignUp();
        }

        [Given("Signup with credentials (.*) and (.*)")]
        public void GiveSignupWithCredentials(string username, string password)
        {
            _signupPage.signupWithInfo(username + Randomizer.getRandomString(7), password);
        }
    }
}
