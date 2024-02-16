using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPE2E.PageObjects
{
    public class ProductInfoPage : BasePage
    {
        private IWebElement procuctName => driverWait.Until(e => driver.FindElement(By.CssSelector("h2")));
        private IWebElement productPrice => driverWait.Until(e => driver.FindElement(By.CssSelector("h3")));
        private IWebElement addToCartButton => driverWait.Until(e => driver.FindElement(By.CssSelector("a.btn.btn-success.btn-lg")));
        public ProductInfoPage(WebDriver driver) : base(driver) { }

        public string getProductName()
        {
            return procuctName.Text;
        }

        public float getProductPrice()
        {
            return float.Parse(productPrice.Text.Replace("$", ""));
        }

        public void addToCart()
        {
            addToCartButton.Click();
        }
    }
}
