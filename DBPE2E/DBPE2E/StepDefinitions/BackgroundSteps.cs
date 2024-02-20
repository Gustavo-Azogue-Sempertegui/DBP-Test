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
    public class BackgroundSteps
    {
        private WebDriver _driver;
        private BasePage base_page => new BasePage(_driver);
        public BackgroundSteps(WebDriver driver)
        {
            _driver = driver;
        }

        [Given("Initilize browser")]
        public void InitializeBrowser()
        {
            base_page.Open();
        }

        [Then("Validate Alert message as (.*)")]
        public void ThenValidateAlertMessage(string message)
        {
            StringAssert.Contains(message, base_page.getAlertMessage());
            base_page.closeAlertMessage();
        }
    }
}
