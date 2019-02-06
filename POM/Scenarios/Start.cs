using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace POM.Scenarios
{
    [Binding]
    public class Start
    {

        public static IWebDriver driver;

        [BeforeScenario ("positive","negative")]
        public void RunBeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
        }

        [AfterScenario("positive","negative")]
        public void RunAfterScenario()
        {
            driver.Quit();
        }


    }
}
