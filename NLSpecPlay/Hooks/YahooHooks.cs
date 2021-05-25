using NLSpecPlay.Drivers;
using NLSpecPlay.PageObjects;
using TechTalk.SpecFlow;

namespace NLSpecPlay.Hooks
{
    [Binding]
    public class YahooHooks
    {
        [BeforeScenario("Yahoo")]
        public static void BeforeScenario(BrowserDriver browserDriver)
        {
            var calculatorPageObject = new YahooPageObject(browserDriver.Current);
            calculatorPageObject.OpenPage();
        }
    }
}