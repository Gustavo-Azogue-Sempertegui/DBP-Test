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
    public class ProductTableSteps
    {
        WebDriver _driver;
        ProductsDataTable _products => new ProductsDataTable(_driver);

        public ProductTableSteps(WebDriver driver)
        {
            _driver = driver;
        }

        [When("filer products by (.*)")]
        public void WhenFilterProductsBy(string filter)
        {
            _products.filterProducts(filter);
        }

        [Then("Validate amount of products like (.*)")]
        public void ThenValidateAmountOfProductsLike(string amount)
        {
            Assert.Equals(int.Parse(amount), _products.getAmoutOfProducts());
        }

        [When("Select product by name (.*)")]
        public void WhenSelectProductByName(string productName)
        {
            _products.selectProductByName(productName);
        }
    }
}
