using CodingForKids.PageObject;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CodingForKids.StepDefinition
{
    [Binding]
    public class ApplicationMenuSteps
    {
        //Declare your PageObject and Instantiate it
        LandingPage landingPage = new LandingPage();

        [Then(@"the coding for kids by kids Application menu should be visible and last on the rightside of the menu bar")]
        public void ThenTheCodingForKidsByKidsApplicationMenuShouldBeVisibleAndLastOnTheRightsideOfTheMenuBar()
        {
            landingPage.IsTheApplicationMenuVisibleAndLastOnTheRightsideOfTheMenuBar().Should().BeTrue();
        }
    }
}
