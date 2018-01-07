using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using STAF.Core.Controls;
using Xunit;

namespace Tests
{
    public class TestTEst
    {
        private string _pageUrl = "http://www.leafground.com/";
        [Fact]
        private void ThisIsTest()
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(_pageUrl);
           var menu = new Menu(driver.FindElement(By.CssSelector("ul[class='wp-categories-list']")));
        }
        private void Mybutton(WebControl przycisk)
        {

        }
    }

}
