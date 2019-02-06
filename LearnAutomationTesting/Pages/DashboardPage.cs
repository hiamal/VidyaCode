using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutomationTesting.Pages
{
    public class DashboardPage
    {
        IWebDriver driver;

        IWebElement clickSkip => driver.FindElement(By.XPath("//a[contains(text(),'Skip')]"));
        IWebElement clickOwnersDropDown => driver.FindElement(By.XPath("//div[contains(text(),'Owners')]"));
        IWebElement clickProperties => driver.FindElement(By.XPath("(//a[contains(text(),'Properties')])[1]"));
              


        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Dashboard()
        {
            clickSkip.Click();
            clickOwnersDropDown.SendKeys(Keys.Return);
            System.Threading.Thread.Sleep(3000);
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //wait.Until(waitDriver => waitDriver.FindElement(By.XPath("(//a[contains(text(),'Properties')])[1]")).Displayed);
            clickProperties.Click();
            
        }
        

    }
}
