using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Pages
{
    public class SelectHotelPage
    {
        IWebDriver driver;

        IWebElement selectRadioButton => driver.FindElement(By.Id("radiobutton_1"));
        IWebElement selectContinue => driver.FindElement(By.Id("continue"));
        IWebElement selectContinueErrorMsg => driver.FindElement(By.Id("radiobutton_span"));

        public SelectHotelPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectRadioButton()
        {
            selectRadioButton.Click();
        }

        public void SelectContinue()
        { 
            selectContinue.Click();
        }

        public string ContinueErrorMsg => selectContinueErrorMsg.Text;
    }
}
