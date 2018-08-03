using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation.Pages.IndexPage
{
    public partial class IndexPage
    {
        public List<IWebElement> CountryNames => Driver.FindElements(By.ClassName("td-country")).ToList();
    }
}
