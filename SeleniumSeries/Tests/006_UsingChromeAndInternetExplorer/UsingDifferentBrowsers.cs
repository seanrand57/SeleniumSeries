//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.IE;
//using OpenQA.Selenium.Support.UI;
//using Shouldly;

//namespace SeleniumSeries.Tests._006_UsingChromeAndInternetExplorer
//{
//    [TestClass]
//    public class UsingFindElementAndFindElements
//    {
//        [TestCategory("CHAPTER-3")]
//        [TestCategory("WEB")]
//        [TestMethod]
//        public void Firefox()
//        {
//            // Arrange
//            var driver = new FirefoxDriver();
//            driver.Manage().Window.Maximize();
//            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
//            driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

//            //Act  
//            driver.FindElement(By.Id("menu_projects")).Click();
//            driver.FindElement(By.Id("menu_download")).Click();
//            driver.FindElement(By.Id("menu_documentation")).Click();
//            driver.FindElement(By.Id("menu_support")).Click();
//            driver.FindElement(By.Id("menu_about")).Click();

//            //Assert
//            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
//            wait.Until(drv => drv.Title.Contains("About"));
//            driver.Url.ShouldBe("http://www.seleniumhq.org/about/");

//            // clean up
//            driver.Quit();
//        }

//        [TestCategory("CHAPTER-3")]
//        [TestCategory("WEB")]
//        [TestMethod]
//        public void Chrome()
//        {
//            // Arrange
//            var driver = new ChromeDriver();
//            driver.Manage().Window.Maximize();
//            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
//            driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

//            //Act  
//            driver.FindElement(By.Id("menu_projects")).Click();
//            driver.FindElement(By.Id("menu_download")).Click();
//            driver.FindElement(By.Id("menu_documentation")).Click();
//            driver.FindElement(By.Id("menu_support")).Click();
//            driver.FindElement(By.Id("menu_about")).Click();

//            //Assert
//            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
//            wait.Until(drv => drv.Title.Contains("About"));
//            driver.Url.ShouldBe("http://www.seleniumhq.org/about/");

//            // clean up
//            driver.Quit();
//        }

//        [TestCategory("CHAPTER-3")]
//        [TestCategory("WEB")]
//        [TestMethod]
//        public void InternetExplorer()
//        {
//            // Arrange
//            var driver = new InternetExplorerDriver();
//            driver.Manage().Window.Maximize();
//            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
//            driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

//            //Act
//            var projectMenuItem = driver.FindElement(By.Id("menu_projects"));
//            projectMenuItem.Click();

//            // clean up
//            driver.Quit();
//        }

//        [TestCategory("CHAPTER-3")]
//        [TestCategory("WEB")]
//        [TestMethod]
//        public void Edge()
//        {
//            // Arrange
//            var driver = new EdgeDriver();
//            driver.Manage().Window.Maximize();
//            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
//            driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

//            //Act  
//            driver.FindElement(By.Id("menu_projects")).Click();
//            driver.FindElement(By.Id("menu_download")).Click();
//            driver.FindElement(By.Id("menu_documentation")).Click();
//            driver.FindElement(By.Id("menu_support")).Click();
//            driver.FindElement(By.Id("menu_about")).Click();

//            //Assert
//            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
//            wait.Until(drv => drv.Title.Contains("About"));
//            driver.Url.ShouldBe("http://www.seleniumhq.org/about/");

//            // clean up
//            driver.Quit();
//        }
//    }
//}