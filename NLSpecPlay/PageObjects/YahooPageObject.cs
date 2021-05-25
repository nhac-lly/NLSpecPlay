using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NLSpecPlay.PageObjects
{
    /// <summary>
    /// Yahoo Page Object
    /// </summary>
    public class YahooPageObject
    {
        private const string YahooUrl = "https://vn.yahoo.com/";
        private readonly IWebDriver _webDriver;
        public const int DefaultWaitInSeconds = 5;
        public List<KeyValuePair<IWebElement, IWebElement>> ElList;

        public void OpenPage()
        {
            if (_webDriver.Url != YahooUrl)
            {
                _webDriver.Url = YahooUrl;
            }
            else
            {
                WaitForRender();
            }
        }
        public IWebElement FirstSpan => _webDriver.FindElement(By.XPath("//a[contains(@href, 'tung-don')]/span"));
        public IWebElement SecondSpan => _webDriver.FindElement(By.XPath("//a[contains(@href, 'ly-hon-vi-vo-vo')]/span"));
        public IWebElement ThirdSpan => _webDriver.FindElement(By.XPath("//a[contains(@href, 'dam-me')]/span"));
        public IWebElement FirstImgUrl => _webDriver.FindElement(By.XPath("//a[contains(@href, 'tung-don')]/img"));
        public IWebElement SecondImgUrl => _webDriver.FindElement(By.XPath("//a[contains(@href, 'ly-hon-vi-vo-vo')]/img"));
        public IWebElement ThridImgUrl => _webDriver.FindElement(By.XPath("//a[contains(@href, 'dam-me')]/img"));

        public YahooPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            //ElList.Add(new KeyValuePair<IWebElement, IWebElement>(FirstSpan, FirstImgUrl));
            //ElList.Add(new KeyValuePair<IWebElement, IWebElement>(SecondSpan, SecondSpan));
            //ElList.Add(new KeyValuePair<IWebElement, IWebElement>(ThirdSpan, ThridImgUrl));
        }

        public string WaitForRender()
        {
            return WaitUntil(
                () => ThridImgUrl.GetAttribute("class"), 
                result => !string.IsNullOrEmpty(result));
        }

        public string GetText(IWebElement el)
        {
            return el.Text;
        }

        private T WaitUntil<T>(Func<T> getResult, Func<T, bool> isResultAccepted) where T : class
        {
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(DefaultWaitInSeconds));
            Console.WriteLine("Wait");
            return wait.Until(driver =>
            {
                var result = getResult();
                if (!isResultAccepted(result))
                    return default;

                return result;
            });
        }
    }
}

