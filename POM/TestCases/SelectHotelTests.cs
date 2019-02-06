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
    public class SelectHotelTests
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void SelectHotel()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            //LoginPage loginPage = new LoginPage(driver);
            //loginPage.Login("VidhyaVenugan", "Ithika2015");
            //Assert.True(driver.Title.Contains("Search"));
            //SearchHotelPage searchHotel = new SearchHotelPage(driver);
            //searchHotel.SelectLocation("Melbourne");
            //searchHotel.SelectNumberOfRooms("1 - One");
            //searchHotel.CheckInDate("21/01/2019");
            //searchHotel.CheckOutDate("22/01/2019");
            //searchHotel.AdultsPerRoom("2 - Two");
            //searchHotel.ClickSearch();
            //Assert.True(driver.Title.Contains("Select"));
            baseClass.SearchHotel();
            SelectHotelPage selectHotel = new SelectHotelPage(driver);
            selectHotel.SelectRadioButton();
            selectHotel.SelectContinue();
            Assert.True(driver.Title.Contains("Book"));
            driver.Quit();
        }
        [Test]
        public void HotelNotSelected()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
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
            selectHotel.SelectContinue();
            Assert.AreEqual(selectHotel.ContinueErrorMsg,"Please Select a Hotel");
            driver.Quit();
        }

    }
}
