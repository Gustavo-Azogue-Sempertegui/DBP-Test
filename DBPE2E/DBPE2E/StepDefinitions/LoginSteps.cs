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
    public class LoginSteps
    {
        private WebDriver _driver;
        private LoginPage _login_page => new LoginPage(_driver);
        private NavBarPage _nav_bar => new NavBarPage(_driver);
        public LoginSteps(WebDriver driver)
        {
            _driver = driver;
        }

        [Given("Login with credentials (.*) and pass (.*)")]
        public void LoginWithCredentials(string userName, string pass)
        {
            _login_page.loginWithCredentials(userName, pass);
        }

        [Given("Go to login")]
        public void WhenGoToLogin()
        {
            _nav_bar.GoToLogin();
        }

        [Then("Validate user logged in (.*)")]
        public void ThenValidateUserLoggedIn(string userName)
        {
            StringAssert.Contains(userName, _login_page.ValidateUserLoggedIn());
        }
    }
}
