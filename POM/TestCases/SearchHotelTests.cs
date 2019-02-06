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
    public class SearchHotelTests
    {
        IWebDriver driver = new ChromeDriver();

        [Test]

        public void ASelectLocation()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            //LoginPage loginPage = new LoginPage(driver);
            //loginPage.Login("VidhyaVenugan", "Ithika2015");
            //Assert.True(driver.Title.Contains("Search"));
            baseClass.Login();
            SearchHotelPage searchHotel = new SearchHotelPage(driver);
            searchHotel.SelectLocation("Sydney");
            searchHotel.ClickSearch();
            driver.Quit();
        }

        [Test]
        public void BLocationNotSelected()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            //LoginPage loginPage = new LoginPage(driver);
            //loginPage.Login("VidhyaVenugan", "Ithika2015");
            //Assert.True(driver.Title.Contains("Search"));
            baseClass.Login();
            SearchHotelPage searchHotel = new SearchHotelPage(driver);
            searchHotel.SelectLocation("- Select Location -");
            searchHotel.ClickSearch();
            Assert.AreEqual(searchHotel.LocationErrorText(), "Please Select a Location");
            driver.Quit();
        }
        [Test]
        public void CSelectNumberOfRooms()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            //LoginPage loginPage = new LoginPage(driver);
            //loginPage.Login("VidhyaVenugan", "Ithika2015"); //commented because we have created a method for these functions in base class
            //Assert.True(driver.Title.Contains("Search"));
            SearchHotelPage searchHotel = new SearchHotelPage(driver);
            searchHotel.SelectNumberOfRooms("4 - Four");
            searchHotel.ClickSearch();
            //Assert.AreEqual(searchHotel.RoomsErrorMsg(), " ");
            driver.Quit();
        }
        [Test]
        public void DNumberOfRoomsNotSelected()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            //LoginPage loginPage = new LoginPage(driver);
            //loginPage.Login("VidhyaVenugan", "Ithika2015");
            //Assert.True(driver.Title.Contains("Search"));
            baseClass.Login();
            SearchHotelPage searchHotel = new SearchHotelPage(driver);
            searchHotel.SelectNumberOfRooms("- Select Number of Rooms -");
            Assert.AreEqual(searchHotel.RoomsErrorMsg, "Please Select Total Number of Rooms");
            searchHotel.ClickSearch();
            driver.Quit();
        }
        [Test]
        public void ECheckInDate()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelAppBuild2/");
            //LoginPage loginPage = new LoginPage(driver);
            //loginPage.Login("VidhyaVenugan", "Ithika2015");
            //Assert.True(driver.Title.Contains("Search"));
            baseClass.Login();
            SearchHotelPage searchHotel = new SearchHotelPage(driver);
            searchHotel.CheckInDate("21/01/2019");
            searchHotel.ClickSearch();
            driver.Quit();
        }
        [Test]
        public void FInCorrectCheckInDate()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelAppBuild2/");
            //LoginPage loginPage = new LoginPage(driver);
            //loginPage.Login("VidhyaVenugan", "Ithika2015");
            //Assert.True(driver.Title.Contains("Search"));
            baseClass.Login();
            SearchHotelPage searchHotel = new SearchHotelPage(driver);
            searchHotel.CheckInDate("18/01/2019");
            searchHotel.ClickSearch();
            Assert.AreEqual(searchHotel.CheckInErrorMsg, "Check-In Date should be either Today or Later Date");
            driver.Quit();
        }
        [Test]
        public void GCheckOutDate()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelAppBuild2/");
            //LoginPage loginPage = new LoginPage(driver);
            //loginPage.Login("VidhyaVenugan", "Ithika2015");
            //Assert.True(driver.Title.Contains("Search"));
            baseClass.Login();
            SearchHotelPage searchHotel = new SearchHotelPage(driver);
            searchHotel.CheckInDate("21/01/2019");
            searchHotel.CheckOutDate("23/01/2019");
            searchHotel.ClickSearch();
            driver.Quit();
        }
        [Test]
        public void HInCorrectCheckOutDate()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelAppBuild2/");
            //LoginPage loginPage = new LoginPage(driver);
            //loginPage.Login("VidhyaVenugan", "Ithika2015");
            //Assert.True(driver.Title.Contains("Search"));
            baseClass.Login();
            SearchHotelPage searchHotel = new SearchHotelPage(driver);
            searchHotel.CheckInDate("21/01/2019");
            searchHotel.CheckOutDate("18/01/2019");
            searchHotel.ClickSearch();
            Assert.AreEqual(searchHotel.CheckOutErrorMsg, "Check-Out Date shall be after than Check-In Date");
            driver.Quit();
        }
        [Test]
        public void ICheckInCheckOutSame()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelAppBuild2/");
            //LoginPage loginPage = new LoginPage(driver);
            //loginPage.Login("VidhyaVenugan", "Ithika2015");
            //Assert.True(driver.Title.Contains("Search"));
            baseClass.Login();
            SearchHotelPage searchHotel = new SearchHotelPage(driver);
            searchHotel.CheckInDate("21/01/2019");
            searchHotel.CheckOutDate("21/01/2019");
            searchHotel.ClickSearch();
            Assert.AreEqual(searchHotel.CheckInErrorMsg, "Check-in and Check-out date cannot be same");
            driver.Quit();
        }
        [Test]
        public void JAdultsPerRoom()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            //LoginPage loginPage = new LoginPage(driver);
            //loginPage.Login("VidhyaVenugan", "Ithika2015");
            //Assert.True(driver.Title.Contains("Search"));
            baseClass.Login();
            SearchHotelPage searchHotel = new SearchHotelPage(driver);
            searchHotel.AdultsPerRoom("1 - One");
            searchHotel.ClickSearch();
            driver.Quit();
        }
        [Test]
        public void KAdultsPerRoomNotSelected()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            //LoginPage loginPage = new LoginPage(driver);
            //loginPage.Login("VidhyaVenugan", "Ithika2015");
            //Assert.True(driver.Title.Contains("Search"));
            baseClass.Login();
            SearchHotelPage searchHotel = new SearchHotelPage(driver);
            searchHotel.AdultsPerRoom("- Select Adults per Room -");
            searchHotel.ClickSearch();
            Assert.AreEqual(searchHotel.AdultErrorMsg, "Please Select Adults per Room");
            driver.Quit();
        }
        [Test]
        public void LSuccessfulHotelSearch()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            //LoginPage loginPage = new LoginPage(driver);
            //loginPage.Login("VidhyaVenugan", "Ithika2015");
            //Assert.True(driver.Title.Contains("Search"));
            baseClass.Login();
            SearchHotelPage searchHotel = new SearchHotelPage(driver);
            searchHotel.SelectLocation("Melbourne");
            searchHotel.SelectNumberOfRooms("1 - One");
            searchHotel.CheckInDate("21/01/2019");
            searchHotel.CheckOutDate("22/01/2019");
            searchHotel.AdultsPerRoom("2 - Two");
            searchHotel.ClickSearch();
            Assert.True(driver.Title.Contains("Select"));
            driver.Quit();
        }
    }
}
