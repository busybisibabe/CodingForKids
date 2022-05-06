using CodingForKids.PageObject;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CodingForKids.StepDefinition
{
    [Binding]
    public class AboutUsSteps
    {
        //Declare your PageObject and Instantiate it
       LandingPage landingPage = new LandingPage();

        [When(@"the user clicks on the About Us link on the footer")]
        public void WhenTheUserClicksOnTheAboutUsLinkOnTheFooter()
        {
            landingPage.ClickAboutUs();
            landingPage.IsTheUserOnTheLandingPage();
            
        }
        
        [Then(@"the user should be redirected to the about us page")]
        public void ThenTheUserShouldBeRedirectedToTheAboutUsPage()
        {
            landingPage.IsTheUserRedirectedToTheAboutUsPage().Should().BeTrue();
            landingPage.IsTheUserOnTheLandingPage().Should().BeTrue();
            
        }
       
    }
}
