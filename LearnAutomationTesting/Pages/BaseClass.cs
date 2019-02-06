using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutomationTesting.Pages
{
    public class BaseClass
    {
        IWebDriver driver;

        public BaseClass(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void BrowserFunctions()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://new-keys.azurewebsites.net/Account/Login");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
        }

        public void Login()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("vincent.nguyen@mvpstudio.co.nz", "ntmv2682");
            Assert.True(driver.Title.Contains("Dashboard"));
        }
        
    }
}
