using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPE2E.PageObjects
{
    public class PlaceOrderForm : BasePage
    {
        private IWebElement nameInput => driverWait.Until(e => driver.FindElement(By.CssSelector("form input#name")));
        private IWebElement countryInput => driverWait.Until(e => driver.FindElement(By.CssSelector("form input#country")));
        private IWebElement cityInput => driverWait.Until(e => driver.FindElement(By.CssSelector("form input#city")));
        private IWebElement creditCardInput => driverWait.Until(e => driver.FindElement(By.CssSelector("form input#card")));
        private IWebElement monthInput => driverWait.Until(e => driver.FindElement(By.CssSelector("form input#month")));
        private IWebElement yearInput => driverWait.Until(e => driver.FindElement(By.CssSelector("form input#year")));
        private IWebElement purchaseButton => driverWait.Until(e => driver.FindElement(By.XPath("//div[@style]//button[contains(@class, 'btn-primary')]")));
        private IWebElement closeButton => driverWait.Until(e => driver.FindElement(By.XPath("//div[@style]//button[contains(@class, 'btn-secondary')]")));
        private IWebElement purchaseConfirmationModal => driverWait.Until(e => driver.FindElement(By.CssSelector("div.sweet-alert")));

        public PlaceOrderForm(WebDriver driver) : base(driver) { }

        public void fillPlaceOrderForm(string name, string country, string city, string creditCard, string month, string year)
        {
            nameInput.Clear();
            nameInput.SendKeys(name);
            countryInput.Clear();
            countryInput.SendKeys(country);
            cityInput.Clear();
            cityInput.SendKeys(city);
            creditCardInput.Clear();
            creditCardInput.SendKeys(creditCard);
            monthInput.Clear();
            monthInput.SendKeys(month);
            yearInput.Clear();
            yearInput.SendKeys(year);

            purchaseButton.Click();
        }

        public void closePlaceOrderForm()
        {
            closeButton.Click();
        }

        public string getConfirmationMessage()
        {
            return purchaseConfirmationModal.FindElement(By.CssSelector("h2")).Text;
        }

        public string getConfirmationData()
        {
            return purchaseConfirmationModal.FindElement(By.CssSelector("p")).Text;
        }
    }
}
