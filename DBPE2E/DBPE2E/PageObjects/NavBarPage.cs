using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBPE2E.PageObjects
{
    public class NavBarPage : BasePage
    {
        private IWebElement homeMenu => driverWait.Until(e => driver.FindElement(By.XPath("//ul/li/a[contains(text(), 'Home')]")));
        private IWebElement contactMenu => driverWait.Until(e => driver.FindElement(By.XPath("//ul/li/a[contains(text(), 'Contact')]")));
        private IWebElement aboutUsMenu => driverWait.Until(e => driver.FindElement(By.XPath("//ul/li/a[contains(text(), 'About us')]")));
        private IWebElement cartMenu => driverWait.Until(e => driver.FindElement(By.XPath("//ul/li/a[contains(text(), 'Cart')]")));
        private IWebElement loginMenu => driverWait.Until(e => driver.FindElement(By.XPath("//ul/li/a[contains(text(), 'Log in')]")));
        private IWebElement signupMenu => driverWait.Until(e => driver.FindElement(By.XPath("//ul/li/a[contains(text(), 'Sign up')]")));
        public NavBarPage(WebDriver driver) : base(driver) { }

        public void GotoHome()
        {
            homeMenu.Click();
        }

        public void GoToContact()
        {
            contactMenu.Click();
        }

        public void GoToAboutUs()
        {
            aboutUsMenu.Click();
        }

        public void GoToCart()
        {
            cartMenu.Click();
        }

        public void GoToLogin()
        {
            loginMenu.Click();
        }

        public void GoToSignUp()
        {
            signupMenu.Click();
        }
    }
}
