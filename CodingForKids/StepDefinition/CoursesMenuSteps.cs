using CodingForKids.PageObject;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CodingForKids.StepDefinition
{
    [Binding]
    public class CoursesMenuSteps
    {
        //Declare your PageObject and Instantiate it
        LandingPage landingPage = new LandingPage();

        [Then(@"the coding for kids by kids courses menu is visible at the middle of the menu bar")]
        public void ThenTheCodingForKidsByKidsCoursesMenuIsVisibleAtTheMiddleOfTheMenuBar()
        {
            landingPage.IsTheCoursesMenuVisibleAtTheMiddleOfTheMenuBar().Should().BeTrue();  
        }
    }
}
