using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Fundamentals_HW
{
    class Selenium_Fund_HW
    {
        IWebDriver _driver;
        [Test]
        public void GoogleSearchSelenium()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _driver.Url = "http://www.google.com";

            IWebElement searchBox = _driver.FindElement(By.Id("lst-ib"));
            searchBox.Clear();
            searchBox.SendKeys("Selenium");
            searchBox.SendKeys(Keys.Enter);

            
            IWebElement clickHere = _driver.FindElement(By.LinkText("Selenium - Web Browser Automation"));
          
            clickHere.Click();

            Assert.AreEqual("Selenium - Web Browser Automation", _driver.Title);


        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
