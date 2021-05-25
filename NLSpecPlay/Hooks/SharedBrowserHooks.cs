﻿using BoDi;
using NLSpecPlay.Drivers;
using System;
using TechTalk.SpecFlow;

namespace NLSpecPlay.Hooks
{
    /// <summary>
    /// Share the same browser window for all scenarios
    /// </summary>
    /// <remarks>
    /// This makes the sequential execution of scenarios faster (opening a new browser window each time would take more time)
    /// As a tradeoff:
    ///  - we cannot run the tests in parallel
    ///  - we have to "reset" the state of the browser before each scenario
    /// </remarks>
    [Binding]
    public class SharedBrowserHooks
    {
        [BeforeFeature]
        public static void BrowserSelector(FeatureContext featureContext)
        {
            Environment.SetEnvironmentVariable("Browser", !featureContext.FeatureInfo.Description.Contains("Chrome") ? "Firefox" : "Chrome");
        }
        [BeforeTestRun]
        public static void BeforeTestRun(ObjectContainer testThreadContainer)
        {
            //Initialize a shared BrowserDriver in the global container
            testThreadContainer.BaseContainer.Resolve<BrowserDriver>();
        }
    }
}
