using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace LearnUnitTest
{
    public class AdactIn
    {
        IWebDriver driver = new ChromeDriver();
        [Test]
        public void DSuccesfulLogin()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //Some instance where page takes time to load,wait atleast for 30 seconds for the page to load 
                                                                                //and wait for webelement.
                                                                                //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            IWebElement txtUserName = driver.FindElement(By.Name("username"));
            // txtUserName.Clear();                       // To clear the fields
            txtUserName.SendKeys("VidhyaVenugan");
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            txtPassword.SendKeys("Ithika2015");
            IWebElement clickLogin = driver.FindElement(By.Name("login"));
            clickLogin.Click();
            Assert.IsTrue(driver.Title.Contains("Search"));
            driver.Quit();
        }

        [Test]
        public void BPasswordIncorrect()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //Some instance where page takes time to load,wait atleast for 30 seconds for the page to load 
                                                                                //and wait for webelement.
                                                                                //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            IWebElement txtUserName = driver.FindElement(By.Name("username"));
            // txtUserName.Clear();                       // To clear the fields
            txtUserName.SendKeys("VidhyaVenugan");
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            txtPassword.SendKeys("Ithika");
            IWebElement clickLogin = driver.FindElement(By.Name("login"));
            clickLogin.Click();
            Assert.AreEqual(driver.FindElement(By.XPath("(//div)[2]/b/a")).Text, "Click here");
            driver.Quit();
        }

        [Test]
        public void AUsernameIncorrect()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //Some instance where page takes time to load,wait atleast for 30 seconds for the page to load 
                                                                                //and wait for webelement.
                                                                                //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            IWebElement txtUserName = driver.FindElement(By.Name("username"));
            // txtUserName.Clear();                       // To clear the fields
            txtUserName.SendKeys("Vidhya");
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            txtPassword.SendKeys("Ithika2015");
            IWebElement clickLogin = driver.FindElement(By.Name("login"));
            clickLogin.Click();
            Assert.AreEqual(driver.FindElement(By.XPath("(//div)[2]/b/a")).Text, "Click here");
            driver.Quit();
        }

        [Test]
        public void CUsernamePasswordIncorrect()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //Some instance where page takes time to load,wait atleast for 30 seconds for the page to load 
                                                                                //and wait for webelement.
                                                                                //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            IWebElement txtUserName = driver.FindElement(By.Name("username"));
            // txtUserName.Clear();                       // To clear the fields
            txtUserName.SendKeys("Vidhya");
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            txtPassword.SendKeys("Ithika");
            IWebElement clickLogin = driver.FindElement(By.Name("login"));
            clickLogin.Click();
            Assert.AreEqual(driver.FindElement(By.LinkText("Click here")).Text, "Click here", "Username and Password Incorrect");
            driver.Quit();
        }



    }
}

  



