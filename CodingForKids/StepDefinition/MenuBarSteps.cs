using CodingForKids.PageObject;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CodingForKids.StepDefinition
{
    [Binding]
    public class MenuBarSteps
    {
        LandingPage landingPage = new LandingPage();

        [Then(@"the Menu bar should be visible and aligned to the right of the header")]
        public void ThenTheMenuBarShouldBeVisibleAndAlignedToTheRightOfTheHeader()
        {
            landingPage.IsTheMenuBarVisibleAndAlignedToTheRightOfTheHeader().Should().BeTrue();
        }
    }
}
