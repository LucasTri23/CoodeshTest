using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace PriceMachine.Automation.Fixtures
{
    public class TestFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }

        // Setup
        public TestFixture()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}