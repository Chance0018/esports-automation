using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace League.Merch.Pages
{
    public class ClothingPage
    {
        readonly IWebDriver _driver;
        readonly WebDriverWait _wait;

        public readonly ClothingPageMap Map;

        public ClothingPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
            Map = new ClothingPageMap(_driver);
        }
        public void Goto()
        {
            Map.ClothingTab.Click();
            WaitForPageLoad();
        }
        public void WaitForPageLoad()
        {
            _wait.Until(driver => Map.ClothingBanner.Displayed);
        }
    }

    public class ClothingPageMap
    {
        readonly IWebDriver _driver;


        public ClothingPageMap(IWebDriver driver)
        {
            _driver = driver;
        }

        // public IWebElement Hoodie => _driver.FindElement(By.CssSelector("[href='arcade-pullover-hoodie.html']"));
        public IWebElement ClothingTab => _driver.FindElement(By.LinkText("Clothing"));

        public IWebElement ClothingBanner => _driver.FindElement(By.XPath("//h1[text()='Clothing']"));
    }
}