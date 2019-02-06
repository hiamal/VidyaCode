using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnUnitTest
{
    public class HotelBooking
    {
        IWebDriver driver = new ChromeDriver();
        [Test]
        public void ASuccessfulHotelBooking()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //Some instance where page takes time to load,wait atleast for 30 seconds for the page to load 
                                                                                //and wait for webelement.
                                                                                //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            IWebElement txtUserName = driver.FindElement(By.Name("username"));
            // txtUserName.Clear();                       // To clear the fields
            txtUserName.SendKeys("VidhyaVenugan");
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            txtPassword.SendKeys("Ithika2015");
            IWebElement clickLogin = driver.FindElement(By.Name("login"));
            clickLogin.Click();
            Assert.True(driver.Title.Contains("Search"));
            IWebElement selectLocation = driver.FindElement(By.Id("location"));
            SelectElement location = new SelectElement(selectLocation);  //SelectElement is used whenever  there is a drop down menu
            location.SelectByText("Sydney");

            IWebElement selectHotel = driver.FindElement(By.Name("hotels"));
            SelectElement hotels = new SelectElement(selectHotel);
            hotels.SelectByText("Hotel Creek");

            IWebElement selectRoomType = driver.FindElement(By.Id("room_type"));
            SelectElement roomType = new SelectElement(selectRoomType);
            roomType.SelectByText("Deluxe");

            IWebElement selectNumberOfRooms = driver.FindElement(By.Name("room_nos"));
            // selectNumberOfRooms.Clear();
            SelectElement numberOfRooms = new SelectElement(selectNumberOfRooms);
            numberOfRooms.SelectByText("4 - Four");

            IWebElement txtCheckIn = driver.FindElement(By.Id("datepick_in"));
            txtCheckIn.Clear();
            txtCheckIn.SendKeys("21/01/2019");

            IWebElement txtCheckOut = driver.FindElement(By.Id("datepick_out"));
            txtCheckOut.Clear();
            txtCheckOut.SendKeys("22/01/2019");

            IWebElement selectNoOfAdults = driver.FindElement(By.Id("adult_room"));
            SelectElement adultsPerRoom = new SelectElement(selectNoOfAdults);
            adultsPerRoom.SelectByText("2 - Two");

            IWebElement selectNoOfChildren = driver.FindElement(By.Id("child_room"));
            SelectElement childrenPerRoom = new SelectElement(selectNoOfChildren);
            childrenPerRoom.SelectByText("1 - One");

            IWebElement clickSearch = driver.FindElement(By.ClassName("reg_button"));
            clickSearch.Click();

            Assert.True(driver.Title.Contains("Select"));

            // System.Threading.Thread.Sleep(3000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(waitDriver => driver.FindElement(By.Id("radiobutton_0")).Displayed);

            IWebElement selectRadioButton = driver.FindElement(By.Id("radiobutton_0"));
            selectRadioButton.Click();

            IWebElement selectContinue = driver.FindElement(By.Id("continue"));
            selectContinue.Click();

            Assert.True(driver.Title.Contains("Book"));
            // driver.Close();

            IWebElement txtFirstName = driver.FindElement(By.Name("first_name"));
            txtFirstName.SendKeys("Vidhya");

            IWebElement txtLastName = driver.FindElement(By.Name("last_name"));
            txtLastName.SendKeys("Venugan");

            IWebElement txtAddress = driver.FindElement(By.Id("address"));
            txtAddress.SendKeys("12 Ebony Way, Tarneit - 3029");

            IWebElement txtCreditCardNumber = driver.FindElement(By.Name("cc_num"));
            txtCreditCardNumber.SendKeys("2345 7889 5678 4321");

            IWebElement selectCreditCardType = driver.FindElement(By.Id("cc_type"));
            SelectElement creditCardType = new SelectElement(selectCreditCardType);
            creditCardType.SelectByText("VISA");

            IWebElement selectMonth = driver.FindElement(By.Id("cc_exp_month"));
            SelectElement month = new SelectElement(selectMonth);
            month.SelectByText("March");

            IWebElement selectYear = driver.FindElement(By.Id("cc_exp_year"));
            SelectElement year = new SelectElement(selectYear);
            year.SelectByText("2020");

            IWebElement txtCvvNumber = driver.FindElement(By.Name("cc_cvv"));
            txtCvvNumber.SendKeys("234556");

            IWebElement clickBookNow = driver.FindElement(By.Id("book_now"));
            clickBookNow.Click();

            WebDriverWait waitForConfirmation = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            waitForConfirmation.Until(d => driver.FindElement(By.Id("my_itinerary")).Displayed);

            Assert.True(driver.Title.Contains("Booking"));

            IWebElement clickLogOut = driver.FindElement(By.Id("logout"));
            clickLogOut.Click();

            driver.Quit();
        }

        [Test]
        public void BLocationNotSelected()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //Some instance where page takes time to load,wait atleast for 30 seconds for the page to load 
                                                                                //and wait for webelement.
                                                                                //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            IWebElement txtUserName = driver.FindElement(By.Name("username"));
            // txtUserName.Clear();                       // To clear the fields
            txtUserName.SendKeys("VidhyaVenugan");
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            txtPassword.SendKeys("Ithika2015");
            IWebElement clickLogin = driver.FindElement(By.Name("login"));
            clickLogin.Click();
            Assert.True(driver.Title.Contains("Search"));
            IWebElement selectLocation = driver.FindElement(By.Id("location"));
            SelectElement location = new SelectElement(selectLocation);  //SelectElement is used whenever  there is a drop down menu
            location.SelectByText("- Select Location -");

            IWebElement selectHotel = driver.FindElement(By.Name("hotels"));
            SelectElement hotels = new SelectElement(selectHotel);
            hotels.SelectByText("Hotel Creek");

            IWebElement selectRoomType = driver.FindElement(By.Id("room_type"));
            SelectElement roomType = new SelectElement(selectRoomType);
            roomType.SelectByText("Deluxe");

            IWebElement selectNumberOfRooms = driver.FindElement(By.Name("room_nos"));
            // selectNumberOfRooms.Clear();
            SelectElement numberOfRooms = new SelectElement(selectNumberOfRooms);
            numberOfRooms.SelectByText("4 - Four");

            IWebElement txtCheckIn = driver.FindElement(By.Id("datepick_in"));
            txtCheckIn.Clear();
            txtCheckIn.SendKeys("25/12/2018");

            IWebElement txtCheckOut = driver.FindElement(By.Id("datepick_out"));
            txtCheckOut.Clear();
            txtCheckOut.SendKeys("28/12/2018");

            IWebElement selectNoOfAdults = driver.FindElement(By.Id("adult_room"));
            SelectElement adultsPerRoom = new SelectElement(selectNoOfAdults);
            adultsPerRoom.SelectByText("2 - Two");

            IWebElement selectNoOfChildren = driver.FindElement(By.Id("child_room"));
            SelectElement childrenPerRoom = new SelectElement(selectNoOfChildren);
            childrenPerRoom.SelectByText("1 - One");

            IWebElement clickSearch = driver.FindElement(By.ClassName("reg_button"));
            clickSearch.Click();

            Assert.AreEqual(driver.FindElement(By.Id("location_span")).Text, "Please Select a Location");
            driver.Quit();

        }

        [Test]
        public void CRoomsNotSelected()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //Some instance where page takes time to load,wait atleast for 30 seconds for the page to load 
                                                                                //and wait for webelement.
                                                                                //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            IWebElement txtUserName = driver.FindElement(By.Name("username"));
            // txtUserName.Clear();                       // To clear the fields
            txtUserName.SendKeys("VidhyaVenugan");
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            txtPassword.SendKeys("Ithika2015");
            IWebElement clickLogin = driver.FindElement(By.Name("login"));
            clickLogin.Click();

            IWebElement selectLocation = driver.FindElement(By.Id("location"));
            SelectElement location = new SelectElement(selectLocation);  //SelectElement is used whenever  there is a drop down menu
            location.SelectByText("Sydney");

            IWebElement selectHotel = driver.FindElement(By.Name("hotels"));
            SelectElement hotels = new SelectElement(selectHotel);
            hotels.SelectByText("Hotel Creek");

            IWebElement selectRoomType = driver.FindElement(By.Id("room_type"));
            SelectElement roomType = new SelectElement(selectRoomType);
            roomType.SelectByText("Deluxe");

            IWebElement selectNumberOfRooms = driver.FindElement(By.Name("room_nos"));
            SelectElement numberOfRooms = new SelectElement(selectNumberOfRooms);
            numberOfRooms.SelectByText("- Select Number of Rooms -");

            IWebElement txtCheckIn = driver.FindElement(By.Id("datepick_in"));
            txtCheckIn.Clear();
            txtCheckIn.SendKeys("25/12/2018");

            IWebElement txtCheckOut = driver.FindElement(By.Id("datepick_out"));
            txtCheckOut.Clear();
            txtCheckOut.SendKeys("28/12/2018");

            IWebElement selectNoOfAdults = driver.FindElement(By.Id("adult_room"));
            SelectElement adultsPerRoom = new SelectElement(selectNoOfAdults);
            adultsPerRoom.SelectByText("2 - Two");

            IWebElement selectNoOfChildren = driver.FindElement(By.Id("child_room"));
            SelectElement childrenPerRoom = new SelectElement(selectNoOfChildren);
            childrenPerRoom.SelectByText("1 - One");

            IWebElement clickSearch = driver.FindElement(By.ClassName("reg_button"));
            clickSearch.Click();

            Assert.AreEqual(driver.FindElement(By.Id("num_room_span")).Text, "Please Select Total Number of Rooms");
            driver.Quit();
        }

        [Test]
        public void DCheckInDateFormatIncorrect()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //Some instance where page takes time to load,wait atleast for 30 seconds for the page to load 
                                                                                //and wait for webelement.
                                                                                //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelAppBuild2/");
            IWebElement txtUserName = driver.FindElement(By.Name("username"));
            // txtUserName.Clear();                       // To clear the fields
            txtUserName.SendKeys("VidhyaVenugan");
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            txtPassword.SendKeys("Ithika2015");
            IWebElement clickLogin = driver.FindElement(By.Name("login"));
            clickLogin.Click();

            IWebElement selectLocation = driver.FindElement(By.Id("location"));
            SelectElement location = new SelectElement(selectLocation);  //SelectElement is used whenever  there is a drop down menu
            location.SelectByText("Sydney");

            IWebElement selectHotel = driver.FindElement(By.Name("hotels"));
            SelectElement hotels = new SelectElement(selectHotel);
            hotels.SelectByText("Hotel Creek");

            IWebElement selectRoomType = driver.FindElement(By.Id("room_type"));
            SelectElement roomType = new SelectElement(selectRoomType);
            roomType.SelectByText("Deluxe");

            IWebElement selectNumberOfRooms = driver.FindElement(By.Name("room_nos"));
            SelectElement numberOfRooms = new SelectElement(selectNumberOfRooms);
            numberOfRooms.SelectByText("4 - Four");

            //IWebElement txtCheckIn = driver.FindElement(By.Id("datepick_in"));
            //txtCheckIn.Clear();
            //txtCheckIn.SendKeys("21/01/2019"); 

            IWebElement txtCheckIn = driver.FindElement(By.Id("datepick_in"));
            txtCheckIn.Clear();
            txtCheckIn.SendKeys("19/01/2019"); //Any format of date is not accepted

            IWebElement txtCheckOut = driver.FindElement(By.Id("datepick_out"));
            txtCheckOut.Clear();
            txtCheckOut.SendKeys("22/01/2019");

            IWebElement selectNoOfAdults = driver.FindElement(By.Id("adult_room"));
            SelectElement adultsPerRoom = new SelectElement(selectNoOfAdults);
            adultsPerRoom.SelectByText("2 - Two");

            IWebElement selectNoOfChildren = driver.FindElement(By.Id("child_room"));
            SelectElement childrenPerRoom = new SelectElement(selectNoOfChildren);
            childrenPerRoom.SelectByText("1 - One");

            IWebElement clickSearch = driver.FindElement(By.ClassName("reg_button"));
            clickSearch.Click();

            Assert.AreEqual(driver.FindElement(By.Id("checkin_span")).Text, "Check-In Date should be either Today or Later Date");//Check in date before system date

            //Assert.AreEqual(driver.FindElement(By.Id("checkin_span")).Text, "Check-In Date shall be before than Check-Out Date");//Check in date with system date and check out date before system date
            driver.Quit();
        }

        [Test]
        public void ECheckOutDateFormatIncorrect()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //Some instance where page takes time to load,wait atleast for 30 seconds for the page to load 
                                                                                //and wait for webelement.
                                                                                //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelAppBuild2/");
            IWebElement txtUserName = driver.FindElement(By.Name("username"));
            // txtUserName.Clear();                       // To clear the fields
            txtUserName.SendKeys("VidhyaVenugan");
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            txtPassword.SendKeys("Ithika2015");
            IWebElement clickLogin = driver.FindElement(By.Name("login"));
            clickLogin.Click();

            IWebElement selectLocation = driver.FindElement(By.Id("location"));
            SelectElement location = new SelectElement(selectLocation);  //SelectElement is used whenever  there is a drop down menu
            location.SelectByText("Sydney");

            IWebElement selectHotel = driver.FindElement(By.Name("hotels"));
            SelectElement hotels = new SelectElement(selectHotel);
            hotels.SelectByText("Hotel Creek");

            IWebElement selectRoomType = driver.FindElement(By.Id("room_type"));
            SelectElement roomType = new SelectElement(selectRoomType);
            roomType.SelectByText("Deluxe");

            IWebElement selectNumberOfRooms = driver.FindElement(By.Name("room_nos"));
            SelectElement numberOfRooms = new SelectElement(selectNumberOfRooms);
            numberOfRooms.SelectByText("4 - Four");

            IWebElement txtCheckIn = driver.FindElement(By.Id("datepick_in"));
            txtCheckIn.Clear();
            txtCheckIn.SendKeys("21/01/2019");

            IWebElement txtCheckOut = driver.FindElement(By.Id("datepick_out"));
            txtCheckOut.Clear();
            txtCheckOut.SendKeys("20/01/2019"); //Any format of date is not accepted

            IWebElement selectNoOfAdults = driver.FindElement(By.Id("adult_room"));
            SelectElement adultsPerRoom = new SelectElement(selectNoOfAdults);
            adultsPerRoom.SelectByText("2 - Two");

            IWebElement selectNoOfChildren = driver.FindElement(By.Id("child_room"));
            SelectElement childrenPerRoom = new SelectElement(selectNoOfChildren);
            childrenPerRoom.SelectByText("1 - One");

            IWebElement clickSearch = driver.FindElement(By.ClassName("reg_button"));
            clickSearch.Click();

            Assert.AreEqual(driver.FindElement(By.Id("checkout_span")).Text, "Check-Out Date shall be after than Check-In Date");
            driver.Quit();
        }

        [Test]

         public void FCheckInDateAndCheckOutDateSame()
        {

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //Some instance where page takes time to load,wait atleast for 30 seconds for the page to load 
                                                                                //and wait for webelement.
                                                                                //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelAppBuild2/");
            IWebElement txtUserName = driver.FindElement(By.Name("username"));
            // txtUserName.Clear();                       // To clear the fields
            txtUserName.SendKeys("VidhyaVenugan");
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            txtPassword.SendKeys("Ithika2015");
            IWebElement clickLogin = driver.FindElement(By.Name("login"));
            clickLogin.Click();

            IWebElement selectLocation = driver.FindElement(By.Id("location"));
            SelectElement location = new SelectElement(selectLocation);  //SelectElement is used whenever  there is a drop down menu
            location.SelectByText("Sydney");

            IWebElement selectHotel = driver.FindElement(By.Name("hotels"));
            SelectElement hotels = new SelectElement(selectHotel);
            hotels.SelectByText("Hotel Creek");

            IWebElement selectRoomType = driver.FindElement(By.Id("room_type"));
            SelectElement roomType = new SelectElement(selectRoomType);
            roomType.SelectByText("Deluxe");

            IWebElement selectNumberOfRooms = driver.FindElement(By.Name("room_nos"));
            SelectElement numberOfRooms = new SelectElement(selectNumberOfRooms);
            numberOfRooms.SelectByText("4 - Four");

            IWebElement txtCheckIn = driver.FindElement(By.Id("datepick_in"));
            txtCheckIn.Clear();
            txtCheckIn.SendKeys("21/01/2019");

            IWebElement txtCheckOut = driver.FindElement(By.Id("datepick_out"));
            txtCheckOut.Clear();
            txtCheckOut.SendKeys("21/01/2019"); //Any format of date is not accepted

            IWebElement selectNoOfAdults = driver.FindElement(By.Id("adult_room"));
            SelectElement adultsPerRoom = new SelectElement(selectNoOfAdults);
            adultsPerRoom.SelectByText("2 - Two");

            IWebElement selectNoOfChildren = driver.FindElement(By.Id("child_room"));
            SelectElement childrenPerRoom = new SelectElement(selectNoOfChildren);
            childrenPerRoom.SelectByText("1 - One");

            IWebElement clickSearch = driver.FindElement(By.ClassName("reg_button"));
            clickSearch.Click();

            Assert.AreEqual(driver.FindElement(By.Id("checkout_span")).Text,
                "Check-in and Check-out date cannot be same");
            driver.Quit();

        }

        [Test]
        public void GAdultsPerRoomNotSelected()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //Some instance where page takes time to load,wait atleast for 30 seconds for the page to load 
                                                                                //and wait for webelement.
                                                                                //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            IWebElement txtUserName = driver.FindElement(By.Name("username"));
            // txtUserName.Clear();                       // To clear the fields
            txtUserName.SendKeys("VidhyaVenugan");
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            txtPassword.SendKeys("Ithika2015");
            IWebElement clickLogin = driver.FindElement(By.Name("login"));
            clickLogin.Click();

            IWebElement selectLocation = driver.FindElement(By.Id("location"));
            SelectElement location = new SelectElement(selectLocation);  //SelectElement is used whenever  there is a drop down menu
            location.SelectByText("Sydney");

            IWebElement selectHotel = driver.FindElement(By.Name("hotels"));
            SelectElement hotels = new SelectElement(selectHotel);
            hotels.SelectByText("Hotel Creek");

            IWebElement selectRoomType = driver.FindElement(By.Id("room_type"));
            SelectElement roomType = new SelectElement(selectRoomType);
            roomType.SelectByText("Deluxe");

            IWebElement selectNumberOfRooms = driver.FindElement(By.Name("room_nos"));
            // selectNumberOfRooms.Clear();
            SelectElement numberOfRooms = new SelectElement(selectNumberOfRooms);
            numberOfRooms.SelectByText("4 - Four");

            IWebElement txtCheckIn = driver.FindElement(By.Id("datepick_in"));
            txtCheckIn.Clear();
            txtCheckIn.SendKeys("25/12/2018");

            IWebElement txtCheckOut = driver.FindElement(By.Id("datepick_out"));
            txtCheckOut.Clear();
            txtCheckOut.SendKeys("28/12/2018");

            IWebElement selectNoOfAdults = driver.FindElement(By.Id("adult_room"));
            SelectElement adultsPerRoom = new SelectElement(selectNoOfAdults);
            adultsPerRoom.SelectByText("- Select Adults per Room -");

            IWebElement selectNoOfChildren = driver.FindElement(By.Id("child_room"));
            SelectElement childrenPerRoom = new SelectElement(selectNoOfChildren);
            childrenPerRoom.SelectByText("1 - One");

            IWebElement clickSearch = driver.FindElement(By.ClassName("reg_button"));
            clickSearch.Click();

            Assert.AreEqual(driver.FindElement(By.Id("adults_room_span")).Text, "Please Select Adults per Room");
            driver.Quit();
        }

        [Test]
        public void HAllInvalidEntries()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //Some instance where page takes time to load,wait atleast for 30 seconds for the page to load 
                                                                                //and wait for webelement.
                                                                                //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            IWebElement txtUserName = driver.FindElement(By.Name("username"));
            // txtUserName.Clear();                       // To clear the fields
            txtUserName.SendKeys("VidhyaVenugan");
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            txtPassword.SendKeys("Ithika2015");
            IWebElement clickLogin = driver.FindElement(By.Name("login"));
            clickLogin.Click();

            IWebElement selectLocation = driver.FindElement(By.Id("location"));
            SelectElement location = new SelectElement(selectLocation);  //SelectElement is used whenever  there is a drop down menu
            location.SelectByText("- Select Location -");

            IWebElement selectHotel = driver.FindElement(By.Name("hotels"));
            SelectElement hotels = new SelectElement(selectHotel);
            hotels.SelectByText("Hotel Creek");

            IWebElement selectRoomType = driver.FindElement(By.Id("room_type"));
            SelectElement roomType = new SelectElement(selectRoomType);
            roomType.SelectByText("Deluxe");

            IWebElement selectNumberOfRooms = driver.FindElement(By.Name("room_nos"));
            SelectElement numberOfRooms = new SelectElement(selectNumberOfRooms);
            numberOfRooms.SelectByText("- Select Number of Rooms -");

            IWebElement txtCheckIn = driver.FindElement(By.Id("datepick_in"));
            txtCheckIn.Clear();
            txtCheckIn.SendKeys("17/01/2019");

            IWebElement txtCheckOut = driver.FindElement(By.Id("datepick_out"));
            txtCheckOut.Clear();
            txtCheckOut.SendKeys("2019/01/18");

            IWebElement selectNoOfAdults = driver.FindElement(By.Id("adult_room"));
            SelectElement adultsPerRoom = new SelectElement(selectNoOfAdults);
            adultsPerRoom.SelectByText("- Select Adults per Room -");

            IWebElement selectNoOfChildren = driver.FindElement(By.Id("child_room"));
            SelectElement childrenPerRoom = new SelectElement(selectNoOfChildren);
            childrenPerRoom.SelectByText("1 - One");

            IWebElement clickSearch = driver.FindElement(By.ClassName("reg_button"));
            clickSearch.Click();

            driver.Quit();
        }

        [Test]
        public void HHotelNotSelected()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //Some instance where page takes time to load,wait atleast for 30 seconds for the page to load 
                                                                                //and wait for webelement.
                                                                                //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            IWebElement txtUserName = driver.FindElement(By.Name("username"));
            // txtUserName.Clear();                       // To clear the fields
            txtUserName.SendKeys("VidhyaVenugan");
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            txtPassword.SendKeys("Ithika2015");
            IWebElement clickLogin = driver.FindElement(By.Name("login"));
            clickLogin.Click();

            IWebElement selectLocation = driver.FindElement(By.Id("location"));
            SelectElement location = new SelectElement(selectLocation);  //SelectElement is used whenever  there is a drop down menu
            location.SelectByText("Sydney");

            IWebElement selectHotel = driver.FindElement(By.Name("hotels"));
            SelectElement hotels = new SelectElement(selectHotel);
            hotels.SelectByText("Hotel Creek");

            IWebElement selectRoomType = driver.FindElement(By.Id("room_type"));
            SelectElement roomType = new SelectElement(selectRoomType);
            roomType.SelectByText("Deluxe");

            IWebElement selectNumberOfRooms = driver.FindElement(By.Name("room_nos"));
            // selectNumberOfRooms.Clear();
            SelectElement numberOfRooms = new SelectElement(selectNumberOfRooms);
            numberOfRooms.SelectByText("4 - Four");

            IWebElement txtCheckIn = driver.FindElement(By.Id("datepick_in"));
            txtCheckIn.Clear();
            txtCheckIn.SendKeys("25/12/2018");

            IWebElement txtCheckOut = driver.FindElement(By.Id("datepick_out"));
            txtCheckOut.Clear();
            txtCheckOut.SendKeys("28/12/2018");

            IWebElement selectNoOfAdults = driver.FindElement(By.Id("adult_room"));
            SelectElement adultsPerRoom = new SelectElement(selectNoOfAdults);
            adultsPerRoom.SelectByText("2 - Two");

            IWebElement selectNoOfChildren = driver.FindElement(By.Id("child_room"));
            SelectElement childrenPerRoom = new SelectElement(selectNoOfChildren);
            childrenPerRoom.SelectByText("1 - One");

            IWebElement clickSearch = driver.FindElement(By.ClassName("reg_button"));
            clickSearch.Click();

            Assert.True(driver.Title.Contains("Select"));

            // System.Threading.Thread.Sleep(3000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(waitDriver => driver.FindElement(By.Id("radiobutton_0")).Displayed);

            IWebElement selectContinue = driver.FindElement(By.Id("continue"));
            selectContinue.Click();

            Assert.AreEqual(driver.FindElement(By.Id("radiobutton_span")).Text, "Please Select a Hotel");
            driver.Quit();
        }
    }
}
