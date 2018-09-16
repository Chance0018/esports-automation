using System;
using OpenQA.Selenium;

namespace League.Com.Pages.Base
{
    public class SupportMenu
    {
        readonly IWebDriver _driver;
        public readonly SupportMenuMap Map;

        public SupportMenu(IWebDriver driver)
        {
            _driver = driver;
            Map = new SupportMenuMap(_driver);
        }

        public void GotoSupportHomePage()
        {
            Map.SupportHomePageLink.Click();
        }

        public void GotoMyTicketsPage()
        {
            Map.MyTicketsPageLink.Click();
        }

        public void GotoSubmitRequestPage()
        {
            Map.SubmitRequestPageLink.Click();
        }

        public void GotoServiceStatusPage()
        {
            Map.ServiceStatusPageLink.Click();
        }
    }

    public class SupportMenuMap
    {
        readonly IWebDriver _driver;

        public SupportMenuMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement SupportHomePageLink => _driver.FindElement(By.XPath("//a[contains(@href, '/hc/en-us')]"));
        public IWebElement MyTicketsPageLink => _driver.FindElement(By.CssSelector("[data-riotbar-link-id='my-tickets']"));
        public IWebElement SubmitRequestPageLink => _driver.FindElement(By.CssSelector("[data-riotbar-link-id='submit-a-request']"));
        public IWebElement ServiceStatusPageLink => _driver.FindElement(By.CssSelector("[data-riotbar-link-id='service-status']"));
    }
}