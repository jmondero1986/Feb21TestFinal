using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feb21Testing.Utilities
{
    class CommonDriver
    {

        //intiate and define web driver

        public static IWebDriver driver = new ChromeDriver(@"D:\");
    }
}
