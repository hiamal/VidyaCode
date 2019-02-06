using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutomationTesting.Pages
{
   public class LoginPage
    {
        IWebDriver driver;

        IWebElement txtUserName => driver.FindElement(By.Id("UserName"));
        IWebElement txtPassword => driver.FindElement(By.Id("Password"));
        IWebElement clickLogin => driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));
        IWebElement clickRememberMe => driver.FindElement(By.Id("rememberme"));
        IWebElement errorLogin => driver.FindElement(By.XPath("//span[contains(text(),'Incorrect')]"));
        IWebElement errorUsername => driver.FindElement(By.Id("UserName-error"));
        IWebElement errorPassword => driver.FindElement(By.Id("Password-error"));

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Login(string username, string password)
        {
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
           // clickRememberMe.Click();
            clickLogin.Click();

        }

        public string ErrorLoginText() => errorLogin.Text;
        public string ErrorUsernameText() => errorUsername.Text;
        public string ErrorPasswordText() => errorPassword.Text;
    }
}
