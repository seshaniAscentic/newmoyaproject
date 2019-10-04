using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace newmoyaproject.PageObject
{ 
    public class SetupApplication
    {
        private IWebDriver driver;
        //public IWebDriver driver
        //{ get;
        //  set;
        //}
        class Loginpage
        {
            public void Loginurl()
            {
                IWebDriver driver = new ChromeDriver(@"C:\Chromedrivers");
                driver.Url = "https://moya-admin-web-dev.azurewebsites.net/";
                driver.Manage().Window.Maximize();
            }
            class Credentials
            {
                public IWebDriver driver;
                public void Username()
                {
                    driver.FindElement(By.Id("i0116")).SendKeys("userEmail");
                }
                public void Password()
                {
                    driver.FindElement(By.Id("idSIButton9")).SendKeys("userpassword");
                }
                public void Btnsubmit()
                {
                    driver.FindElement(By.XPath("//*[@type='submit']"));
                }
                //public void Logintosystem(String userEmail, String userpassword)
                //{
                //        this.username(userEmail);
                //        this.password(userpassword);
                //}
            }
        }
    }
}



