using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Pages
{
    public class LoginPage
    {
        IWebDriver driver;

        IWebElement txtUserName => driver.FindElement(By.Id("username"));
        IWebElement txtPassword => driver.FindElement(By.Id("password"));
        IWebElement btnLogin => driver.FindElement(By.Id("login"));
        IWebElement errorMsg => driver.FindElement(By.XPath("(//div)[2]/b/a"));

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Login(string username,string password)
        {
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
            btnLogin.Click();

        }

       public string ErrorText => errorMsg.Text;

    }
}
