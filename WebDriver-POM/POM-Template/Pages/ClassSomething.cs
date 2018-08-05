namespace POM_Template.Pages
{
    using FluentAssertions;
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    public partial class ClassSomething : BasePage

    {
        public ClassSomething(IWebDriver driver) : base(driver)
        {
            //
        }

        public void ClickNGo()
        {
            //Act
            ToolTip.Click();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(@"//*[@id=""age""]")));
            Actions action = new Actions(Driver);
            string titleText = element.GetAttribute("title");
            action.MoveToElement(AgeTip).Perform();
            
            Thread.Sleep(2000);

            //Assert
            string tabTitle = Driver.Title;
            tabTitle.Should().Be("Tooltip | Demoqa");
            titleText.Should().Be("We ask for your age only for statistical purposes.");

           
        }
    }
}
