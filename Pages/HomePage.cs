using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Feb21Testing.Pages
{
    class HomePage

    {

        public void NavigateToTM(IWebDriver driver)
        {
            //Enable Administration Button
            Thread.Sleep(500);
            IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationButton.Click();

            //Enable Time and Material Button
            Thread.Sleep(1000);
            IWebElement timematerialButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timematerialButton.Click();
        }

        public void NavigateToEmployee(IWebDriver driver)
        {
            Thread.Sleep(500);
            IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationButton.Click();

            //Enable Empdloyee Button
            Thread.Sleep(1000);
            IWebElement employeeButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeeButton.Click();
        }
    }
}
