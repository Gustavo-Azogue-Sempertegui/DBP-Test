using BoDi;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPE2E.Support
{
    [Binding]
    public class Hook
    {
        private WebDriver driver;
        private ObjectContainer container;

        public Hook(ObjectContainer container)
        {
            this.driver = Setup.Instance.driver;
            this.container = container;
        }

        [BeforeScenario(Order = -1)]
        public void ShareDriver()
        {
            this.container.RegisterInstanceAs(this.driver);
        }
    }
}
