using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM.Pages;
using System;
using TechTalk.SpecFlow;

namespace POM.Scenarios
{
    [Binding]
    public class LoginStepsNew
    {
        IWebDriver driver = Start.driver;
        
        
        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
        }

        
        [When(@"I enter the correct login credentials")]
        public void WhenIEnterTheCorrectLoginCredentials()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("VidhyaVenugan", "Ithika2015");
           
        }

        [Then(@"I am successfully logged in")]
        public void ThenIAmSuccessfullyLoggedIn()
        {
            Assert.True(driver.Title.Contains("Search"), "You're not on search page");
        }
        
        [When(@"I enter the incorrect login credentials")]
        public void WhenIEnterTheIncorrectLoginCredentials()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("VidhyaVenugan", "Ithika");
        }

        [Then(@"I get an error message")]
        public void ThenIGetAnErrorMessage()
        {
            Assert.False(driver.Title.Contains("Search"), "You're not on search page");
        }

        [When(@"I enter the login credentials ""(.*)"" and ""(.*)""")]
        public void WhenIEnterTheLoginCredentialsAnd(string username, string password)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login(username, password);    
        }


    }
}
