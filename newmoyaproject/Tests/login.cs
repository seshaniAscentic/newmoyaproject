using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using newmoyaproject.PageObject;

namespace newmoyaproject.PageObject
{
    public class Logindetails : SetupApplication
    {
        //private object Login;

        //new IWebDriver driver;

        public void Enterlogindetails()
        {

           // Login.Logintosystem("seshani@ascentic.se", "Thanushka@123");
        }
        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
    }
}

