using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace DemoQA_Registration
{
    public class Resize
    {
        [Test]
        public void ResizeTest()
        {
            IWebDriver _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Url = "http://demoqa.com/resizable/";

            IWebElement resizeHandle = _driver.FindElement(By.ClassName("ui-resizable-handle"));
            IWebElement resizeWindowInfo = _driver.FindElement(By.Id("resizable"));

            string styleInfoBefore = resizeWindowInfo.GetAttribute("style");

            Actions action = new Actions(_driver);
            var action2 = action.MoveToElement(resizeHandle).ClickAndHold().MoveByOffset(200, 150).Release();
            action2.Perform();

            string styleInfoAfter = resizeWindowInfo.GetAttribute("style");

            Assert.AreNotEqual(styleInfoBefore, styleInfoAfter);
        }
    }
}
