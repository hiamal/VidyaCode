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
    public class BookedItineraryTests
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void CheckBoxSelected()
        {
            BaseClass baseClass = new BaseClass(driver);
            //baseClass.BrowserFunctions();
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelAppBuild2/");
            baseClass.Login();
            BookedItinerary bookedItinerary = new BookedItinerary(driver);
            bookedItinerary.ClickBookedItinerary();
            bookedItinerary.CheckBox();
            bookedItinerary.CancelSelected();
            bookedItinerary.AcceptIfAlertExists();
            Assert.AreEqual(bookedItinerary.SuccessfulMsg, "Selected booking Are cancelled.");
            driver.Quit();
        }

        [Test]
        public void CheckBoxNotSelected()
        {
            BaseClass baseClass = new BaseClass(driver);
            //baseClass.BrowserFunctions();
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelAppBuild2/");
            baseClass.Login();
            BookedItinerary bookedItinerary = new BookedItinerary(driver);
            bookedItinerary.ClickBookedItinerary();
            //bookeditinerary.CheckBox();
            bookedItinerary.CancelSelected();
            bookedItinerary.AcceptIfAlertExists();
            Assert.AreEqual(bookedItinerary.CheckBoxErrorMsg, "please check checkbox to proceed!!");
            driver.Quit();
        }
    }
}
