using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feb21Testing.Utilities
{
    class Wait
    {
        public static void IsElementPresentById(IWebDriver driver, string locatorValue)
        {
            ElementPresent(driver, "Id", locatorValue);
        }

        public static void IsElementPresentByXPath(IWebDriver driver, string locatorValue)
        {
            ElementPresent(driver, "XPath", locatorValue);
        }

        public static void IsElementPresentByCssSelector(IWebDriver driver, string locatorValue)
        {
            ElementPresent(driver, "CssSelector", locatorValue);
        }

        public static void ElementPresent(IWebDriver driver, string locator, string locatorValue)
        {

            try
            {
                if (locator == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorValue)));
                }
                if (locator == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorValue)));
                }
                if (locator == "CssSelector")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorValue)));
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed waiting for an webelement", ex.Message);
            }
        }

        // generic method to wait until ElementIsVisible
        public static void ElementIsVisible(IWebDriver driver, string locator, string locatorValue)
        {
            try
            {
                if (locator == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
                }
                if (locator == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
                }
                if (locator == "CssSelector")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed waiting for an webelement", ex.Message);
            }
        }



    }
}
