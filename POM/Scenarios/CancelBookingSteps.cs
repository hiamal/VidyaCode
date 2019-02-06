using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM.Pages;
using System;
using TechTalk.SpecFlow;

namespace POM.Scenarios
{
    [Binding]
    public class CancelBookingSteps
    {
        IWebDriver driver = Start.driver;

        [Given(@"I am on the home page of another build version")]
        public void GivenIAmOnTheHomePageOfAnotherBuildVersion()
        {
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelAppBuild2/");
        }


        [When(@"I login and cancel the booking")]
        public void WhenILoginAndCancelTheBooking()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.Login();
            BookedItinerary bookedItinerary = new BookedItinerary(driver);
            bookedItinerary.ClickBookedItinerary();
            bookedItinerary.CheckBox();
            bookedItinerary.CancelSelected();
            driver.SwitchTo().Alert().Accept();
            
        }

        [Then(@"Booking cancelled successfully")]
        public void ThenBookingCancelledSuccessfully()
        {
            BookedItinerary bookedItinerary = new BookedItinerary(driver);
            Assert.AreEqual(bookedItinerary.SuccessfulMsg, "Selected booking Are cancelled.");
        }

        [When(@"I login and do not select the order to cancel")]
        public void WhenILoginAndDoNotSelectTheOrderToCancel()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.Login();
            BookedItinerary bookedItinerary = new BookedItinerary(driver);
            bookedItinerary.ClickBookedItinerary();
            //bookedItinerary.CheckBox();
            bookedItinerary.CancelSelected();
            driver.SwitchTo().Alert().Accept();
        }
        
       
        
        [Then(@"cancellation is not successful")]
        public void ThenCancellationIsNotSuccessful()
        {
            BookedItinerary bookedItinerary = new BookedItinerary(driver);
            Assert.AreEqual(bookedItinerary.CheckBoxErrorMsg, "please check checkbox to proceed!!");
        }
    }
}
