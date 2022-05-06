﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CodingForKids.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("ContactUs", Description="\tAs a user on this URL https://user-68906616-work.colibriwp.com/coding-by-k/\r\n\tI " +
        "want the Contact us link to be visible on the footer  \r\n\tSo I can click on it an" +
        "d it takes me to the contact us page", SourceFile="Features\\ContactUs.feature", SourceLine=0)]
    public partial class ContactUsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ContactUs.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "ContactUs", "\tAs a user on this URL https://user-68906616-work.colibriwp.com/coding-by-k/\r\n\tI " +
                    "want the Contact us link to be visible on the footer  \r\n\tSo I can click on it an" +
                    "d it takes me to the contact us page", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void VerifyUserEnterValidDetailsOnTheContactUSPage(string fullname, string email, string phoneNumber, string age, string messageBox, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "109"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("fullname", fullname);
            argumentsOfScenario.Add("email", email);
            argumentsOfScenario.Add("phoneNumber", phoneNumber);
            argumentsOfScenario.Add("age", age);
            argumentsOfScenario.Add("message box", messageBox);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify user enter valid details on the Contact US page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
 testRunner.Given("user navigate to \"https://user-68906616-work.colibriwp.com/coding-by-k/contact-us" +
                        "-1/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.When(string.Format("the user enters valid full name \'{0}\'", fullname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.And(string.Format("the user enters valid email \'{0}\'", email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And(string.Format("the user enter valid phone number \'{0}\'", phoneNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And(string.Format("user enters valid age  \'{0}\'", age), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And(string.Format("the user enter a valid message in the \'{0}\'", messageBox), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("the user check the captcha box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("the user clicks on the submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.Then("Submission is successful is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify user enter valid details on the Contact US page, Oyebisi Oyekan", new string[] {
                "109"}, SourceLine=19)]
        public virtual void VerifyUserEnterValidDetailsOnTheContactUSPage_OyebisiOyekan()
        {
#line 7
this.VerifyUserEnterValidDetailsOnTheContactUSPage("Oyebisi Oyekan", "allaboutu@email.com", "07016767740", "39", "I an new to Coding for kids", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify user enter valid details on the Contact US page, Godwin Osabutey", new string[] {
                "109"}, SourceLine=19)]
        public virtual void VerifyUserEnterValidDetailsOnTheContactUSPage_GodwinOsabutey()
        {
#line 7
this.VerifyUserEnterValidDetailsOnTheContactUSPage("Godwin Osabutey", "whateveryoulike@gmail.com", "07712012281", "120", "I am a coding guru", ((string[])(null)));
#line hidden
        }
        
        public virtual void VerifyUserEnterInvalidDetailsOnTheContactUSPage(string fullname, string email, string phoneNumber, string age, string messageBox, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("fullname", fullname);
            argumentsOfScenario.Add("email", email);
            argumentsOfScenario.Add("phoneNumber", phoneNumber);
            argumentsOfScenario.Add("age", age);
            argumentsOfScenario.Add("message box", messageBox);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify user enter Invalid details on the Contact US page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 25
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 26
 testRunner.Given("user navigate to \"https://user-68906616-work.colibriwp.com/coding-by-k/contact-us" +
                        "-1/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 27
 testRunner.When(string.Format("the user enters valid full name \'{0}\'", fullname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.And(string.Format("the user enters invalid email \'{0}\'", email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And(string.Format("the user enter valid phone number \'{0}\'", phoneNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And(string.Format("user enters valid age  \'{0}\'", age), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And(string.Format("the user enter a valid message in the \'{0}\'", messageBox), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And("the user check the captcha box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And("the user clicks on the submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.Then("form should not be submitted \"One or more fields have an error. Please check and " +
                        "try again\" should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify user enter Invalid details on the Contact US page, Mary Kay", SourceLine=37)]
        public virtual void VerifyUserEnterInvalidDetailsOnTheContactUSPage_MaryKay()
        {
#line 25
 this.VerifyUserEnterInvalidDetailsOnTheContactUSPage("Mary Kay", "itisuemail.com", "07016767780", "22", "When the going gets tough, only the tough gets going", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
