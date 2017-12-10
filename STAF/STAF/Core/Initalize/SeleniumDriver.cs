using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using STAF.Core.Controls;
using System;
using System.Linq;
using System.Threading;

namespace STAF.Core.Initalize
{
    public class SeleniumDriver 
    {
        private IWebDriver driver;
        public SeleniumDriver(IWebDriver driver)
        {
            this.driver = driver;
        }
        /// <summary>
        /// Finding element safely
        /// </summary>
        /// <param name="by"></param>
        /// <param name="attempts">Count of reapets when occur exception</param>
        /// <returns></returns>
        public IWebElement FindControl(By by, int attempts = 2)
        {
            for (int i = 0; i < attempts; i++)
            {
                try
                {
                    var elements = driver.FindElements(by);
                    if (elements != null)
                        return elements.First();
                    Thread.Sleep(500);
                }
                catch (Exception ex)
                {
                    // log exception
                }
            }
            throw new NoSuchElementException($"Unable to find element by : {by.ToString()}");
        }
     
    }
    public static class ExtensionTest
    {
        public static void SendKeys(this IWebElement element, string value)
        {
            if (clearFirst)
            {
                element.Clear();
            }
            element.SendKeys(value);
        }
    }
}
