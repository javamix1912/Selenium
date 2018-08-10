using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_testsForExam.Pages
{
    public partial class Slider
    {
        public IWebElement SliderTab => Driver.FindElement(By.Id("menu-item-97"));

        public IWebElement MoveThis => Driver.FindElement(By.XPath(@"//*[@id=""slider-range-max""]/span"));

        
    }
}
