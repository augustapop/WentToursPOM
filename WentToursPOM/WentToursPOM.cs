using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Threading;

namespace WentToursPOM
{
    [TestClass]
    public class WentToursPOM
    {

        private string baseURL = "http://newtours.demoaut.com/";
        private int Timeout = 30;

        IWebDriver driver = new FirefoxDriver();

        [TestMethod]
        public void TestLogin()
        {
            driver.Navigate().GoToUrl(baseURL);
            LoginPage Login = new LoginPage(driver);

            FindFlightPage FindFlight = Login.Do("augustapop@yahoo.com","Abigail_muresan1980");
            if (FindFlight != null)
            {
                FindFlight.Do();
                Thread.Sleep(2000);
                Login = FindFlight.Logout();
            }

        }
    }
}
