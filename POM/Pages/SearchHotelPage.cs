using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Pages
{
    public class SearchHotelPage
    {
        IWebDriver driver;

        SelectElement selectLocation => new SelectElement(driver.FindElement(By.Id("location")));
        IWebElement clickSearch => driver.FindElement(By.ClassName("reg_button"));
        IWebElement locationErrorMsg => driver.FindElement(By.Id("location_span"));
        SelectElement selectNumberOfRooms =>new SelectElement(driver.FindElement(By.Name("room_nos")));
        IWebElement numberOfRoomsErrorMsg => driver.FindElement(By.Id("num_room_span"));
        IWebElement txtCheckIn => driver.FindElement(By.Id("datepick_in"));
        IWebElement checkInDateErrorMsg => driver.FindElement(By.Id("checkin_span"));
        IWebElement txtCheckOut => driver.FindElement(By.Id("datepick_out"));
        IWebElement checkOutDateErrorMsg => driver.FindElement(By.Id("checkout_span"));
        SelectElement adultsPerRoom => new SelectElement(driver.FindElement(By.Id("adult_room")));
        IWebElement adultsPerRoomErrorMsg => driver.FindElement(By.Id("adults_room_span"));

        public SearchHotelPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectLocation(string location )
        {
            selectLocation.SelectByText(location);
            //clickSearch.Click();

        }

        //public string LocationErrorText(string location)
        //{
        //    string l= locationErrorMsg.Text;
        //    return l;
        //}

        public string LocationText() => selectLocation.SelectedOption.Text;
        public string LocationErrorText() => locationErrorMsg.Text;

        public void SelectNumberOfRooms(string numberofrooms)
        {
            selectNumberOfRooms.SelectByText(numberofrooms);
           // clickSearch.Click();
        }

        public string RoomsErrorMsg => numberOfRoomsErrorMsg.Text;

        public void CheckInDate(string checkindate)
        {
            txtCheckIn.Clear();
            txtCheckIn.SendKeys(checkindate);
            //clickSearch.Click();
        }

        public string CheckInErrorMsg => checkInDateErrorMsg.Text;

        public void CheckOutDate(string checkoutdate)
        {
            txtCheckOut.Clear();
            txtCheckOut.SendKeys(checkoutdate);
           // clickSearch.Click();
        }

        public string CheckOutErrorMsg => checkOutDateErrorMsg.Text;

        public void AdultsPerRoom(string noofadults)
        {
            adultsPerRoom.SelectByText(noofadults);
            clickSearch.Click();
        }

        public string AdultErrorMsg => adultsPerRoomErrorMsg.Text;

        public void ClickSearch()
        {
            clickSearch.Click();
        }
    }
}
