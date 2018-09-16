using System;
using OpenQA.Selenium;

namespace League.Com.Pages
{
    public class SupportPage
    {
        readonly IWebDriver _driver;
        public readonly SupportPageMap Map;

        public SupportPage(IWebDriver driver)
        {
            _driver = driver;
            Map = new SupportPageMap(_driver);
        }
    }

    public class SupportPageMap
    {
        readonly IWebDriver _driver;

        public SupportPageMap(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
