using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using STAF.Core.Controls;
using STAF.Core.Initalize;

namespace Tests
{
    public class TestTEst
    {
        private void ThisIsTest()
        {
            var driver = new FirefoxDriver();
            var seleniumdriver = new SeleniumDriver(driver);
            var element = new Button(driver.FindElement(By.XPath("")));
            

            var dupcia = seleniumdriver.FindControl(By.XPath("dupa"));
            driver.FindElement(By.XPath(""));
            seleniumdriver.FindControl(By.XPath("BLABLBA"));
        }
        private void Mybutton(WebControl przycisk)
        {

        }
    }
}
