using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSelenium
{
    class Program
    {

        static void Main(string[] args)
        {
            #region
            // IWebDriver driver = new ChromeDriver();
            // //driver.Navigate().GoToUrl("https://www.google.com/");
            // //IWebElement textSearch = driver.FindElement(By.Name("q"));
            // //textSearch.SendKeys("Melbourne");
            // //textSearch.SendKeys(Keys.Enter);
            // //Console.WriteLine(driver.Title);

            // driver.Manage().Window.Maximize();
            //// driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //Some instance where page takes time to load,wait atleast for 30 seconds for the page to load 
            //                                                                     //and wait for webelement.
            //                                                                     //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            // driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");
            // IWebElement txtUserName = driver.FindElement(By.Name("username"));
            // // txtUserName.Clear();                       // To clear the fields
            // txtUserName.SendKeys("VidhyaVenugan");
            // IWebElement txtPassword = driver.FindElement(By.Id("password"));
            // txtPassword.SendKeys("Ithika2015");
            // IWebElement clickLogin = driver.FindElement(By.Name("login"));
            // clickLogin.Click();

            // IWebElement selectLocation = driver.FindElement(By.Id("location"));
            // SelectElement location = new SelectElement(selectLocation);  //SelectElement is used whenever  there is a drop down menu
            // location.SelectByText("Sydney");

            // IWebElement selectHotel = driver.FindElement(By.Name("hotels"));
            // SelectElement hotels = new SelectElement(selectHotel);
            // hotels.SelectByText("Hotel Creek");

            // IWebElement selectRoomType = driver.FindElement(By.Id("room_type"));
            // SelectElement roomType = new SelectElement(selectRoomType);
            // roomType.SelectByText("Deluxe");

            // IWebElement selectNumberOfRooms = driver.FindElement(By.Name("room_nos"));
            // // selectNumberOfRooms.Clear();
            // SelectElement numberOfRooms = new SelectElement(selectNumberOfRooms);
            // numberOfRooms.SelectByText("4 - Four");

            // IWebElement txtCheckIn = driver.FindElement(By.Id("datepick_in"));
            // txtCheckIn.Clear();
            // txtCheckIn.SendKeys("25/12/2018");

            // IWebElement txtCheckOut = driver.FindElement(By.Id("datepick_out"));
            // txtCheckOut.Clear();
            // txtCheckOut.SendKeys("28/12/2018");

            // IWebElement selectNoOfAdults = driver.FindElement(By.Id("adult_room"));
            // SelectElement adultsPerRoom = new SelectElement(selectNoOfAdults);
            // adultsPerRoom.SelectByText("2 - Two");

            // IWebElement selectNoOfChildren = driver.FindElement(By.Id("child_room"));
            // SelectElement childrenPerRoom = new SelectElement(selectNoOfChildren);
            // childrenPerRoom.SelectByText("1 - One");

            // IWebElement clickSearch = driver.FindElement(By.ClassName("reg_button"));
            // clickSearch.Click();

            // IWebElement selectRadioButton = driver.FindElement(By.Id("radiobutton_0"));
            // selectRadioButton.Click();

            // IWebElement selectContinue = driver.FindElement(By.Id("continue"));
            // selectContinue.Click();

            // IWebElement txtFirstName = driver.FindElement(By.Name("first_name"));
            // txtFirstName.SendKeys("Vidhya");

            // IWebElement txtLastName = driver.FindElement(By.Name("last_name"));
            // txtLastName.SendKeys("Venugan");

            // IWebElement txtAddress = driver.FindElement(By.Id("address"));
            // txtAddress.SendKeys("12 Ebony Way, Tarneit - 3029");

            // IWebElement txtCreditCardNumber = driver.FindElement(By.Name("cc_num"));
            // txtCreditCardNumber.SendKeys("2345 7889 5678 4321");

            // IWebElement selectCreditCardType = driver.FindElement(By.Id("cc_type"));
            // SelectElement creditCardType = new SelectElement(selectCreditCardType);
            // creditCardType.SelectByText("VISA");

            // IWebElement selectMonth = driver.FindElement(By.Id("cc_exp_month"));
            // SelectElement month = new SelectElement(selectMonth);
            // month.SelectByText("March");

            // IWebElement selectYear = driver.FindElement(By.Id("cc_exp_year"));
            // SelectElement year = new SelectElement(selectYear);
            // year.SelectByText("2020");

            // IWebElement txtCvvNumber = driver.FindElement(By.Name("cc_cvv"));
            // txtCvvNumber.SendKeys("234556");

            // IWebElement clickBookNow = driver.FindElement(By.Id("book_now"));
            // clickBookNow.Click();

            // //System.Threading.Thread.Sleep(6000);

            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30)); // Explicit wait is used to click on my itinerary
            // wait.Until(waitDriver => waitDriver.FindElement(By.Id("my_itinerary")).Displayed);

            // //IWebElement clickLogOut = driver.FindElement(By.Id("logout"));
            // //clickLogOut.Click();
            // //IWebElement clickBookedItinerary = driver.FindElement(By.LinkText("Booked Itinerary"));
            // //clickBookedItinerary.Click();
            // IWebElement clickMyItinerary = driver.FindElement(By.Id("my_itinerary"));
            // clickMyItinerary.Click();

            // IList<IWebElement> orderList = driver.FindElements(By.XPath("//input[starts-with(@id,'order_id_')]"));
            // Console.WriteLine("Total selected elements for orders are :" + orderList.Count);
            // foreach (IWebElement ordernos in orderList)
            // {
            //     //System.Threading.Thread.Sleep(2000);
            //     Console.WriteLine(ordernos.GetAttribute("value"));
            // }


            // /* /*Code to be followed after we click logout button
            //  // ================================================
            //  IWebElement clickLogOut = driver.FindElement(By.Id("logout"));
            //  clickLogOut.Click();

            //  //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //  //driver.Navigate().GoToUrl("https://www.adactin.com/HotelApp/");

            //  IWebElement clickToLoginAgain = driver.FindElement(By.LinkText("Click here to login again"));
            //  clickToLoginAgain.Click();

            //  // txtUserName.Clear();                       // To clear the fields
            //  txtUserName = driver.FindElement(By.Name("username"));
            //  txtUserName.SendKeys("VidhyaVenugan");

            //  txtPassword = driver.FindElement(By.Id("password"));
            //  txtPassword.SendKeys("Ithika2015");

            //  clickLogin = driver.FindElement(By.Name("login"));
            //  clickLogin.Click();

            //  IWebElement clickBookedItinerary = driver.FindElement(By.LinkText("Booked Itinerary"));
            //  clickBookedItinerary.Click();

            //  IWebElement clickCheckBox = driver.FindElement(By.Name("check_all"));
            //  clickCheckBox.Click();  //To delete all the bookings

            //  //IWebElement clickOneCheckBox = driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr[2]/td/form/table/tbody/tr[2]/td/table/tbody/tr[2]/td[1]/input"));
            //  //clickOneCheckBox.Click();  //Delete a particular booking

            //  IWebElement clickCancelSelected = driver.FindElement(By.Name("cancelall"));
            //  clickCancelSelected.Click();

            //  driver.SwitchTo().Alert().Accept();

            //  clickLogOut = driver.FindElement(By.Id("logout"));
            //  clickLogOut.Click();

            //  driver.Quit();*/

            // /*Code to be written after booking and without logging out, going to My Itinerery and cancelling the booking
            //  * =========================================================================================================

            // IWebElement clickMyItinerary = driver.FindElement(By.Id("my_itinerary"));
            // clickMyItinerary.Click();

            // IWebElement clickCheckBox = driver.FindElement(By.Name("ids[]"));
            // clickCheckBox.Click();

            // IWebElement clickCancelSelected = driver.FindElement(By.Name("cancelall"));
            // clickCancelSelected.Click();

            // driver.SwitchTo().Alert().Accept();  //Used when there is a pop menu for ok and cancel

            // IWebElement clickLogOut = driver.FindElement(By.Id("logout"));
            // clickLogOut.Click();

            // driver.Quit();         //To close the browser  */

            // /*Commands
            // driver.Manage().Cookies.DeleteAllCookies();

            // System.Threading.Thread.Sleep(3000);

            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            // driver.Close();

            // driver.Quit();*/

            // Console.WriteLine("Hello");
            // IList<IWebElement> cancelList = driver.FindElements(By.XPath("//input[starts-with(@value,'Cancel ')]"));
            // Console.WriteLine("Total selected elements for cancellation are :" + cancelList.Count);
            // foreach (IWebElement list in cancelList)
            // {
            //     string text=list.GetAttribute("value");
            //     string[] splitText = text.Split(' ');
            //     Console.WriteLine($"The order numbers are: {splitText[1]}" );
            // }




            #endregion

            #region
            // IWebDriver driver = new ChromeDriver();
            // driver.Manage().Cookies.DeleteAllCookies();
            // driver.Manage().Window.Maximize();
            // driver.Navigate().GoToUrl("https://www.ebay.com.au/");
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
            // driver.FindElement(By.LinkText("Sign in")).Click();
            // driver.FindElement(By.Id("userid")).SendKeys("t.au740");
            // driver.FindElement(By.Id("pass")).SendKeys("theivanai84");
            // driver.FindElement(By.ClassName("checkbox__control")).Click();
            // System.Threading.Thread.Sleep(3000);
            // driver.FindElement(By.Id("sgnBt")).Click();
            // //driver.FindElement(By.XPath("//*[@id='gh-shop-a']")).Click();
            //// driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[2]/div/div/table/tbody/tr/td[2]/ul[2]/li[4]/a")).Click();
            // driver.FindElement(By.Id("gh-ac")).SendKeys("Wall Hangings");
            // driver.FindElement(By.Id("gh-btn")).Click();
            // System.Threading.Thread.Sleep(3000);
            // driver.Navigate().Back();
            // System.Threading.Thread.Sleep(3000);
            // driver.Navigate().Forward();
            // System.Threading.Thread.Sleep(3000);
            // driver.Navigate().Refresh();
            // System.Threading.Thread.Sleep(3000);
            // driver.FindElement(By.Id("gh-ac")).Clear();
            // driver.FindElement(By.Id("gh-ac")).SendKeys("baby hair accessories");
            // IWebElement dropdown = driver.FindElement(By.Id("gh-cat"));
            // SelectElement selectFromDropDown = new SelectElement(dropdown);
            // selectFromDropDown.SelectByText("All Categories");
            // driver.FindElement(By.Id("gh-btn")).Click();
            // IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            // IWebElement element = driver.FindElement(By.PartialLinkText("Newest Infant Toddler Baby Girl"));
            // js.ExecuteScript("arguments[0].scrollIntoView(true);",element);
            // element.Click();
            // IWebElement style = driver.FindElement(By.Id("msku-sel-1"));
            // SelectElement selectStyle = new SelectElement(style);
            // selectStyle.SelectByIndex(6);
            // driver.FindElement(By.Id("qtyTextBox")).Clear();
            // driver.FindElement(By.Id("qtyTextBox")).SendKeys("2");
            // driver.FindElement(By.Id("atcRedesignId_btn")).Click();
            // System.Threading.Thread.Sleep(3000);
            // driver.FindElement(By.XPath("/html/body/div[6]/div/div[3]/div/div/div/div[1]/div/div[3]/a[2]/span/span")).Click();
            // //driver.FindElement(By.Id("gh-cart-i")).Click(); To get into cart seperately
            // System.Threading.Thread.Sleep(3000);
            // driver.FindElement(By.XPath("//button[@data-test-id = 'cart-remove-item']")).Click();
            // System.Threading.Thread.Sleep(3000);
            // driver.Navigate().Refresh();
            // driver.FindElement(By.Id("gh-ug")).Click();
            // driver.FindElement(By.LinkText("Sign out")).Click();   
            // driver.Close();
            #endregion

            #region
            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Cookies.DeleteAllCookies();
            //driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("https://www.anz.com.au/personal/");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);

            //driver.FindElement(By.XPath("(//span[contains(@class,'padlock')])[2]")).Click();

            //string currentHandle = driver.CurrentWindowHandle;
            //var handles = driver.WindowHandles;

            //foreach (string handle in handles)
            //{
            //    if (handle != currentHandle)
            //        driver.SwitchTo().Window(handle);
            //}
            //driver.SwitchTo().Frame("main");
            //driver.FindElement(By.Id("crn")).SendKeys("CRN764980");
            ////driver.Close();
            //driver.SwitchTo().Window(currentHandle);
            //System.Threading.Thread.Sleep(5000);
            //driver.FindElement(By.XPath("(//span[contains(@class,'padlock')])[2]")).Click();
            #endregion

            #region
            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Cookies.DeleteAllCookies();
            //driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("https://www.hdfcbank.com/");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            //driver.FindElement(By.XPath("//div/div[contains(text(),'Net')]")).Click();
            //driver.FindElement(By.Id("netbanking")).Click();
            //System.Threading.Thread.Sleep(3000);
            //driver.FindElement(By.Id("loginsubmit")).Click();

            //var currentHandle = driver.CurrentWindowHandle;
            //var handles = driver.WindowHandles;
            //foreach (var handle in handles)
            //    if (handle != currentHandle)
            //        driver.SwitchTo().Window(handle);
            //driver.Manage().Window.Maximize();
            //driver.FindElement(By.XPath("(//a[contains(@class,'btn btn-default redBtn')])[5]")).Click();
            ////driver.FindElement(By.XPath("(//a[contains(text(),'Continue to NetBanking')])[3]")).Click();
            //driver.SwitchTo().Frame("login_page");
            //driver.FindElement(By.Name("fldLoginUserId")).SendKeys("27285357");
            //driver.FindElement(By.XPath("//a/img[contains(@alt,'continue')]")).Click();
            //driver.FindElement(By.XPath("(//span/input[contains(@class,'input_password')])[2]")).SendKeys("Ithika2015");
            //driver.FindElement(By.XPath("//td/input[@id='chkrsastu']")).Click();
            //driver.FindElement(By.XPath("//a/img[contains(@alt,'Login')]")).Click();
            //System.Threading.Thread.Sleep(3000);
            //driver.SwitchTo().Frame("common_menu1");
            //driver.FindElement(By.XPath("//a/img[contains(@alt,'Log Out')]")).Click();
            //driver.Close();
            //driver.SwitchTo().Window(currentHandle);
            //driver.Close();

            #endregion

            #region
            // IWebDriver driver = new ChromeDriver();
            // driver.Manage().Cookies.DeleteAllCookies();
            // driver.Manage().Window.Maximize();
            // driver.Navigate().GoToUrl("https://www.yatra.com/");
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            // wait.Until(d=>driver.FindElement(By.XPath("//section/i")).Displayed);
            // driver.FindElement(By.XPath("//section/i")).Click();
            // WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            // wait1.Until(d => driver.FindElement(By.XPath("//section/i")).Displayed);
            // IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            // IWebElement element = driver.FindElement(By.XPath("//tbody/tr[3]/td[4][@id='13/02/2019']"));
            // js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            //// js.ExecuteScript("scroll(0,200)");  //scroll in  the page
            // element.Click();
            // //driver.FindElement(By.XPath("//tbody/tr[3]/td[4][@id='13/02/2019']")).Click();
            #endregion

            #region
            ////Explicit wait
            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Cookies.DeleteAllCookies();
            //driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("https://www.google.com");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.FindElement(By.XPath("//input[contains(@title,'Search')]")).SendKeys("selenium practise.blogspot");
            //driver.FindElement(By.Name("btnK")).Click();
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //wait.Until(d => driver.FindElement(By.PartialLinkText("How to use explicit wait in ...")).Displayed);
            //driver.FindElement(By.PartialLinkText("How to use explicit wait in ...")).Click();
            //driver.FindElement(By.XPath("//button[@onclick='timedText()']")).Click();
            //WebDriverWait waitElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //waitElement.Until(d => driver.FindElement(By.XPath("(//p[contains(text(),'WebDriver')])[1]")).Displayed);

            #endregion
        }

    }
}
