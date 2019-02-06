using LearnAutomationTesting.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutomationTesting.Test_Cases
{
    public class LoginTest
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void SuccessfulLogin()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("vincent.nguyen@mvpstudio.co.nz", "ntmv2682");
            Assert.True(driver.Title.Contains("Dashboard"));
            driver.Quit();
        }

        [Test]
        public void UnsuccessfulLoginPasswordIncorrect()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("vincent.nguyen@mvpstudio.co.nz", "ntmv268");
            Assert.AreEqual(loginPage.ErrorLoginText(), "Incorrect username / password");
            driver.Quit();
        }

        [Test]
        public void UnsuccessfulLoginUsernameIncorrect()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("vincent.nguye@mvpstudio.co.nz", "ntmv2682");
            Assert.AreEqual(loginPage.ErrorLoginText(), "Incorrect username / password");
            driver.Quit();
        }

        [Test]
        public void UnsuccessfulLoginUsernameNotEntered()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("", "ntmv26826");
            Assert.AreEqual(loginPage.ErrorUsernameText(), "The Username field is required.");
            driver.Quit();
        }

        [Test]
        public void UnsuccessfulLoginPasswordNotEntered()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("vincent.nguyen@mvpstudio.co.nz", "");
            Assert.AreEqual(loginPage.ErrorPasswordText(), "The Password field is required.");
            driver.Quit();
        }

        [Test]
        public void UsernameAndPasswordNotEntered()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("", "");
            Assert.AreEqual(loginPage.ErrorUsernameText(), "The Username field is required.");
            Assert.AreEqual(loginPage.ErrorPasswordText(), "The Password field is required.");
            driver.Quit();
        }

        [Test]
        public void UsernameAndPasswordIncorrect()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("vince.nguyen@mvpstudio.co.nz", "ntmv268");
            Assert.AreEqual(loginPage.ErrorLoginText(), "Incorrect username / password");
            driver.Quit();
        }
    }
}
