using LearnAutomationTesting.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutomationTesting.Test_Cases
{
    public class AddNewPropertyPageTest
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void AddPropertyDetails()
        {
            BaseClass baseClass = new BaseClass(driver);
            baseClass.BrowserFunctions();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("vincent.nguyen@mvpstudio.co.nz", "ntmv2682");
            Assert.True(driver.Title.Contains("Dashboard"));
            DashboardPage dashboardPage = new DashboardPage(driver);
            dashboardPage.Dashboard();
            Assert.True(driver.Title.Contains("Properties"));
            PropertiesPage propertiesPage = new PropertiesPage(driver);
            propertiesPage.Properties();
            Assert.True(driver.Title.Contains("Add New Property"));
            AddNewPropertyPage addNewProperty = new AddNewPropertyPage(driver);
            addNewProperty.PropertyName("Villas");
            addNewProperty.SearchAddress("1279 Great South Road, Runciman, New Zealand");
            addNewProperty.Number("1279");
            addNewProperty.Street("Great South Road");
            addNewProperty.Suburb("Victoria");
            addNewProperty.City("Runciman");
          
          // addNewProperty.AcceptIfAlertExists();
            addNewProperty.PostCode(25);
          // addNewProperty.AcceptIfAlertExists();
            addNewProperty.PostCode(78);
            addNewProperty.Region("Auc");
           // addNewProperty.AcceptIfAlertExists();
            addNewProperty.Region("kland");
            addNewProperty.TargetRent(425);
            addNewProperty.LandArea(520);
            addNewProperty.Bedrooms(3);
            addNewProperty.Carparks(2);
            addNewProperty.PropertyType("Affordable Housing");
            addNewProperty.Description("House for sale");
            addNewProperty.RentType("Weekly");
            addNewProperty.FloorArea(410);
            addNewProperty.Bathrooms(2);
            addNewProperty.YearBuilt(1992);
            addNewProperty.ChooseFiles();
        }
    }
}
