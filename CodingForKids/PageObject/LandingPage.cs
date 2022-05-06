using CodingForKids.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CodingForKids.PageObject
{
    public class LandingPage
    {
        //Declare IWebDriver
        public IWebDriver driver;

        //Create a constructor and assign your WebHooks to the driver
        public LandingPage()
        {
            driver = WebHooks.driver;
        }

        private By homeMenu = By.CssSelector("#menu-item-360 > a");
        private By logoItem = By.XPath("//img[@class='h-logo__alt-image h-logo__alt-image_h logo-alt-image style-862-image style-local-10-h5-image']");
        private By footer = By.XPath("//*[@id='footer']");
        private By applicationMenu = By.CssSelector("#menu-item-365 > a");
        private By coursesMenu = By.CssSelector("#menu-item-364");
        private By aboutUs = By.CssSelector("#menu-item-1099 > a");
        private By menuBar = By.XPath("//*[@id='navigation']/div/div[1]/div/div/div[3]/div");
        private By teaching = By.XPath("//h3[normalize-space()='Teaching Philosophy']");
        private By pictureSlide = By.XPath("//*[@id='overlappable - 2']");
        private By testimonial = By.XPath("//h3[normalize-space()='Testimonials and Awards']");


        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            
        }
        
        public bool IsUserOnTheLandingPage()
        {
            return driver.FindElement(homeMenu).Displayed;
        }

        public bool IsTheHomeMenuVisibleOnTheHeaderForTheUserToNavigate()
        {
            //This would only run under logo as it is under the logo
            //Thread.Sleep(5000);
            return driver.FindElement(homeMenu).Displayed;
        }

        public bool IsTheLogoVisibleOnTheLeftSideOfTheHeader()
        {
            return driver.FindElement(logoItem).Displayed;
        }
        public bool IsTheFooterVisibleToTheBottomOfThePage()
        {
            return driver.FindElement(footer).Displayed;
        }
        public bool IsTheApplicationMenuVisibleAndLastOnTheRightsideOfTheMenuBar()
        {
            return driver.FindElement(applicationMenu).Displayed;
        }
        public bool IsTheCoursesMenuVisibleAtTheMiddleOfTheMenuBar()
        {
            return driver.FindElement(coursesMenu).Displayed;
    
        }

       public void ClickAboutUs()
        {
            driver.FindElement(aboutUs).Click();
        }
        public bool IsTheUserRedirectedToTheAboutUsPage()
        {
            return driver.FindElement(aboutUs).Displayed;
        }
        public bool IsTheUserOnTheLandingPage()
        {
            //This is a way to ascertain that the url is correct
            return driver.Url == "https://user-68906616-work.colibriwp.com/coding-by-k/about-us/";
        }

        public bool IsTheMenuBarVisibleAndAlignedToTheRightOfTheHeader()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement menu = wait.Until(e => e.FindElement(menuBar));
            return driver.FindElement(menuBar).Displayed;
        }
    
        public bool IsThePictureSlideShowTeachingPhilosophyAndTestimonialAwardsOnTheMainBody()
        {
            return driver.FindElement(teaching).Displayed;
            

        }
    }
}
