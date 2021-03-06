﻿using LearnAutomationTesting.Pages;
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
   public class DashboardTest
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void ClickProperties()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("vincent.nguyen@mvpstudio.co.nz", "ntmv2682");
            Assert.True(driver.Title.Contains("Dashboard"));
            DashboardPage dashboardPage = new DashboardPage(driver);
            dashboardPage.Dashboard();                 
            Assert.True(driver.Title.Contains("Properties"));
            driver.Quit();
        }
    }
}
