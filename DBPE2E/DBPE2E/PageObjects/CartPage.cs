using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPE2E.PageObjects
{
    public class CartPage : BasePage
    {
        private IWebElement totalPrice => driverWait.Until(e => driver.FindElement(By.CssSelector("h3#totalp")));
        private IWebElement placeOrderButton => driverWait.Until(e => driver.FindElement(By.CssSelector("button.btn.btn-success")));
        public CartPage(WebDriver driver) : base(driver) { }

        private IWebElement getProductRowByName(string productName)
        {
            return driverWait.Until(e => driver.FindElement(By.XPath($"//tr[td[contains(text(), '{productName}')]]")));
        }

        public bool validateProductListedByName(string productName)
        {
            try
            {
                getProductRowByName(productName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void deleteItemByName(string productName)
        {
            IWebElement row = getProductRowByName(productName);
            row.FindElement(By.XPath("//td/a[constains(text(), 'Delete')]")).Click();
        }

        public float getTotalPrice()
        {
            return float.Parse(totalPrice.Text);
        }

        public float calculateTotalFromPriceItem()
        {
            float totalPrice = 0;

            List<IWebElement> productList = driverWait.Until(e => driver.FindElements(By.CssSelector("tr.success"))).ToList();

            foreach(IWebElement productRow in productList)
            {
                IWebElement priceColumn = productRow.FindElement(By.CssSelector("td[3]"));
                totalPrice += float.Parse(priceColumn.Text);
            }

            return totalPrice;
        }

        public void performPlaceOrder()
        {
            placeOrderButton.Click();
        }
    }
}
