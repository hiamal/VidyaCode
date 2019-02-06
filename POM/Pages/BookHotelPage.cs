using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Pages
{
    public class BookHotelPage
    {
        IWebDriver driver;

        IWebElement txtFirstName => driver.FindElement(By.Name("first_name"));
        IWebElement firstNameErrorMsg => driver.FindElement(By.Id("first_name_span"));
        IWebElement txtLastName => driver.FindElement(By.Name("last_name"));
        IWebElement lastNameErrorMsg => driver.FindElement(By.Id("last_name_span"));
        IWebElement txtAddress => driver.FindElement(By.Id("address"));
        IWebElement billingAddressErrorMsg => driver.FindElement(By.Id("address_span"));
        IWebElement txtCreditCardNumber => driver.FindElement(By.Name("cc_num"));
        IWebElement creditCardNumberErrorMsg => driver.FindElement(By.Id("cc_num_span"));
        SelectElement creditCardType => new SelectElement(driver.FindElement(By.Id("cc_type")));
        IWebElement creditCardTypeErrorMsg => driver.FindElement(By.Id("cc_type_span"));
        SelectElement expiryMonth => new SelectElement(driver.FindElement(By.Id("cc_exp_month")));
        IWebElement expiryMonthErrorMsg => driver.FindElement(By.Id("cc_expiry_span"));
        SelectElement expiryYear => new SelectElement(driver.FindElement(By.Id("cc_exp_year")));
        IWebElement expiryYearErrorMsg => driver.FindElement(By.Id("cc_expiry_span"));
        IWebElement txtCvvNumber => driver.FindElement(By.Name("cc_cvv"));
        IWebElement cvvNumberErrorMsg => driver.FindElement(By.Id("cc_cvv_span"));
        IWebElement clickBookNow => driver.FindElement(By.Id("book_now"));
        WebDriverWait wait => new WebDriverWait(driver, TimeSpan.FromSeconds(30));


        public BookHotelPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterName(string firstname,string lastname)
        {
            txtFirstName.SendKeys(firstname);
            txtLastName.SendKeys(lastname);
        }
        public string FirstNameErrorText => firstNameErrorMsg.Text;
        public string LastNameErrorText => lastNameErrorMsg.Text;

        public void BillingAddress(string address)
        {
            txtAddress.SendKeys(address);
        }
        public string BillingAddressErrorText => billingAddressErrorMsg.Text;

        public void CreditCardNumber(string number)
        {
            txtCreditCardNumber.SendKeys(number);
        }
        public string CreditCardNumberErrorText => creditCardNumberErrorMsg.Text;

        public void CreditCardType(string type)
        {
            creditCardType.SelectByText(type);
        }
        public string CreditCardTypeErrorText => creditCardTypeErrorMsg.Text;

        public void CreditCardExpiryMonth(string month)
        {
            expiryMonth.SelectByText(month);
        }
        public string ExpiryMonthErrorText => expiryMonthErrorMsg.Text;
        
        public void CreditCardExpiryYear(string year)
        {
            expiryYear.SelectByText(year);
        }
        public string ExpiryYearErrorText => expiryYearErrorMsg.Text;

        public void CVVNumber(string number)
        {
            txtCvvNumber.SendKeys(number);
        }
        public string CVVNumberErrorText => cvvNumberErrorMsg.Text;

        public void ClickBookNow()
        {
            clickBookNow.Click();
        }

        public void ExplicitWait(By elementlocator)
        {
             // Explicit wait is used to click on my itinerary
            wait.Until(waitDriver => waitDriver.FindElement(elementlocator).Displayed);
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("my_itinerary")));
        }

        //public void waitForElement(String item)
        //{
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        //    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("item")));
        //}

    }
}
