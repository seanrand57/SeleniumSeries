using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;

namespace Part001___Navigating_to_URL
{
    [TestClass]
    public class Tests
    {
        public IWebDriver Driver;
        private const string Url = "http://the-internet.herokuapp.com/";

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Close();
        }

        [TestMethod]
        public void NavigateToSeleniumSite()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(Url);

            Driver.Url.ShouldBe(Url);
        }
    }
}
