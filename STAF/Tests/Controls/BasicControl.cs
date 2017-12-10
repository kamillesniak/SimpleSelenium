using STAF.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Tests.Controls
{
    public class BasicControl : IWebControl
    {
        public IWebElement element { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
