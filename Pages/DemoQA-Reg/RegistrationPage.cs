using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_Registration.Pages
{
    public partial class RegistrationPage
    {
        private IWebDriver _driver;
        public RegistrationPage(IWebDriver driver)
        {
            this._driver = driver;
        }
        public string Url { get; set; }


        public void FillRegistrationForm()
        {
            Type(FirstName, "IvanIvanIvan");
            Type(LastName, "Family Ivan");
            Status[0].Click();
            Hobby[2].Click();
            Country.SelectByText("Bulgaria");
            Month.SelectByValue("12");
            Day.SelectByValue("25");
            Year.SelectByValue("1997");
            //Random number generator
            var charsNum = "1234567890";
            var numChars = new char[10];
            var randomNum = new Random();

            for (int i = 0; i < numChars.Length; i++)
            {
                numChars[i] = charsNum[randomNum.Next(charsNum.Length)];
            }

            var finalNumString = new String(numChars);
            Type(Phone, finalNumString);
            //End random number Generator

            //RANDOM USERNAME
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[10];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            Type(UserName, finalString);
            //End random username Generator



            //RANDOM EMAIL
            var chars2 = "ABCDEFGHIJKLMNabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars2 = new char[10];
            var randomEmail = new Random();

            for (int i = 0; i < stringChars2.Length; i++)
            {
                stringChars2[i] = chars2[randomEmail.Next(chars2.Length)];
            }

            var finalStringEmail = new String(stringChars2);
            Type(Email, finalStringEmail + "@gmail.com");
            //End random email Generator

            Type(Description, "This is Written By Selenium Webdriver and I am LHMDAI !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

            //RANDOM PASSWORD
            var chars3 = "ABCDLMNZXCabcdopqtuvwxyz0123456789!@#$%^&*";
            var stringChars3 = new char[16];
            var randomPass = new Random();

            for (int i = 0; i < stringChars3.Length; i++)
            {
                stringChars3[i] = chars3[randomPass.Next(chars3.Length)];
            }

            var finalStringPass = new String(stringChars3);
            Type(Password, finalStringPass);
            Type(PasswordConfirm, finalStringPass);

            WebDriverWait wait2 = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            wait2.Until(ExpectedConditions.ElementToBeClickable(RegisterMeButton));

            Assert.AreEqual("Strong", PasswordMeter.Text);
            RegisterMeButton.Click();

            Assert.AreEqual("Thank you for your registration", IsRegistrationSuccessfull.Text);
        }

        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }   
}
