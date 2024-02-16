using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPE2E.PageObjects
{
    public class ProductsDataTable : BasePage
    {
        private IWebElement filterPhones => driverWait.Until(e => driver.FindElement(By.XPath("//a[contains(text(), 'Phones')]")));
        private IWebElement filterLaptops => driverWait.Until(e => driver.FindElement(By.XPath("//a[contains(text(), 'Laptops')]")));
        private IWebElement filterMonitors => driverWait.Until(e => driver.FindElement(By.XPath("//a[contains(text(), 'Monitors')]")));
        public ProductsDataTable(WebDriver driver) : base(driver)
        {

        }
        public void filterProducts(string filter)
        {
            switch (filter.ToUpper())
            {
                case "PHONES":
                default:
                    filterPhones.Click();
                    break;
                case "LAPTOPS":
                    filterLaptops.Click();
                    break;
                case "MONITORS":
                    filterMonitors.Click();
                    break;
            }
        }
        public void selectProductByName(string productName)
        {
            driverWait.Until(e => driver.FindElement(By.XPath($"//div[@class = 'card-block']//a[contains(text(), '{productName}')]"))).Click();
        }
    }
}
