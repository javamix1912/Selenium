using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_Registration
{
    public class Draggable
    {
        [Test]
        public void Draggable2()
        {
            IWebDriver _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Navigate().GoToUrl("http://demoqa.com/draggable/");
            _driver.Manage().Window.Maximize();

            IWebElement target = _driver.FindElement(By.Id("draggable"));
            IWebElement moveTo = _driver.FindElement(By.ClassName("inside_contain"));

            string targetStyleBefore = target.GetAttribute("style");

            Actions builder = new Actions(_driver);
            builder.DragAndDrop(target, moveTo).Perform();
            string targetStyleAfter = target.GetAttribute("style");

            //Assert
            Assert.AreNotEqual(targetStyleBefore, targetStyleAfter);
        }
        [Test]
        public void DraggableFail2()
        {
            IWebDriver _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Navigate().GoToUrl("http://demoqa.com/draggable/");
            _driver.Manage().Window.Maximize();

            IWebElement target = _driver.FindElement(By.Id("draggable"));
            IWebElement moveTo = _driver.FindElement(By.ClassName("inside_contain"));

            string targetStyleBefore = target.GetAttribute("style");

            Actions builder = new Actions(_driver);
            builder.DragAndDropToOffset(target, 0,0).Perform();
            string targetStyleAfter = target.GetAttribute("style");

            //Assert
            Assert.AreEqual(targetStyleBefore, targetStyleAfter);
        }
    }
}
