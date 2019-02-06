using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace LearnAutomationTesting.Scenarios
{
    [Binding]
    public class Start
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void RunBeforeScenario()
        {
            driver = new ChromeDriver();
        }

        //[AfterScenario]
        //public void RunAfterScenario()
        //{
        //    driver.Quit();
        //}
    }
}
