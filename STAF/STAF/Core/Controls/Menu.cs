using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace STAF.Core.Controls
{
    public class Menu : WebControl
    {
        private IReadOnlyCollection<IWebElement> Options
        {
            get
            {
                var optionFinder = By.TagName("li");
                return WebElement.FindElements(optionFinder);
            }
        }

        public Menu(IWebElement element) : base(element)
        {
        }

        public void SelectOption(string optionName)
        {
            var option = Options.Select(n=>n)
                .Where(x => x.GetAttribute("innerText") == optionName)
                .First();
            option.FindElement(By.TagName("a")).Click();
        }
     
    }
}
