namespace POM_Template.Pages
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public partial class ClassSomething
    {
        //Arrange
        public IWebElement ToolTip => Driver.FindElement(By.Id("menu-item-99"));
        public IWebElement AgeTip => Driver.FindElement(By.XPath(@"//*[@id=""age""]"));
        //
       
    }
}
