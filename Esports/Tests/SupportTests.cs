using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Tests.Base;
using Tests.Settings;

namespace Tests
{
    [TestFixture]
    public class SupportTests : TestBase
    {
        IWebDriver Driver;
        WebDriverWait Wait;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver(Config.DRIVERPATH);
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }

        [TearDown]
        public void CleanUp()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver.Dispose();
            }
        }

        [Test, Category("")]
        public void Submit_support_request_ticket()
        {
            // start on Lol Esports HomePage
            Driver.Navigate().GoToUrl("https://www.lolesports.com/en_US/");

            // Login

            // go to Support

            // go to Submit Ticket page

            // Select request type from list

            // Submit Request
        }

        [Test, Category("")]
        public void Check_the_server_status()
        {
            // start on Lol Esports HomePage
            Driver.Navigate().GoToUrl("https://www.lolesports.com/en_US/");

            // go to Support

            // go to Server Status

            // Select Region

            // Validate status
        }
    }
}
