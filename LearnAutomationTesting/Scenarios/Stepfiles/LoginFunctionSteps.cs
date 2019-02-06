using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace LearnAutomationTesting.Scenarios.Stepfiles
{
    [Binding]
    public class LoginFunctionSteps
    {
        IWebDriver driver = Start.driver;

        [Given(@"I opened my home page")]
        public void GivenIOpenedMyHomePage()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.ebay.com.au/");
        }

        [Given(@"click the loginlink")]
        public void GivenClickTheLoginlink()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.FindElement(By.LinkText("Sign in")).Click();
        }

        [When(@"Enter email address and password")]
        public void WhenEnterEmailAddressAndPassword()
        {
            driver.FindElement(By.Id("userid")).SendKeys("t.au740");
            driver.FindElement(By.Id("pass")).SendKeys("theivanai84"); 
        }

        [When(@"click on sign")]
        public void WhenClickOnSign()
        {
            driver.FindElement(By.ClassName("checkbox__control")).Click();
            driver.FindElement(By.Id("sgnBt")).Click();
        }

        [Then(@"I will be logged in")]
        public void ThenIWillBeLoggedIn()
        {
            Assert.AreNotEqual(driver.FindElement(By.XPath("//button/b[contains(text(),'Hari')]")).Text, "Sign in");
        }

        [When(@"Enter incorrect details for email address and password")]
        public void WhenEnterIncorrectDetailsForEmailAddressAndPassword()
        {
            driver.FindElement(By.Id("userid")).SendKeys("t.au740");
            driver.FindElement(By.Id("pass")).SendKeys("theivanai");
        }

        [Then(@"I should get an error message")]
        public void ThenIShouldGetAnErrorMessage()
        {
            Assert.AreEqual(driver.FindElement(By.Id("errf")).Text, "Oops, that's not a match.");  
        }

    }
}
