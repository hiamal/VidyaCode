using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Pages
{
    public class BaseClass
    {
        IWebDriver driver;

        public BaseClass(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void BrowserFunctions()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
        }

        public void Login()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("VidhyaVenugan", "Ithika2015");
            Assert.True(driver.Title.Contains("Search"));
        }

        public void SearchHotel()
        {
            SearchHotelPage searchHotel = new SearchHotelPage(driver);
            searchHotel.SelectLocation("Melbourne");
            searchHotel.SelectNumberOfRooms("1 - One");
            searchHotel.CheckInDate("21/01/2019");
            searchHotel.CheckOutDate("22/01/2019");
            searchHotel.AdultsPerRoom("2 - Two");
            searchHotel.ClickSearch();
            Assert.True(driver.Title.Contains("Select"));
        }

        public void SelectHotel()
        {
            SelectHotelPage selectHotel = new SelectHotelPage(driver);
            selectHotel.SelectRadioButton();
            selectHotel.SelectContinue();
            Assert.True(driver.Title.Contains("Book"));
        }

        public void BookHotel()
        {
            BookHotelPage bookHotel = new BookHotelPage(driver);
            bookHotel.EnterName("Vidhya", "Venugan");
            bookHotel.BillingAddress("12 Ebony Way,Tarneit -3029");
            bookHotel.CreditCardNumber("1234567812345678");
            bookHotel.CreditCardType("VISA");
            bookHotel.CreditCardExpiryMonth("March");
            bookHotel.CreditCardExpiryYear("2020");
            bookHotel.CVVNumber("4567");
            bookHotel.ClickBookNow();
            //bookHotel.ExplicitWait(By.Id("my_itinerary"));
            bookHotel.ExplicitWait(By.Name("order_no"));
            Assert.True(driver.Title.Contains("Booking"));
        }

        public void BookingConfirmation()
        {
            BookingConfirmPage bookingConfirm = new BookingConfirmPage(driver);
            Assert.AreEqual(bookingConfirm.BookingConfirmation, "Booking Confirmation");
        }

    }
}
