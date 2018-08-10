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
    public class Interactions_DemoQA
    {
        [Test]
        public void Draggable()
        {
            IWebDriver _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            _driver.Url = "http://demoqa.com/droppable/";

            IWebElement draggable = _driver.FindElement(By.Id("draggableview"));
            IWebElement target = _driver.FindElement(By.Id("droppableview"));

            string classBefore = target.GetAttribute("class");

            Actions builder = new Actions(_driver);

            builder.DragAndDrop(draggable, target).Perform();

            string classAfter = target.GetAttribute("class");

            Assert.AreNotEqual(classBefore, classAfter);
        }
        [Test]

        public void DraggableFail()
        {
            IWebDriver _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
             _driver.Url = "http://demoqa.com/droppable/";

            IWebElement draggable = _driver.FindElement(By.Id("draggableview"));
            IWebElement target = _driver.FindElement(By.ClassName("inside_contain"));

            string classBefore = target.GetAttribute("class");
            Actions builder = new Actions(_driver);
            builder.DragAndDrop(draggable, target).Perform();
            string classAfter = target.GetAttribute("class");

            //Assert
            Assert.AreEqual(classBefore, classAfter);
        }
    }
}
