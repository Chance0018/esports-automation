using System;
using League.Com.Pages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace League.Com.Pages
{
    public class ServerStatusPage
    {
        readonly IWebDriver _driver;
        readonly WebDriverWait _wait;
        public readonly ServerStatusPageMap Map;

        public ServerStatusPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
            Map = new ServerStatusPageMap(_driver);
        }

        public void Goto()
        {
            SupportMenu.GotoServiceStatusPage();
            WaitForPageLoad();
        }

        public void WaitForPageLoad()
        {
            _wait.Until((drvr) => Map.ServerStatusBanner.Displayed);
        }
    }

    public class ServerStatusPageMap
    {
        readonly IWebDriver _driver;

        public ServerStatusPageMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement ServerStatusBanner => _driver.FindElement(By.XPath("//h1[text()='Server Status']"));
        public IWebElement StatusHeader => _driver.FindElement(By.XPath("//h2[@id='page-header']")); //contains region name
    }
}
