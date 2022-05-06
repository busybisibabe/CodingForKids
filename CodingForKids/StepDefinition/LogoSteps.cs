using CodingForKids.PageObject;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CodingForKids.StepDefinition
{
    [Binding]
    public class LogoSteps
    {
        //Declare your PageObject and Instantiate it
        LandingPage landingPage = new LandingPage();

        [Given(@"the user navigate ""(.*)""")]
        public void GivenTheUserNavigate(string url)
        {
            landingPage.NavigateToWebsite(url);
        } 
        
        [When(@"the user is on the landing page")]
        public void WhenTheUserIsOnTheLandingPage()
        {
            landingPage.IsUserOnTheLandingPage().Should().BeTrue();
        }
        
        [Then(@"the coding for kids by kids logo should be visible on the left side of the header")]
        public void ThenTheCodingForKidsByKidsLogoShouldBeVisibleOnTheLeftSideOfTheHeader()
        {
            landingPage.IsTheLogoVisibleOnTheLeftSideOfTheHeader().Should().BeTrue();
        }
    }
}
