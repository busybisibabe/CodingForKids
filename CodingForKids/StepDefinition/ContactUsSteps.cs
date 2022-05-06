using CodingForKids.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CodingForKids.StepDefinition
{
    [Binding]
    public class ContactUsSteps
    {
        ContactUsPage contactUsPage = new ContactUsPage();

        [Given(@"user navigate to ""(.*)""")]
        public void GivenUserNavigateTo(string url)
        {
            contactUsPage.NavigateToContactUsPage(url);
        }

        [When(@"the user enters valid full name '(.*)'")]
        public void WhenTheUserEntersValidFullName(string fullname)
        {
            contactUsPage.EnterFullName(fullname);
        }

        [When(@"the user enters valid email '(.*)'")]
        public void WhenTheUserEntersValidEmail(string email)
        {
            contactUsPage.EnterEmail(email);
        }

        [When(@"the user enter valid phone number '(.*)'")]
        public void WhenTheUserEnterValidPhoneNumber(decimal phoneNumber)
        {
            contactUsPage.EnterPhoneNumber(07016767740);
        }

        [When(@"user enters valid age  '(.*)'")]
        public void WhenUserEntersValidAge(int age)
        {
            contactUsPage.EnterAge(39);
        }
        [When(@"the user enter a valid message in the '(.*)'")]
        public void WhenTheUserEnterAValidMessageInThe(string message)
        {
            contactUsPage.EnterMessage(message);
        }

        [When(@"the user check the captcha box")]
        public void WhenTheUserCheckTheCaptchaBox()
        {
            contactUsPage.ClickCheckBox();
        }
        
        [When(@"the user clicks on the submit button")]
        public void WhenTheUserClicksOnTheSubmitButton()
        {
            contactUsPage.ClickSubmitButton();
        }

        
        //[Then(@"Submission is successful is displayed")]
        public void ThenSubmissionIsSuccessfulIsDisplayed()
        {
            //Assert.IsTrue(contactUsPage.ThenSubmissionIsSuccessfulIsDisplayed());
        }


        [When(@"the user enters invalid email '(.*)'")]
        public void WhenTheUserEntersInvalidEmail(string email)
        {
            contactUsPage.EnterInvalidEmail(email);
        }

       // [Then(@"form should not be submitted ""(.*)"" should be displayed")]
       // public void ThenFormShouldNotBeSubmittedShouldBeDisplayed(string p0)
        //{
         // FluentAssertions.IsTrue(contactUsPage.)  
        }

    }

