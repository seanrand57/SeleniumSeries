using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Shouldly;

namespace SeleniumSeries.Tests._004_Our_First_Selenium_Test
{
    [TestClass]
    public class OurFirstSeleniumTest
    {
        [TestCategory("WEB")]
        [TestCategory("FAST")]
        [TestCategory("CHAPTER-1")]
        [TestMethod]
        public void VisitTheSeleniumWebsite_CheckTheTitleIsPresent_AndMentionsSelenium()
        {
            // Arrange
            var driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            //Act
            driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

            //Assert
            driver.Title.ShouldNotBeEmpty();
            driver.Title.ShouldBe("Selenium - Web Browser Automation");

            // clean up
            driver.Quit();
        }

        [TestCategory("WEB")]
        [TestCategory("FAST")]
        [TestCategory("CHAPTER-1")]
        [TestMethod]
        public void VisitTheSeleniumWebsite_NavigateTheMenu_ToTheDocumentationPage()
        {
            // Arrange
            var driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(10));

            //Act
            driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

            var docMenu = driver.FindElement(By.Id("menu_documentation"));
            docMenu.Click();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(drv => drv.Title.Contains("Documentation"));

            //Assert
            driver.Url.ShouldBe("http://www.seleniumhq.org/docs/");
            driver.Title.ShouldContain("Selenium Documentation");

            // clean up
            driver.Quit();
        }
    }
}