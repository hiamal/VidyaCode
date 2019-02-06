using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutomationTesting.Pages
{
    public class PropertiesPage
    {
        IWebDriver driver;

        IWebElement clickAddNewProperty => driver.FindElement(By.XPath("(//a/i)[6]"));

        public PropertiesPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Properties()
        {
            clickAddNewProperty.Click();
        }
    }
}
