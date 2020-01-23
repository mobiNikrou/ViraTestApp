using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using ViraTestApp.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace ViraTestApp.TestCases
{
    public class TestCase1
    {
        public string[] TestAction1()
        {
            IWebDriver driver;
            driver = new FirefoxDriver();
            driver.Url = "http://life-test:1364/ContactManagingDirector";
            Thread.Sleep(1000);
            driver.Close();
            string[] TstResultArr = { "TR1", "TR2", "TR2" };
            return TstResultArr;
        }
    }
}