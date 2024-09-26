using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OrangeHRMStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;
        public OrangeHRMStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }

        [Given(@"User is on orange hrm login page")]
        public void GivenUserIsOnOrangeHrmLoginPage()
        {
           
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersTheAnd(string username, string password)
        {
            IWebElement username1 = _driver.FindElement(By.XPath("//input[@placeholder='Username']"));
            username1.SendKeys(username);
            IWebElement pass = _driver.FindElement(By.XPath("//input[@name='password']"));
            pass.SendKeys(password);
        }

        [When(@"User clicks submit button")]
        public void WhenUserClicksSubmitButton()
        {
            _driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            Thread.Sleep(1000);
        }

        [Then(@"User is navigated to the home page")]
        public void ThenUserIsNavigatedToTheHomePage()
        {
            _driver.FindElement(By.XPath("//a[normalize-space()='']")).Click();
            Thread.Sleep(2000);
            _driver.Close();
        }
        [Then(@"User is displayed with error message")]
        public void ThenUserIsDisplayedWithErrorMessage()
        {
            Thread.Sleep(2000);
            IWebElement error = _driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']"));
            Console.WriteLine(error);
            Assert.That(error.Text, Is.EqualTo("Invalid credentials"));
            _driver.Close();
        }

    }
}
