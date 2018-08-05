namespace POM_Template
{
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using Pages;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;


    [TestFixture]
    public class TestsHere
    {
        private IWebDriver _driver;
        

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            //
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)

            {   var screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
                screenshot.SaveAsFile(Path.GetFullPath("../../Screenshots") + TestContext.CurrentContext.Test.Name +".png", ScreenshotImageFormat.Png);
                //_driver.Quit();
            }
            _driver.Quit();
        }

        [Test]
        public void ToolTipFirstTask()
        {
            var chrome = new ClassSomething(_driver);
            chrome.NavigateTo("http://demoqa.com/");
            chrome.ClickNGo();

        }
    }
}
