using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Pages
{
    public class BookedItinerary
    {
        IWebDriver driver;

        IWebElement clickBookedItinerary => driver.FindElement(By.LinkText("Booked Itinerary"));
        IWebElement clickOneCheckBox => driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr[2]/td/form/table/tbody/tr[2]/td/table/tbody/tr[2]/td[1]/input"));
        ////input[@value='284973']
        IWebElement checkBoxErrorMsg => driver.FindElement(By.Id("search_result_error"));
        IWebElement clickCancelSelected => driver.FindElement(By.Name("cancelall"));
        IWebElement successfulMsg => driver.FindElement(By.Id("search_result_error"));


        public BookedItinerary(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickBookedItinerary()
        {
            clickBookedItinerary.Click();
        }

        public void CheckBox()
        {
            clickOneCheckBox.Click();
        }

        public void CancelSelected()
        {
            clickCancelSelected.Click();
        }
        public string SuccessfulMsg => successfulMsg.Text;
        public string CheckBoxErrorMsg => checkBoxErrorMsg.Text;

        public void AcceptIfAlertExists()
        {
            try
            {
                driver.SwitchTo().Alert().Accept();
            }
            catch (UnhandledAlertException e)
            {
                Console.WriteLine("An unexpected alert was accepted");
            }
        }
    }
}
