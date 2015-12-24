using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WentToursPOM
{
    class LoginPage
    {
       public IWebDriver driver;
       public LoginPage(IWebDriver driver)
       {
           this.driver = driver;

       }

       public FindFlightPage Do(string UserName, string Password)
       {
           driver.FindElement(By.Name("userName")).SendKeys(UserName);
           driver.FindElement(By.Name("password")).SendKeys(Password);
           driver.FindElement(By.Name("login")).Click();
           return new FindFlightPage(driver);
       }
                
    }
}
