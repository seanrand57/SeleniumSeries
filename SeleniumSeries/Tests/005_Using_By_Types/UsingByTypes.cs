using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Shouldly;

namespace SeleniumSeries.Tests._005_Using_By_Types
{
    [TestClass]
    public class UsingByTypes
    {
        [TestCategory("CHAPTER-2")]
        [TestCategory("WEB")]
        [TestMethod]
        public void ById_FindingTheSearchTextBox_And_Searching()
        {
            // Arrange
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
         //   driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

            //Act - Clicking the Search Box, entering text and searching
            var searchBox = driver.FindElement(By.Id("q"));
            var searchButton = driver.FindElement(By.Id("submit"));

            // Send Text to the Search box and press the Search Button "Go"
            // more to come on Sending Keys and Click / Actions in a later Chapter ;-)
            searchBox.SendKeys("Selenium Find Elements");
            searchButton.Click();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(drv => drv.Url.Contains("google.com"));

            //Assert
            driver.Title.ShouldNotBeEmpty();
            driver.Title.ShouldBe("Google Custom Search");

            // clean up
            driver.Quit();
        }

        [TestCategory("CHAPTER-2")]
        [TestCategory("WEB")]
        [TestMethod]
        public void FindingTheMenuItems_And_NavigatingTheSite_ByIds()
        {
            // Arrange
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
         //   driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

            //Act - find all the Menu items By Id, and then click each menu item.
            // we'll end up on the About Page as its the final action.
            // note that we find the element and click it, navigate to the next page and do the same.  We need to do it this
            // way due to the way the DOM is refreshed.  
            var projectMenuItem = driver.FindElement(By.Id("menu_projects"));
            projectMenuItem.Click();

            var downloadMenuItem = driver.FindElement(By.Id("menu_download"));
            downloadMenuItem.Click();

            var documentationMenuItem = driver.FindElement(By.Id("menu_documentation"));
            documentationMenuItem.Click();

            var supportMenuItem = driver.FindElement(By.Id("menu_support"));
            supportMenuItem.Click();

            var aboutMenuItem = driver.FindElement(By.Id("menu_about"));
            aboutMenuItem.Click();

            //Assert
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(drv => drv.Title.Contains("About"));
            driver.Url.ShouldBe("http://www.seleniumhq.org/about/");

            // clean up
            driver.Quit();
        }

        [TestCategory("CHAPTER-2")]
        [TestCategory("WEB")]
        [TestMethod]
        public void FindingTheMenuItems_And_NavigatingUsingClickExtensions()
        {
            // Arrange
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
          //  driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

            //Act  
            driver.FindElement(By.Id("menu_projects")).Click();
            driver.FindElement(By.Id("menu_download")).Click();
            driver.FindElement(By.Id("menu_documentation")).Click();
            driver.FindElement(By.Id("menu_support")).Click();
            driver.FindElement(By.Id("menu_about")).Click();


            //Assert
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(drv => drv.Title.Contains("About"));
            driver.Url.ShouldBe("http://www.seleniumhq.org/about/");

            // clean up
            driver.Quit();
        }

        [TestCategory("CHAPTER-2")]
        [TestCategory("WEB")]
        [TestMethod]
        public void FindingTheMenuItems_By_New_ExtensionMethnds()
        {
            // Arrange
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
           // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

            //Act  
            driver.FindElementById("menu_projects").Click();
            driver.FindElementById("menu_download").Click();
            driver.FindElementById("menu_documentation").Click();
            driver.FindElementById("menu_support").Click();
            driver.FindElementById("menu_about").Click();

            //Assert
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(drv => drv.Title.Contains("About"));
            driver.Url.ShouldBe("http://www.seleniumhq.org/about/");

            // clean up
            driver.Quit();
        }


        //[TestCategory("CHAPTER-2")]
        //[TestCategory("WEB")]
        //[TestMethod]
        //public void FindingTheAboutMenuItem_And_NavigatingToThePage_ByLinkText()
        //{
        //    // Arrange
        //    var driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        //    driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

        //    //Act - find the Menu Item By Link Text and click
        //    var aboutMenuItem = driver.FindElement(By.LinkText("About"));
        //    aboutMenuItem.Click();

        //    //Assert
        //    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        //    wait.Until(drv => drv.Title.Contains("About"));
        //    driver.Url.ShouldBe("http://www.seleniumhq.org/about/");

        //    // clean up
        //    driver.Quit();
        //}

        //[TestCategory("CHAPTER-2")]
        //[TestCategory("WEB")]
        //[TestMethod]
        //public void FindingTheAboutMenuItem_And_NavigatingToThePage_ByPartialLinkText()
        //{
        //    // Arrange
        //    var driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        //    driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

        //    //Act - find the Menu Item By Partial Link Text and click
        //    var aboutMenuItem = driver.FindElement(By.PartialLinkText("Abo"));
        //    aboutMenuItem.Click();

        //    //Assert
        //    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        //    wait.Until(drv => drv.Title.Contains("About"));
        //    driver.Url.ShouldBe("http://www.seleniumhq.org/about/");

        //    // clean up
        //    driver.Quit();
        //}

        //[TestCategory("CHAPTER-2")]
        //[TestCategory("WEB")]
        //[TestMethod]
        //public void FindingTheAboutMenuItem_And_NavigatingToThePage_ByTag()
        //{
        //    // Arrange
        //    var driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        //    driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

        //    //Act - Find Elements.... find the Menu Item By Partial Link Text and click
        //    var links = driver.FindElements(By.TagName("a"));

        //    // Find the link text which is About and click it
        //    foreach (var link in links)
        //        if (link.Text.Equals("About"))
        //        {
        //            link.Click();
        //            break;
        //        }

        //    //Assert
        //    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        //    wait.Until(drv => drv.Title.Contains("About"));
        //    driver.Url.ShouldBe("http://www.seleniumhq.org/about/");

        //    // clean up
        //    driver.Quit();
        //}

        //[TestCategory("CHAPTER-2")]
        //[TestCategory("WEB")]
        //[TestMethod]
        //public void FindingTheAboutMenuItem_And_NavigatingToThePage_ByCss()
        //{
        //    // Arrange
        //    var driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        //    driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

        //    //Act
        //    var menuItem = driver.FindElement(By.CssSelector("li#menu_about"));
        //    menuItem.Click();

        //    //Assert
        //    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        //    wait.Until(drv => drv.Title.Contains("About"));
        //    driver.Url.ShouldBe("http://www.seleniumhq.org/about/");

        //    // clean up
        //    driver.Quit();
        //}

        //[TestCategory("CHAPTER-2")]
        //[TestCategory("WEB")]
        //[TestMethod]
        //public void FindingThe_SeleniumIcon_ByClassName()
        //{
        //    // Arrange
        //    var driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        //    driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

        //    //Act
        //    var icon = driver.FindElement(By.ClassName("icon"));
        //    icon.Click();

        //    //Assert
        //    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        //    wait.Until(drv => drv.Url.Contains("projects/webdriver/"));
        //    driver.Url.ShouldBe("http://www.seleniumhq.org/projects/webdriver/");

        //    // clean up
        //    driver.Quit();
        //}

        //[TestCategory("CHAPTER-2")]
        //[TestCategory("WEB")]
        //[TestMethod]
        //public void FindingThe_SearchBox_ByName_And_Searching()
        //{
        //    // Arrange
        //    var driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        //    driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

        //    //Act
        //    var searchbox = driver.FindElement(By.Name("q"));
        //    searchbox.SendKeys("Testing");
        //    driver.FindElement(By.Id("submit")).Click();

        //    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        //    wait.Until(drv => drv.Url.Contains("google"));

        //    //Assert
        //    driver.Title.ShouldContain("Custom Search");

        //    // clean up
        //    driver.Quit();
        //}

        //[TestCategory("CHAPTER-2")]
        //[TestCategory("WEB")]
        //[TestMethod]
        //public void FindingTheAboutMenuItem_And_NavigatingToThePage_ByXPath()
        //{
        //    // Arrange
        //    var driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        //    driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

        //    //Act
        //    var menuItem = driver.FindElement(By.XPath("//li[@id='menu_about']"));
        //    menuItem.Click();

        //    //Assert
        //    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        //    wait.Until(drv => drv.Title.Contains("About"));
        //    driver.Url.ShouldBe("http://www.seleniumhq.org/about/");

        //    // clean up
        //    driver.Quit();
        //}



        //[TestCategory("CHAPTER-2")]
        //[TestCategory("WEB")]
        //[TestMethod]
        //public void UsingFindElement()
        //{
        //    // Arrange
        //    var driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        //    driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

        //    //Act
        //    driver.FindElementById("menu_about").Click();

        //    //Assert
        //    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        //    wait.Until(drv => drv.Title.Contains("About"));
        //    driver.Url.ShouldBe("http://www.seleniumhq.org/about/");

        //    // clean up
        //    driver.Quit();
        //}

        //[TestCategory("CHAPTER-2")]
        //[TestCategory("WEB")]
        //[TestMethod]
        //public void UsingFindElements()
        //{
        //    // Arrange
        //    var driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        //    driver.Navigate().GoToUrl("http://www.seleniumhq.org/");

        //    //Act - finding all anchor tags denoted by "a" which are links on the site.
        //    var allLinks = driver.FindElementsByTagName("a");

        //    // Find the link text which is About and click it
        //    foreach (var link in allLinks)
        //        if (link.Text.Equals("About"))
        //        {
        //            link.Click();
        //            break;
        //        }

        //    //Assert
        //    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        //    wait.Until(drv => drv.Title.Contains("About"));
        //    driver.Url.ShouldBe("http://www.seleniumhq.org/about/");

        //    // clean up
        //    driver.Quit();
        //}
    }
}