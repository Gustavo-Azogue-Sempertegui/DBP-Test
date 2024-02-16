using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPE2E.PageObjects
{
    public class SignupPage : BasePage
    {
        private IWebElement usernameInput => driverWait.Until(e => driver.FindElement(By.CssSelector("input#sign-username")));
        private IWebElement passInput => driverWait.Until(e => driver.FindElement(By.CssSelector("input#sign-password")));
        private IWebElement closeButton => driverWait.Until(e => driver.FindElement(By.XPath("//div[@style]//button[contains(@class, 'btn-secondary')]")));
        private IWebElement signupButton => driverWait.Until(e => driver.FindElement(By.XPath("//div[@style]//button[contains(@class, 'btn-primary')]")));
        public SignupPage(WebDriver driver) : base(driver) { }

        public void signupWithInfo(string signupUsername, string signupPass)
        {
            usernameInput.Clear();
            usernameInput.SendKeys(signupUsername);
            passInput.Clear();
            passInput.SendKeys(signupPass);
            signupButton.Click();
        }

        public void closeSignupForm()
        {
            closeButton.Click();
        }
    }
}
