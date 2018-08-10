using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_testsForExam.Pages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver{ get; }

        public void NavigateTo(string url)
        {
            this.Driver.Url = url;
        }

        public void MoveThisRight(IWebElement el)
        {
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.ArrowRight).Perform();
        }
    }
}
