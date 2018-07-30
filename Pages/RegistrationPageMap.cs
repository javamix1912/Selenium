using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQA_Registration;
using Register_DemoQA;
using OpenQA.Selenium.Support.UI;

namespace DemoQA_Registration.Pages
{
    public partial class RegistrationPage
    {
        public IWebElement FirstName => _driver.FindElement(By.Id("name_3_firstname"));
        public IWebElement LastName => _driver.FindElement(By.Id("name_3_lastname"));
        public List<IWebElement> Status => _driver.FindElements(By.Name("radio_4[]")).ToList();
        public List<IWebElement> Hobby => _driver.FindElements(By.Name("checkbox_5[]")).ToList();

        public SelectElement Country => new SelectElement(_driver.FindElement(By.Id("dropdown_7")));
        public SelectElement Month => new SelectElement(_driver.FindElement(By.Id("mm_date_8")));
        public SelectElement Day => new SelectElement(_driver.FindElement(By.Id("dd_date_8")));
        public SelectElement Year => new SelectElement(_driver.FindElement(By.Id("yy_date_8")));

        public IWebElement Phone => _driver.FindElement(By.Id("phone_9"));
        public IWebElement UserName => _driver.FindElement(By.Id("username"));
        public IWebElement Email => _driver.FindElement(By.Id("email_1"));
        public IWebElement Description => _driver.FindElement(By.Id("description"));

        public IWebElement Password => _driver.FindElement(By.Id("password_2"));

        public IWebElement PasswordConfirm => _driver.FindElement(By.Id("confirm_password_password_2"));

        public IWebElement PasswordMeter => _driver.FindElement(By.Id("password_meter"));

        public IWebElement RegisterMeButton => _driver.FindElement(By.Name("pie_submit"));

        public IWebElement IsRegistrationSuccessfull => _driver.FindElement(By.ClassName("piereg_message"));
    }
}
