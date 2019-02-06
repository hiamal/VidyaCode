using LearnAutomationTesting.Scenarios;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace LearnAutomationTesting
{
    [Binding]
    public class CartSteps
    {
        IWebDriver driver = Start.driver;

        [Given(@"I opened my home page and click the loginlink")]
        public void GivenIOpenedMyHomePageAndClickTheLoginlink()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.ebay.com.au/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.FindElement(By.LinkText("Sign in")).Click();
        }
        
        [Given(@"Enter email address and password and click sign in")]
        public void GivenEnterEmailAddressAndPasswordAndClickSignIn()
        {
            driver.FindElement(By.Id("userid")).SendKeys("t.au740");
            driver.FindElement(By.Id("pass")).SendKeys("theivanai84");
            driver.FindElement(By.ClassName("checkbox__control")).Click();
            driver.FindElement(By.Id("sgnBt")).Click();
        }
        
        [Then(@"search for the product and select the product")]
        public void ThenSearchForTheProductAndSelectTheProduct()
        {
            driver.FindElement(By.Id("gh-ac")).SendKeys("baby hair accessories");
            driver.FindElement(By.Id("gh-btn")).Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement element = driver.FindElement(By.PartialLinkText("Newest Infant Toddler Baby Girl"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            element.Click();
            System.Threading.Thread.Sleep(3000);
        }

        [Then(@"add the item to cart and check whether item is in cart")]
        public void ThenAddTheItemToCartAndCheckWhetherItemIsInCart()
        {
            IWebElement style = driver.FindElement(By.Id("msku-sel-1"));
            SelectElement selectStyle = new SelectElement(style);
            selectStyle.SelectByText("1#Silver");
            driver.FindElement(By.Id("qtyTextBox")).Clear();
            driver.FindElement(By.Id("qtyTextBox")).SendKeys("2");
            driver.FindElement(By.Id("atcRedesignId_btn")).Click();
            Assert.AreEqual(driver.FindElement(By.ClassName("vi-overlayTitleBar")).Text, "2 items added to cart");
            driver.FindElement(By.XPath("//span[contains(text(),'Close button')]")).Click();
        }

        [Then(@"add the item to cart with no quantity and check whether item is added to cart")]
        public void ThenAddTheItemToCartWithNoQuantityAndCheckWhetherItemIsAddedToCart()
        {
            IWebElement style = driver.FindElement(By.Id("msku-sel-1"));
            SelectElement selectStyle = new SelectElement(style);
            selectStyle.SelectByText("1#Silver");
            driver.FindElement(By.Id("qtyTextBox")).Clear();
            driver.FindElement(By.Id("qtyTextBox")).SendKeys("0");
            Assert.AreEqual(driver.FindElement(By.Id("w1-13-_errMsg")).Text, "Please enter quantity of 1 or more");
        }

        [Then(@"view the item added to cart and check whether item is in cart")]
        public void ThenViewTheItemAddedToCartAndCheckWhetherItemIsInCart()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(waitdriver => waitdriver.FindElement(By.Id("vi-viewInCartBtn")).Displayed);
            driver.FindElement(By.Id("vi-viewInCartBtn")).Click();
            Assert.True(driver.Title.Contains("cart"));
            Assert.AreEqual(driver.FindElement(By.XPath("(//*[contains(text(),'Newest Infant ')])[1]")).Text, "Newest Infant Toddler Baby Girl Flower Headband Hair Band Kids Hair Accessories");
        }

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.ebay.com.au/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.FindElement(By.LinkText("Sign in")).Click();
        }

        [When(@"I login and add an item to cart")]
        public void WhenILoginAndAddAnItemToCart()
        {
            driver.FindElement(By.Id("userid")).SendKeys("t.au740");
            driver.FindElement(By.Id("pass")).SendKeys("theivanai84");
            driver.FindElement(By.ClassName("checkbox__control")).Click();
            driver.FindElement(By.Id("sgnBt")).Click();
            driver.FindElement(By.Id("gh-ac")).SendKeys("baby hair accessories");
            driver.FindElement(By.Id("gh-btn")).Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement element = driver.FindElement(By.PartialLinkText("Newest Infant Toddler Baby Girl"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            element.Click();
            System.Threading.Thread.Sleep(3000);
            IWebElement style = driver.FindElement(By.Id("msku-sel-1"));
            SelectElement selectStyle = new SelectElement(style);
            selectStyle.SelectByText("1#Silver");
            driver.FindElement(By.Id("qtyTextBox")).Clear();
            driver.FindElement(By.Id("qtyTextBox")).SendKeys("2");
            driver.FindElement(By.Id("atcRedesignId_btn")).Click();
            Assert.AreEqual(driver.FindElement(By.ClassName("vi-overlayTitleBar")).Text, "2 items added to cart");
            driver.FindElement(By.XPath("//span[contains(text(),'Close button')]")).Click();
        }

        [Then(@"view the item in cart and increase the quantity")]
        public void ThenViewTheItemInCartAndIncreaseTheQuantity()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(waitdriver => waitdriver.FindElement(By.Id("vi-viewInCartBtn")).Displayed);
            driver.FindElement(By.Id("vi-viewInCartBtn")).Click();
            System.Threading.Thread.Sleep(3000);
            Assert.True(driver.Title.Contains("cart"));
            Assert.AreEqual(driver.FindElement(By.XPath("(//*[contains(text(),'Newest Infant ')])[1]")).Text, "Newest Infant Toddler Baby Girl Flower Headband Hair Band Kids Hair Accessories");
            IWebElement qty = driver.FindElement(By.ClassName("listbox__control"));
            SelectElement qtyCheckbox = new SelectElement(qty);
            qtyCheckbox.SelectByText("5");
        }

        [Then(@"cart needs to be updated with new quantity for the item")]
        public void ThenCartNeedsToBeUpdatedWithNewQuantityForTheItem()
        {
            driver.Navigate().Refresh();
            Assert.AreEqual(driver.FindElement(By.XPath("//h1[@data-test-id='main-title']")).Text, "Shopping cart (5 items)");
        }


    }
}
