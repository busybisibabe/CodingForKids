using CodingForKids.PageObject;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CodingForKids.StepDefinition
{
    [Binding]
    public class HomePageBodySteps
    {
        LandingPage landingPage = new LandingPage();

        [Then(@"Picture Slide Show, Teaching Philosophy and Testimonial Awards should be on the main body")]
        public void ThenPictureSlideShowTeachingPhilosophyAndTestimonialAwardsShouldBeOnTheMainBody()
        {
            landingPage.IsThePictureSlideShowTeachingPhilosophyAndTestimonialAwardsOnTheMainBody().Should().BeTrue();
        }
    }
}
