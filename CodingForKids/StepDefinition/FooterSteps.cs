using CodingForKids.PageObject;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CodingForKids.StepDefinition
{
    [Binding]
    public class FooterSteps
    {
        //Declare your PageObject and Instantiate it
        LandingPage landingPage = new LandingPage();

        [Then(@"the footer should be visible to the bottom of the page")]
        public void ThenTheFooterShouldBeVisibleToTheBottomOfThePage()
        {
         landingPage.IsTheFooterVisibleToTheBottomOfThePage().Should().BeTrue();
        }
    }
}
