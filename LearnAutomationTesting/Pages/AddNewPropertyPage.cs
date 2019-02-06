using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutomationTesting.Pages
{
    public class AddNewPropertyPage
    {
        IWebDriver driver;
        IWebElement txtPropertyName => driver.FindElement(By.Name("propertyName"));
        IWebElement txtSearchAddress => driver.FindElement(By.Name("searchAddress"));
        IWebElement txtNumber => driver.FindElement(By.XPath("//input[contains(@data-bind,'Address.Number')]"));
        IWebElement txtStreet => driver.FindElement(By.XPath("//input[contains(@data-bind,'Address.Street')]"));
        IWebElement txtSuburb => driver.FindElement(By.XPath("//input[contains(@data-bind,'Address.Suburb')]"));
        IWebElement txtCity => driver.FindElement(By.XPath("//input[contains(@data-bind,'Address.City')]"));
        IWebElement txtPostCode => driver.FindElement(By.XPath("//input[contains(@data-bind,'Address.PostCode')]"));
        IWebElement txtRegion => driver.FindElement(By.XPath("//input[contains(@data-bind,'Address.Region')]"));
        IWebElement txtTargetRent => driver.FindElement(By.XPath("//input[contains(@data-bind,'TargetRent')]"));
        IWebElement txtLandArea => driver.FindElement(By.XPath("//input[contains(@data-bind,'LandArea')]"));
        IWebElement txtBedrooms => driver.FindElement(By.XPath("//input[contains(@data-bind,'Bedroom')]"));
        IWebElement txtCarparks => driver.FindElement(By.XPath("//input[contains(@data-bind,'ParkingSpace')]"));
        IWebElement propertyType => driver.FindElement(By.XPath("(//div[@class='ui selection dropdown full width'])[1]"));
        SelectElement selectPropertyType => new SelectElement(propertyType);
        IWebElement txtDescription => driver.FindElement(By.XPath("//textarea[contains(@data-bind,'Description')]"));
        IWebElement rentType => driver.FindElement(By.XPath("//select[contains(@data-bind,'TargetRentType')]"));
        SelectElement selectRentType => new SelectElement(rentType);
        IWebElement txtFloorArea => driver.FindElement(By.XPath("//input[contains(@data-bind,'FloorArea')]"));
        IWebElement txtBathrooms => driver.FindElement(By.XPath("//input[contains(@data-bind,'Bathroom')]"));
        IWebElement txtYearBuilt => driver.FindElement(By.XPath("//input[contains(@data-bind,'YearBuilt')]"));
        IWebElement errorPropertyName => driver.FindElement(By.XPath("//div[contains(@data-bind,'PropertyName')]"));
        IWebElement errorNumber => driver.FindElement(By.XPath("//div[contains(@data-bind,'Address.Number')]"));
        IWebElement errorStreet => driver.FindElement(By.XPath("//div[contains(@data-bind,'Address.Street')]"));
        IWebElement errorSuburb => driver.FindElement(By.XPath("//div[contains(@data-bind,'Address.Suburb')]"));
        IWebElement errorCity => driver.FindElement(By.XPath("//div[contains(@data-bind,'Address.City')]"));
        IWebElement errorPostCode => driver.FindElement(By.XPath("//div[contains(@data-bind,'Address.PostCode')]"));
        IWebElement errorTargetRent => driver.FindElement(By.XPath("//div[contains(@data-bind,'TargetRent')]"));
        IWebElement errorLandArea => driver.FindElement(By.XPath("//span[contains(text(),'Land area')]"));
        IWebElement errorBedrooms => driver.FindElement(By.XPath("//div[contains(@data-bind,'Bedroom')]"));
        IWebElement errorCarparks => driver.FindElement(By.XPath("//div[contains(@data-bind,'ParkingSpace')]"));
        IWebElement errorDescription => driver.FindElement(By.XPath("//div[contains(@data-bind,'Description')]"));
        IWebElement errorFloorArea => driver.FindElement(By.XPath("//span[contains(text(),'Floor area')]"));
        IWebElement errorBathrooms => driver.FindElement(By.XPath("//div[contains(@data-bind,'Bathroom')]"));
        IWebElement errorYearBuilt => driver.FindElement(By.XPath("//div[contains(@data-bind,'YearBuilt')]"));
        IWebElement chooseFiles => driver.FindElement(By.Id("file-upload"));

        public AddNewPropertyPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void PropertyName(string propertyname)
        {
            txtPropertyName.SendKeys(propertyname);
        }

        public string ErrorPropertyNameText() => errorPropertyName.Text;

        public void SearchAddress(string address)
        {
            txtSearchAddress.SendKeys(address);
        }

        public void Number(string number)
        {
            txtNumber.Clear();
            txtNumber.SendKeys(number);
        }

        public string ErrorNumberText() => errorNumber.Text;

        public void Street(string street)
        {
            txtStreet.Clear();
            txtStreet.SendKeys(street);
        }

        public string ErrorStreetText() => errorStreet.Text;

        public void Suburb(string suburb)
        {
            txtSuburb.Clear();
            txtSuburb.SendKeys(suburb);
        }

        public string ErrorSuburbText => errorSuburb.Text;

        public void City(string city)
        {
            txtCity.Clear();
            txtCity.SendKeys(city);
            //System.Threading.Thread.Sleep(3000);
        }

        public string ErrorCityText() => errorCity.Text;

        public void PostCode(int postcode)
        {
            //txtPostCode.Clear();
            txtPostCode.SendKeys($"{postcode}");
            //txtPostCode.SendKeys(postcode);
        }

        public string ErrorPostCodeText() => errorPostCode.Text;

        public void Region(string region)
        {
            txtRegion.Clear();
            txtRegion.SendKeys(region);
        }

        public void TargetRent(int targetrent)
        {
            txtTargetRent.SendKeys($"{targetrent}");
        }

        public string ErrorTargetRentText() => errorTargetRent.Text;

        public void LandArea(int landarea)
        {
            txtLandArea.SendKeys($"{landarea}");
        }

        public string ErrorLandAreaText() => errorLandArea.Text;

        public void Bedrooms(int bedrooms)
        {
            // txtBedrooms.SendKeys(""+bedrooms);
            //txtBedrooms.SendKeys(bedrooms.ToString());
            txtBedrooms.SendKeys($"{bedrooms}");

        }

        public string ErrorBedroomsText() => errorBedrooms.Text;

        public void Carparks(int carparks)
        {
            txtCarparks.SendKeys($"{carparks}");
        }

        public string ErrorCarparksText() => errorCarparks.Text;

        public void Description(string description)
        {
            txtDescription.SendKeys(description);
        }

        public string ErrorDescriptionText() => errorDescription.Text;

        public void FloorArea(int floorarea)
        {
            txtFloorArea.SendKeys($"{floorarea}");
        }

        public string ErrorFloorAreaText() => errorFloorArea.Text;

        public void Bathrooms(int bathrooms)
        {
            txtBathrooms.SendKeys($"{bathrooms}");
        }

        public string ErrorBathroomsText() => errorBathrooms.Text;

        public void YearBuilt(int yearbuilt)
        {
            txtYearBuilt.SendKeys($"{yearbuilt}");
        }

        public string ErrorYearBuiltText() => errorYearBuilt.Text;


        public void PropertyType(string propertytype)
        {

            selectPropertyType.SelectByText(propertytype);
        }

        public void RentType(string renttype)
        {
            selectRentType.SelectByText(renttype);
        }

        public void ChooseFiles()
        {
            chooseFiles.Click();
            chooseFiles.SendKeys(@"C:\Users\Vidhya\Desktop");
        }

        //ChromeOptions options = new ChromeOptions();


        public void AcceptIfAlertExists()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                String alertText = alert.Text;
                Console.WriteLine("Alert data: " + alertText);
                alert.Accept();

                //var alert = driver.SwitchTo().Alert();
                //if(alert.Text==text)
                //driver.SwitchTo().Alert().Accept();
            }
            catch (UnhandledAlertException f)
            {
                Console.WriteLine("Unexpected Alert was accepted");
                //try
                //{
                //    IAlert alert = driver.SwitchTo().Alert();
                //    String alertText = alert.Text;
                //    Console.WriteLine("Alert data: " + alertText);
                //    alert.Accept();
                //}
                //catch (NoAlertPresentException e)
                //{
                //    Console.WriteLine("No alert is found");
                //}
            }
        }

        //public static void HandleAlert(IWebDriver driver, WebDriverWait wait)
        //{
        //    if (wait == null)
        //    {
        //        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        //    }

        //    try
        //    {
        //        IAlert alert = wait.Until(drv =>
        //        {
        //            try
        //            {
        //                return drv.SwitchTo().Alert();
        //            }
        //            catch (NoAlertPresentException)
        //            {
        //                return null;
        //            }
        //        });
        //        alert.Accept();
        //    }
        //    catch (WebDriverTimeoutException)
        //    {
        //        /* Ignore */
        //    }
            
        //}
    }
}
