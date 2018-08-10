using DemoQA_testsForExam.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoQA_testsForExam
{
    public class SliderTask
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)

            {
                var screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
                screenshot.SaveAsFile(Path.GetFullPath("../../Screenshots/") + TestContext.CurrentContext.Test.Name + ".png", ScreenshotImageFormat.Png);
                
            }
            _driver.Quit();
        }

        [Test]
        public void SliderTest()
        {
            var chrome = new Slider(_driver);
            chrome.NavigateTo("http://demoqa.com/");
            chrome.MoveHandleTo5AndAssert();

        }
    }
}
