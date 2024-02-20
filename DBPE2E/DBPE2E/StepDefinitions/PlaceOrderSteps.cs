using DBPE2E.Models;
using DBPE2E.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace DBPE2E.StepDefinitions
{
    [Binding]
    public class PlaceOrderSteps
    {
        private WebDriver _driver;
        private PlaceOrderForm _placeOrderForm => new PlaceOrderForm(_driver);
        public PlaceOrderSteps(WebDriver driver)
        {
            _driver = driver;
        }

        [When("Fill the place order form with data")]
        public void WhenFillThePlaceOrderFormWithData(Table placeOrderData)
        {
            List<PlaceOrder> placeOrderTable = placeOrderData.CreateSet<PlaceOrder>().ToList();

            foreach(PlaceOrder placeOrder in placeOrderTable)
            {
                _placeOrderForm.fillPlaceOrderForm(placeOrder.name, placeOrder.country, placeOrder.city, placeOrder.creditCard, placeOrder.month, placeOrder.year);
            }
        }

        [Then("Validate confirmation message")]
        public void ThenValidateConfirmationMessage()
        {
            StringAssert.Contains(_placeOrderForm.getConfirmationMessage(), "Thank you for your purchase!");
        }

        [Then("Validate confirmation information")]
        public void ThenValidateConfirmationInformation(Table placeOrderData)
        {
            List<PlaceOrder> placeOrderTable = placeOrderData.CreateSet<PlaceOrder>().ToList();

            foreach (PlaceOrder placeOrder in placeOrderTable)
            {
                StringAssert.Contains(placeOrder.name, _placeOrderForm.getConfirmationMessage());
                StringAssert.Contains(placeOrder.country, _placeOrderForm.getConfirmationMessage());
                StringAssert.Contains(placeOrder.city, _placeOrderForm.getConfirmationMessage());
                StringAssert.Contains(placeOrder.creditCard, _placeOrderForm.getConfirmationMessage());
                StringAssert.Contains(placeOrder.month, _placeOrderForm.getConfirmationMessage());
                StringAssert.Contains(placeOrder.year, _placeOrderForm.getConfirmationMessage());
            }
        }
    }
}
