using NUnit.Framework;
using OpenQA.Selenium;
using POM.Pages;
using System;
using TechTalk.SpecFlow;

namespace POM.Scenarios
{
    [Binding]
    public class SearchHotelSteps
    {
        IWebDriver driver = Start.driver;

        SearchHotelPage searchHotelPage;

        [Given(@"I login into the website")]
        public void GivenILoginIntoTheWebsite()
        {

            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("VidhyaVenugan", "Ithika2015");
        }
        
        [When(@"I select a (.*) and (.*)")]
        public void WhenISelectA(string location,string date)
        {
            searchHotelPage = new SearchHotelPage(driver);
            searchHotelPage.SelectLocation(location);
            searchHotelPage.CheckInDate(date);
        }
        
        [Then(@"the (.*) is selected")]
        public void ThenTheIsSelected(string location)
        {
            searchHotelPage.SelectLocation(location);
            Assert.AreEqual(searchHotelPage.LocationText(), location);
        }
    }
}
