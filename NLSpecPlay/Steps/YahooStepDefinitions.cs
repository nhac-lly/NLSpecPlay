using System;
using NLSpecPlay.Drivers;
using FluentAssertions;
using NLSpecPlay.PageObjects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NLSpecPlay.Steps
{
    [Binding]
    public class YahooVNStepDefinitions
    {
        private readonly YahooPageObject _yahooPageObject;
        public YahooVNStepDefinitions(BrowserDriver browserDriver)
        {
            _yahooPageObject = new YahooPageObject(browserDriver.Current);
        }

        [When(@"user check the web")]
        public void WhenUserCheckTheWeb()
        {
            Console.WriteLine("Checking page");
        }
        [Then(@"the title should be (.*)")]
        public void ThenTheTitleShouldBe(string p0)
        {
            p0.Should().Be(_yahooPageObject.GetText(_yahooPageObject.FirstSpan));
        }

        [Then(@"the img url should be (.*)")]
        public void ThenTheImgUrlShouldBe(string p0)
        {
            p0.Should().Be(_yahooPageObject.FirstImgUrl.GetAttribute("src"));
        }
    }
}
