using System;
using League.Com.Pages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace League.Com.Pages
{
    public class SubmitRequestPage
    {
        readonly IWebDriver _driver;
        readonly WebDriverWait _wait;
        public readonly SubmitRequestPageMap Map;

        public SubmitRequestPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
            Map = new SubmitRequestPageMap(_driver);
        }

        public void Goto()
        {
            SupportMenu.GotoSubmitRequestPage();
            WaitForPageLoad();
        }
        
        
        public void Login(string username, string password)
        {
            Map.LoginButton.Click();
            WaitForLoginPageLoad();
            Map.UsernameField.SendKeys(username);
            Map.PasswordField.SendKeys(password);
        }

        public void SubmitRequest()
        {
            //select from request type
            Map.AnonymousEmailField.SendKeys(""); //need anonyous email
            Map.SubjectField.SendKeys(""); //need subject
            Map.DescriptionField.SendKeys(""); //need description

            //select region
            Map.VerifyHumanCheckbox.Click();
            Map.SubmitTicketButton.Click();
        }

        public void WaitForLoginPageLoad()
        {
            _wait.Until((drvr) => Map.UsernameField.Displayed);
        }

        public void WaitForPageLoad()
        {
            _wait.Until((drvr) => Map.SubmitRequestHeader.Displayed);
        }
    }

    public class SubmitRequestPageMap
    {
        readonly IWebDriver _driver;

        public SubmitRequestPageMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement SubmitRequestHeader => _driver.FindElement(By.XPath("z-dc[text()='Submit a request']"));

        //login
        public IWebElement LoginButton => _driver.FindElement(By.XPath("a[text()='Login']"));
        public IWebElement UsernameField => _driver.FindElement(By.Id("login-form-username"));
        public IWebElement PasswordField => _driver.FindElement(By.Id("login-form-password"));

        //selecting request type
        public IWebElement RequestTypeDropdown => _driver.FindElement(By.Id("form-dropdown"));

        //tell us more section
        public IWebElement AnonymousEmailField => _driver.FindElement(By.Id("field-anonymous_requester_email"));
        public IWebElement SubjectField => _driver.FindElement(By.Name("request[subject]"));
        public IWebElement DescriptionField => _driver.FindElement(By.Name("request[description]"));
        public IWebElement RegionDropdown => _driver.FindElement(By.Id("")); //need to figure out the region dropdown
        public IWebElement VerifyHumanCheckbox => _driver.FindElement(By.CssSelector("[class='recaptcha-checkbox-checkmark']"));
        public IWebElement SubmitTicketButton => _driver.FindElement(By.Id("ticket-form-button"));
    }
}