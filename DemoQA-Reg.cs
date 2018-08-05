using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Register_DemoQA
{

    public class Class1
    {

        private IWebDriver _driver;

        [Test]
        public void Test()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://demoqa.com/registration/");
            //Arrange
            IWebElement firstName = _driver.FindElement(By.Id("name_3_firstname"));
            IWebElement lastName = _driver.FindElement(By.Id("name_3_lastname"));
            //radiobuttons
            List<IWebElement> status = _driver.FindElements(By.Name("radio_4[]")).ToList();
            List<IWebElement> hobby = _driver.FindElements(By.Name("checkbox_5[]")).ToList();


            SelectElement country = new SelectElement(_driver.FindElement(By.Id("dropdown_7")));
            SelectElement birthMonth = new SelectElement(_driver.FindElement(By.Id("mm_date_8")));
            SelectElement birthDay = new SelectElement(_driver.FindElement(By.Id("dd_date_8")));
            SelectElement birthYear = new SelectElement(_driver.FindElement(By.Id("yy_date_8")));
            IWebElement phone = _driver.FindElement(By.Id("phone_9"));
            IWebElement userName = _driver.FindElement(By.Id("username"));
            IWebElement email = _driver.FindElement(By.Id("email_1"));
            IWebElement description = _driver.FindElement(By.Id("description"));
            IWebElement pass = _driver.FindElement(By.Id("password_2"));
            IWebElement passAgain = _driver.FindElement(By.Id("confirm_password_password_2"));
            IWebElement passOK = _driver.FindElement(By.Id("password_meter"));
            IWebElement registerMeButton = _driver.FindElement(By.Name("pie_submit"));

            

            //RANDOM PHONENUMBER
            Random phoneNum = new Random();
            string number = "";

            for (int i = 1; i < 11; i++)
            {
                number += phoneNum.Next(0, 9).ToString();
            }

            //RANDOM USERNAME
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[10];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);


            //RANDOM EMAIL
            var chars2 = "ABCDEFGHIJKLMNabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars2 = new char[10];
            var randomEmail = new Random();

            for (int i = 0; i < stringChars2.Length; i++)
            {
                stringChars2[i] = chars2[randomEmail.Next(chars2.Length)];
            }

            var finalStringEmail = new String(stringChars2);


            //RANDOM PASSWORD
            var chars3 = "ABCDLMNZXCabcdopqtuvwxyz0123456789!@#$%^&*";
            var stringChars3 = new char[16];
            var randomPass = new Random();

            for (int i = 0; i < stringChars3.Length; i++)
            {
                stringChars3[i] = chars3[randomPass.Next(chars3.Length)];
            }

            var finalStringPass = new String(stringChars3);


            //Act
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(firstName));
            firstName.SendKeys("IvanIvanIvan");
            lastName.SendKeys("Family Ivan");
            WebDriverWait wait3 = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            wait3.Until(ExpectedConditions.ElementToBeClickable(status[0]));
            status[0].Click();
            hobby[2].Click();


            country.SelectByValue("Bulgaria");
            birthMonth.SelectByValue("10");
            birthDay.SelectByValue("11");
            birthYear.SelectByValue("1969");
            phone.SendKeys(number);
            userName.SendKeys(finalString);
            email.SendKeys(finalStringEmail + "@gmail.com");
            description.SendKeys("This is Written By Selenium Webdriver and I am LHMDAI !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            pass.SendKeys(finalStringPass);
            passAgain.SendKeys(finalStringPass);
            WebDriverWait wait2 = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            wait2.Until(ExpectedConditions.ElementToBeClickable(registerMeButton));
            Assert.AreEqual("Strong", passOK.Text);
            registerMeButton.Click();

            IWebElement regSuccessfull = _driver.FindElement(By.ClassName("piereg_message"));
            Assert.AreEqual("Thank you for your registration", regSuccessfull.Text);
           
            //Assert


            //Assert.AreEqual("StrongCHE", passOK.Text);  //with this test failed because expected text is 'Strong'
        }
    }
}
