using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STAF.Core.Finders
{
    public class CustomFinders : By
    {
        public static By ByText(string text)
        {
            return XPath($"//*[text()='{text}']");
        }
    }
}
