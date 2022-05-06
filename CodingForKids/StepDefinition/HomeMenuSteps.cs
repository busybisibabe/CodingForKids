using CodingForKids.PageObject;
using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace CodingForKids.StepDefinition
{
    [Binding]
    public class HomeMenuSteps
    {
        //Declare your PageObject and Instantiate it
        LandingPage landingPage = new LandingPage();

        [Then(@"the Home menu is visible on the header for the user to navigate")]
        public void ThenTheHomeMenuIsVisibleOnTheHeaderForTheUserToNavigate()
        {
            landingPage.IsTheHomeMenuVisibleOnTheHeaderForTheUserToNavigate().Should().BeTrue();  
        }
    }
}
