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
    public class ProductInfoSteps
    {
        private WebDriver _driver;
        private ProductInfoPage _productInfo => new ProductInfoPage(_driver);
        public ProductInfoSteps(WebDriver driver)
        {
            this._driver = driver;
        }

        [When("Add product to cart")]
        public void WhenAddProductToCart()
        {
            _productInfo.addToCart();
        }

        [Then("Validate product information name: (.*) and price (.*)")]
        public void ThenValidateProductInformation(string productName, string price)
        {
            StringAssert.Contains(productName, _productInfo.getProductName());
            Assert.AreEqual(float.Parse(price), _productInfo.getProductPrice());
        }
    }
}
