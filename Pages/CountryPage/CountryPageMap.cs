using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation.Pages.CountryPage
{
    public partial class CountryPage
    {
        public IWebElement Name => Driver.FindElement(By.XPath(@"//*[@id=""content""]/dl[1]/dd[2]"));
        public IWebElement Capital => Driver.FindElement(By.XPath(@"//*[@id=""content""]/dl[1]/dd[3]"));
        public IWebElement Code => Driver.FindElement(By.XPath(@"//*[@id=""content""]/dl[1]/dd[10]/em"));

        public IWebElement Map => Driver.FindElement(By.XPath(@"//*[@id=""map""]/div[1]/div[1]/div/div[2]/img[4]"));


       
    }
}
