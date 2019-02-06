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
    public class BookHotelTests
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void ANamesEntered()
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
            bookHotel.ClickBookNow();
            driver.Quit();
        }
        [Test]
        public void BNamesNotEntered()
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
           // bookHotel.EnterName("Vidhya", "Venugan");
            bookHotel.ClickBookNow();
            Assert.AreEqual(bookHotel.FirstNameErrorText, "Please Enter your First Name");
            Assert.AreEqual(bookHotel.LastNameErrorText, "Please Enter you La st Name");
            driver.Quit();
        }
        [Test]
        public void CBillingAddress()
        {
            Login();
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
            bookHotel.ClickBookNow();
            driver.Quit();
        }

        private void Login()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Url = "https://www.adactin.com/HotelApp/";
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("VidhyaVenugan", "Ithika2015");
            Assert.True(driver.Title.Contains("Search"));
        }

        [Test]
        public void DBillingAddressNotEntered()
        {
            Login();
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
            //bookHotel.BillingAddress("12 Ebony Way,Tarneit -3029");
            bookHotel.ClickBookNow();
            Assert.AreEqual(bookHotel.BillingAddressErrorText, "Please Enter your Address");
            driver.Quit();
        }
        [Test]
        public void ECreditCardNumber()
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
            bookHotel.ClickBookNow();
            driver.Quit();
        }
        [Test]
        public void FInvalidCreditCardNumber()
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
            bookHotel.CreditCardNumber("12345678");
            bookHotel.ClickBookNow();
            Assert.AreEqual(bookHotel.CreditCardNumberErrorText, "Please Enter your 16 Digit Credit Card Number");
            driver.Quit();
        }
        [Test]
        public void GCreditCardType()
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
            bookHotel.ClickBookNow();
            driver.Quit();
        }
        [Test]
        public void HCreditCardTypeNotSelected()
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
            //bookHotel.CreditCardType("VISA");
            bookHotel.ClickBookNow();
            Assert.AreEqual(bookHotel.CreditCardTypeErrorText, "Please Select your Credit Card Type");
            driver.Quit();
        }
        [Test]
        public void ICreditCardExpiryMonthSelected()
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
            bookHotel.ClickBookNow();
            driver.Quit();
        }
        [Test]
        public void JCreditCardExpiryMonthNotSelected()
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
            bookHotel.ClickBookNow();
            Assert.AreEqual(bookHotel.ExpiryMonthErrorText, "Please Select your Credit Card Expiry Month");
            Assert.AreEqual(bookHotel.ExpiryYearErrorText, "Please Select your Credit Card Expiry Year");
            driver.Quit();
        }
        [Test]
        public void KCreditCardExpiryYearSelected()
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
            bookHotel.ClickBookNow();
            driver.Quit();
        }
        [Test]
        public void LCreditCardExpiryYearNotSelected()
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
           // bookHotel.CreditCardExpiryYear("2020");
            bookHotel.ClickBookNow();
            Assert.AreEqual(bookHotel.ExpiryYearErrorText, "Please Select your Credit Card Expiry Year");
            driver.Quit();
        }
        [Test]
        public void MCVVNumberEntered()
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
            bookHotel.ExplicitWait(By.Id("my_itinerary"));
            Assert.True(driver.Title.Contains("Booking"));
            driver.Quit();
        }
        [Test]
        public void NCVVNumberNotEntered()
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
            //bookHotel.CVVNumber("4567");
            bookHotel.ClickBookNow();
            Assert.AreEqual(bookHotel.CVVNumberErrorText, "Please Enter your Credit Card CVV Number");
            driver.Quit();
        }
    }
}
