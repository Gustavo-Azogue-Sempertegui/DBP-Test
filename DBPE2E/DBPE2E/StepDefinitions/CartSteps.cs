using DBPE2E.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPE2E.StepDefinitions
{
    [Binding]
    public class CartSteps
    {
        private WebDriver _driver;
        private CartPage _cartPage => new CartPage(_driver);
        private NavBarPage _NavBarPage => new NavBarPage(_driver);
        public CartSteps(WebDriver driver)
        {
            _driver = driver;
        }

        [When("Go to cart")]
        public void WhenGoToCart()
        {
            _NavBarPage.GoToCart();
        }

        [Then("Validate the product (.*) is listed on cart")]
        public void ThenValidateTheProductIsListedOnCart(string productName)
        {
            Assert.True(_cartPage.validateProductListedByName(productName));
        }

        [Then("Validate the product (.*) is no longer listed on cart")]
        public void ThenValidateTheProductIsNoLongerListedOnCart(string productName)
        {
            Assert.False(_cartPage.validateProductListedByName(productName));
        }

        [Then("Validate total price")]
        public void ThenValidateTotalPrice()
        {
            Assert.AreEqual(_cartPage.calculateTotalFromPriceItem(), _cartPage.getTotalPrice());
        }

        [When("Delete product from cart by name (.*)")]
        public void WhenDeleteProductFromCartByName(string productName)
        {
            _cartPage.deleteItemByName(productName);
        }

        [When("Place an order")]
        public void WhenPlaceAnOrder()
        {
            _cartPage.performPlaceOrder();
        }
    }
}
