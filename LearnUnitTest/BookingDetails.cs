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
    public class BookingDetails
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void AFirstNameNotEntered()
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

            IWebElement selectRadioButton = driver.FindElement(By.Id("radiobutton_0"));
            selectRadioButton.Click();

            IWebElement selectContinue = driver.FindElement(By.Id("continue"));
            selectContinue.Click();

            Assert.True(driver.Title.Contains("Book"));
            // driver.Close();

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

            Assert.AreEqual(driver.FindElement(By.Id("first_name_span")).Text, "Please Enter your First Name");
            driver.Quit();
        }

        [Test]
        public void BLastNameNotEntered()
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

            IWebElement selectRadioButton = driver.FindElement(By.Id("radiobutton_0"));
            selectRadioButton.Click();

            IWebElement selectContinue = driver.FindElement(By.Id("continue"));
            selectContinue.Click();

            Assert.True(driver.Title.Contains("Book"));
            // driver.Close();

            IWebElement txtFirstName = driver.FindElement(By.Name("first_name"));
            txtFirstName.SendKeys("Vidhya");

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

            Assert.AreEqual(driver.FindElement(By.Id("last_name_span")).Text, "Please Enter you Last Name");
            driver.Quit();
        }

        [Test]
        public void CBillingAddressNotEntered()
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

            Assert.AreEqual(driver.FindElement(By.Id("address_span")).Text, "Please Enter your Address");
            driver.Quit();
        }

        [Test]
        public void DInvalidCreditCardNumber()
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
            txtCreditCardNumber.SendKeys("2345 7889 5678"); //Less than 16 digit

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

            Assert.AreEqual(driver.FindElement(By.Id("cc_num_span")).Text, "Please Enter your 16 Digit Credit Card Number");
            driver.Quit();
        }

        [Test]
        public void ECCTypeNotSelected()
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
            txtCreditCardNumber.SendKeys("2345 7889 5678 1234");

            IWebElement selectCreditCardType = driver.FindElement(By.Id("cc_type"));
            SelectElement creditCardType = new SelectElement(selectCreditCardType);
            creditCardType.SelectByText("- Select Credit Card Type -");

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

            Assert.AreEqual(driver.FindElement(By.Id("cc_type_span")).Text, "Please Select your Credit Card Type");
            driver.Quit();
        }

        [Test]
        public void FExpiryMonthNotSelected()
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
            txtCreditCardNumber.SendKeys("2345 7889 5678 1234");

            IWebElement selectCreditCardType = driver.FindElement(By.Id("cc_type"));
            SelectElement creditCardType = new SelectElement(selectCreditCardType);
            creditCardType.SelectByText("VISA");

            IWebElement selectMonth = driver.FindElement(By.Id("cc_exp_month"));
            SelectElement month = new SelectElement(selectMonth);
            month.SelectByText("- Select Month -");

            IWebElement selectYear = driver.FindElement(By.Id("cc_exp_year"));
            SelectElement year = new SelectElement(selectYear);
            year.SelectByText("2020");

            IWebElement txtCvvNumber = driver.FindElement(By.Name("cc_cvv"));
            txtCvvNumber.SendKeys("234556");

            IWebElement clickBookNow = driver.FindElement(By.Id("book_now"));
            clickBookNow.Click();

            Assert.AreEqual(driver.FindElement(By.Id("cc_expiry_span")).Text, "Please Select your Credit Card Expiry Month");
            driver.Quit();
        }

        [Test]
        public void GExpiryYearNotSelected()
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
            txtCreditCardNumber.SendKeys("2345 7889 5678 1234");

            IWebElement selectCreditCardType = driver.FindElement(By.Id("cc_type"));
            SelectElement creditCardType = new SelectElement(selectCreditCardType);
            creditCardType.SelectByText("VISA");

            IWebElement selectMonth = driver.FindElement(By.Id("cc_exp_month"));
            SelectElement month = new SelectElement(selectMonth);
            month.SelectByText("March");

            IWebElement selectYear = driver.FindElement(By.Id("cc_exp_year"));
            SelectElement year = new SelectElement(selectYear);
            year.SelectByText("- Select Year -");

            IWebElement txtCvvNumber = driver.FindElement(By.Name("cc_cvv"));
            txtCvvNumber.SendKeys("234556");

            IWebElement clickBookNow = driver.FindElement(By.Id("book_now"));
            clickBookNow.Click();

            Assert.AreEqual(driver.FindElement(By.Id("cc_expiry_span")).Text, "Please Select your Credit Card Expiry Year");
            driver.Quit();
        }

        [Test]
        public void HCVVNumberNotEntered()
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
            txtCreditCardNumber.SendKeys("2345 7889 5678 1234");

            IWebElement selectCreditCardType = driver.FindElement(By.Id("cc_type"));
            SelectElement creditCardType = new SelectElement(selectCreditCardType);
            creditCardType.SelectByText("VISA");

            IWebElement selectMonth = driver.FindElement(By.Id("cc_exp_month"));
            SelectElement month = new SelectElement(selectMonth);
            month.SelectByText("March");

            IWebElement selectYear = driver.FindElement(By.Id("cc_exp_year"));
            SelectElement year = new SelectElement(selectYear);
            year.SelectByText("2020");

            //IWebElement txtCvvNumber = driver.FindElement(By.Name("cc_cvv"));
            //txtCvvNumber.SendKeys("abcd");

            IWebElement clickBookNow = driver.FindElement(By.Id("book_now"));
            clickBookNow.Click();

            Assert.AreEqual(driver.FindElement(By.Id("cc_cvv_span")).Text, "Please Enter your Credit Card CVV Number");
            driver.Quit();
        }

        [Test]
        public void IBookingDetailsNotEntered()
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

            IWebElement selectRadioButton = driver.FindElement(By.Id("radiobutton_0"));
            selectRadioButton.Click();

            IWebElement selectContinue = driver.FindElement(By.Id("continue"));
            selectContinue.Click();

            Assert.True(driver.Title.Contains("Book"));
            // driver.Close();

            //IWebElement txtFirstName = driver.FindElement(By.Name("first_name"));
            //txtFirstName.SendKeys("Vidhya");

            //IWebElement txtLastName = driver.FindElement(By.Name("last_name"));
            //txtLastName.SendKeys("Venugan");

            //IWebElement txtAddress = driver.FindElement(By.Id("address"));
            //txtAddress.SendKeys("12 Ebony Way, Tarneit - 3029");

            //IWebElement txtCreditCardNumber = driver.FindElement(By.Name("cc_num"));
            //txtCreditCardNumber.SendKeys("2345 7889 5678");

            //IWebElement selectCreditCardType = driver.FindElement(By.Id("cc_type"));
            //SelectElement creditCardType = new SelectElement(selectCreditCardType);
            //creditCardType.SelectByText("VISA");

            //IWebElement selectMonth = driver.FindElement(By.Id("cc_exp_month"));
            //SelectElement month = new SelectElement(selectMonth);
            //month.SelectByText("March");

            //IWebElement selectYear = driver.FindElement(By.Id("cc_exp_year"));
            //SelectElement year = new SelectElement(selectYear);
            //year.SelectByText("2020");

            //IWebElement txtCvvNumber = driver.FindElement(By.Name("cc_cvv"));
            //txtCvvNumber.SendKeys("234556");

            IWebElement clickBookNow = driver.FindElement(By.Id("book_now"));
            clickBookNow.Click();

            //Assert.AreEqual(driver.FindElement(By.Id("cc_cvv_span")).Text, "Please Enter your Credit Card CVV Number");
            driver.Quit();
        }
        [Test]
        public void JSuccessfulBooking()
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
            txtCvvNumber.SendKeys("2345");

            IWebElement clickBookNow = driver.FindElement(By.Id("book_now"));
            clickBookNow.Click();

            WebDriverWait bookingwait = new WebDriverWait(driver, TimeSpan.FromSeconds(30)); // Explicit wait is used to click on my itinerary
            bookingwait.Until(waitDriver => waitDriver.FindElement(By.Id("my_itinerary")).Displayed);

            Assert.True(driver.Title.Contains("Booking"));
            IWebElement clickLogOut = driver.FindElement(By.Id("logout"));
            clickLogOut.Click();
            driver.Quit();

        }
    }
}
