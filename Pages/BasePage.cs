using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation.Pages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        public void NavigateTo(string url)  
        {
            if(url.Contains(" "))
            {
                url.Replace(" ", "-");
            }
            Driver.Url = url;
        }


    }
}
