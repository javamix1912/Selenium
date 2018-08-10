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
    public class Selectable
    {
        [Test]
        public void Select()
        {
            IWebDriver _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Url = "http://demoqa.com/selectable/";

            IWebElement item7 = _driver.FindElement(By.Id("selectable"));
            IWebElement item77 = item7.FindElement(By.XPath(@"//*[@id=""selectable""]/li[7]"));
            string getClassItem7Before = item77.GetAttribute("class");
            item77.Click();


            string getClassItem7After = item7.GetAttribute("class");
            Assert.AreNotEqual(getClassItem7Before, getClassItem7After);
        }
    }
}
