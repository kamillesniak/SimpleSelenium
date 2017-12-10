using System;
using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium;
using STAF.Core.Initalize;

namespace STAF.Core.Controls
{
    public class WebControl : IWebControl
    {
        protected IWebElement WebElement;
        public WebControl(IWebElement element)
        {
            WebElement = element;
        }
       
    }
}
