﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace CodingForKids.Hooks
{
    [Binding]
    public class WebHooks
    {
        //Declare your IWebDriver
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            //Initialise and Instantiate your driver
            //driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //Quitting your ChromeDriver
            //driver.Quit();
        }
    }
}
