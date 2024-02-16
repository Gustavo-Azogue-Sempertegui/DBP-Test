using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPE2E.PageObjects
{
    public class LoginPage : BasePage
    {
        private IWebElement usernameInput => driverWait.Until(e => driver.FindElement(By.CssSelector("input#loginusername")));
        private IWebElement passInput => driverWait.Until(e => driver.FindElement(By.CssSelector("input#loginpassword")));
        private IWebElement closeButton => driverWait.Until(e => driver.FindElement(By.XPath("//div[@style]//button[contains(@class, 'btn-secondary')]")));
        private IWebElement loginButton => driverWait.Until(e => driver.FindElement(By.XPath("//div[@style]//button[contains(@class, 'btn-primary')]")));
        public LoginPage(WebDriver driver) : base(driver) { }

        public void loginWithCredentials(string userName, string pass)
        {
            usernameInput.Clear();
            usernameInput.SendKeys(userName);
            passInput.Clear();
            passInput.SendKeys(pass);
            loginButton.Click();
        }

        public void closeLoginModal()
        {
            closeButton.Click();
        }
    }
}
