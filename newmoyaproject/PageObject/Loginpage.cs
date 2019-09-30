using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;


namespace newmoyaproject.PageObject
{
       public class Loginpage
    {
        
        public IWebDriver driver;
        public Loginpage()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Chromedrivers");
            driver.Url = "https://moya-admin-web-dev.azurewebsites.net/";
            driver.Manage().Window.Maximize();
            

        }
        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
    }

    
}
