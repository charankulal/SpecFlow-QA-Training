using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    internal class Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [BeforeScenario]
        public void Setup()
        {

            Console.WriteLine("Running before every scenario");
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver driver = new ChromeDriver();
            _scenarioContext["WebDriver"] = driver;
        }
        [AfterScenario]
        public void TearDown()
        {

            Console.WriteLine("Running after every scenario");
            var driver = _scenarioContext["WebDriver"] as IWebDriver;
            driver?.Quit();

        }

        

        [BeforeTestRun]
        public static void beforetest()
        {
            TestContext.Progress.WriteLine("Running before testcaserun");
        }

        [AfterTestRun]
        public static void aftertest()
        {
            TestContext.Progress.WriteLine("Running after testcaserun");
        }


        [BeforeStep]
        public static void beforestep()
        {
            Console.WriteLine("Running before step");
        }

        [AfterStep]
        public static void afterstep()
        {
            Console.WriteLine("Running after step");
        }
    }
}
