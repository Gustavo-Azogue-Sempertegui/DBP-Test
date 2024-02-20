using DBPE2E.Support;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPE2E.PageObjects
{
    public class BasePage
    {
        protected WebDriver driver;
        protected WebDriverWait driverWait;

        public BasePage(WebDriver driver)
        {
            this.driver = driver;
            this.driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 15));
        }

        public void Open()
        {
            driver.Navigate().GoToUrl(Setup.Instance.BaseUrl);
        }

        public string getAlertMessage()
        {
            return this.driver.SwitchTo().Alert().Text;
        }

        public void closeAlertMessage()
        {
           this.driver.SwitchTo().Alert().Accept();
        }
    }
}
