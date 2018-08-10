using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoQA_testsForExam.Pages
{
    public partial class Slider : BasePage
    {
        public Slider(IWebDriver driver) : base(driver)
        {

        }

        public void MoveHandleTo5AndAssert()
        {
            SliderTab.Click();
            for (int i = 0; i < 3; i++)
            {
                MoveThis.Click();
                MoveThisRight(MoveThis);
                Thread.Sleep(1000);
            }

            string getAttributeOfMoveThis = MoveThis.GetAttribute("style");

            Assert.AreEqual("left: 44.4444%;", getAttributeOfMoveThis);


        }
    }
}
