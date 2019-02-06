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
    public class LoginTests
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void SuccessfulLogin()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("VidhyaVenugan", "Ithika2015");
            Assert.True(driver.Title.Contains("Search"));
            driver.Quit();
        }

        [Test]
        public void UnSuccessfulLogin()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            //driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("VidhyaVenugan", "Ithika");
            Assert.AreEqual(loginPage.ErrorText, "Click here");
            driver.Quit();
        }
    }
}
