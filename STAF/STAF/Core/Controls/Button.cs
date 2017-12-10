using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium.Remote;
using STAF.Core.Initalize;

namespace STAF.Core.Controls
{
    public interface IButton
    {
        bool Focus();
    }
    public class Button : WebControl, IButton
    {
        public Button(IWebElement element) : base(element)
        {

        }

        public bool Focus()
        {
            WebElement.Click();
            return true;
        }
    }
}
