using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Pages
{
    public class BookingConfirmPage
    {
        IWebDriver driver;
        IWebElement orderno => driver.FindElement(By.Name("order_no"));
        IWebElement bookingConfirmation => driver.FindElement(By.ClassName("login_title"));
        IWebElement clickLogOut => driver.FindElement(By.Id("logout"));

        public BookingConfirmPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Logout()
        {
            clickLogOut.Click();
        }

        public string BookingConfirmation => bookingConfirmation.Text;

        public string OrderNumber => orderno.GetAttribute("value");
        
    }
}
