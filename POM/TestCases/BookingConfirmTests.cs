using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.TestCases
{
    public class BookingConfirmTests
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void SuccessfulLogOut()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Url = "https://www.adactin.com/HotelApp/";
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("VidhyaVenugan", "Ithika2015");
            Assert.True(driver.Title.Contains("Search"));
            SearchHotelPage searchHotel = new SearchHotelPage(driver);
            searchHotel.SelectLocation("Melbourne");
            searchHotel.SelectNumberOfRooms("1 - One");
            searchHotel.CheckInDate("21/01/2019");
            searchHotel.CheckOutDate("22/01/2019");
            searchHotel.AdultsPerRoom("2 - Two");
            searchHotel.ClickSearch();
            Assert.True(driver.Title.Contains("Select"));
            SelectHotelPage selectHotel = new SelectHotelPage(driver);
            selectHotel.SelectRadioButton();
            selectHotel.SelectContinue();
            Assert.True(driver.Title.Contains("Book"));
            BookHotelPage bookHotel = new BookHotelPage(driver);
            bookHotel.EnterName("Vidhya", "Venugan");
            bookHotel.BillingAddress("12 Ebony Way,Tarneit -3029");
            bookHotel.CreditCardNumber("1234567812345678");
            bookHotel.CreditCardType("VISA");
            bookHotel.CreditCardExpiryMonth("March");
            bookHotel.CreditCardExpiryYear("2020");
            bookHotel.CVVNumber("4567");
            bookHotel.ClickBookNow();
            bookHotel.ExplicitWait(By.Name("order_no"));
            Assert.True(driver.Title.Contains("Booking"));
            BookingConfirmPage bookingConfirm = new BookingConfirmPage(driver);
           // Assert.AreEqual(bookingConfirm.BookingConfirmation, "Booking Confirmation");
            Assert.AreNotEqual(bookingConfirm.OrderNumber,"");
            bookingConfirm.Logout();
            driver.Quit();
        }
    }
}
