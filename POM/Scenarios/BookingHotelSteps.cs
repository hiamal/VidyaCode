using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM.Pages;
using System;
using TechTalk.SpecFlow;

namespace POM.Scenarios
{
    [Binding]
    public class BookingHotelSteps
    {
        IWebDriver driver = Start.driver;
        
        [When(@"I login and book a ticket")]
        public void WhenILoginAndBookATicket()
        {
            BaseClass baseClass = new BaseClass(driver);
            //baseClass.BrowserFunctions();
            baseClass.Login();
            baseClass.SearchHotel();
            baseClass.SelectHotel();
            baseClass.BookHotel();
            
            
        }
        
        [Then(@"A ticket number is generated")]
        public void ThenATicketNumberIsGenerated()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BookingConfirmation();
        }

        [Then(@"Logout successfully")]
        public void ThenLogoutSuccessfully()
        {
            BookingConfirmPage bookingConfirmPage = new BookingConfirmPage(driver);
            bookingConfirmPage.Logout();

        }


        [When(@"I login and do not enter any one of the mandatory field")]
        public void WhenILoginAndDoNotEnterAnyOneOfTheMandatoryField()
        {
            BaseClass baseClass = new BaseClass(driver);
            //baseClass.BrowserFunctions();
            baseClass.Login();
            baseClass.SearchHotel();
            baseClass.SelectHotel();
            BookHotelPage bookHotel = new BookHotelPage(driver);
            bookHotel.EnterName("Vidhya", "Venugan");
            bookHotel.BillingAddress("12 Ebony Way,Tarneit -3029");
            bookHotel.CreditCardNumber("1234567812345678");
            bookHotel.CreditCardType("VISA");
            bookHotel.CreditCardExpiryMonth("March");
            bookHotel.CreditCardExpiryYear("2020");
            //bookHotel.CVVNumber("4567");
            bookHotel.ClickBookNow();
        }


        [Then(@"Should get an error message")]
        public void ThenShouldGetAnErrorMessage()
        {
            //BaseClass baseClass = new BaseClass(Start.driver);
            BookHotelPage bookHotel = new BookHotelPage(driver);
            Assert.AreEqual(bookHotel.CVVNumberErrorText, "Please Enter your Credit Card CVV Number");
        }

    }
}
