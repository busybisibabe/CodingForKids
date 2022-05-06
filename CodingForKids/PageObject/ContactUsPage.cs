using CodingForKids.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CodingForKids.PageObject
{
    public class ContactUsPage
    {
        //Declare IWebDriver
        public IWebDriver driver;

        //Create a constructor and assign your WebHooks to the driver
        public ContactUsPage()
        {
            driver = WebHooks.driver;
        }

        private IWebElement fullNameField => driver.FindElement(By.XPath("//input[@name='full-name']"));
        private IWebElement emailField => driver.FindElement(By.XPath("//input[@name='email']"));
        private IWebElement phoneNumberField => driver.FindElement(By.XPath("//input[@name='phone']"));
        private IWebElement ageField => driver.FindElement(By.XPath("//input[@name='your-age']"));
        private IWebElement messageField => driver.FindElement(By.XPath("//textarea[@name='message']"));
        private IWebElement checkBoxField => driver.FindElement(By.XPath("//*[@id='recaptcha - anchor']/div[1]"));
        private IWebElement submitButton => driver.FindElement(By.XPath("//input[@value='Submit']"));
        public void NavigateToContactUsPage(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }
        public void EnterFullName(string fullname)
        {
            fullNameField.SendKeys(fullname);
        }

        public void EnterEmail(string email)
        {
            emailField.SendKeys(email);
        }

        public void EnterPhoneNumber(decimal PhoneNumber)
        {
            phoneNumberField.SendKeys("07982899229");
        }
        public void EnterAge(int age)
        {
            ageField.SendKeys("39");
        }

        public void EnterMessage(string message)
        {
            messageField.SendKeys(message);
        }

         public void ClickCheckBox()
        {

            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           
        }
        public void ClickSubmitButton()
        {
            submitButton.Click();
        }

       // public void (type the message after submission here)
       // {
            
       // }



        public void EnterInvalidEmail(string email)
        {
            emailField.SendKeys(email);
        }
    }
}
