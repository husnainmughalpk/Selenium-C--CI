using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumProject1.Pages
{
    internal class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver) { this.driver = driver; }
        IWebElement Loginlink => driver.FindElement(By.LinkText("Log in"));
        LoginLink.click();



    }
}
