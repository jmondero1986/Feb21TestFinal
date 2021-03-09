using Feb21Testing.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Feb21Testing.Pages
{
    class TMPage
    {

        public void CreateTM(IWebDriver driver)
        {

            //Enable Create New Button

            IWebElement createnewButton = driver.FindElement(By.XPath("/html/body/div[4]/p/a"));
            createnewButton.Click();
            Wait.ElementPresent(driver,"//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span");
            //Enable TypeCode Button

            IWebElement typecodeMaButton = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span"));
            typecodeMaButton.Click();
            Thread.Sleep(500);

            IWebElement typecodeTiButton = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            typecodeTiButton.Click();
            Thread.Sleep(500);


            //Identify Code Textbox
            IWebElement codeTxtbox = driver.FindElement(By.Id("Code"));
            codeTxtbox.SendKeys("Feb21");


            //Identify Description Textbox 
            IWebElement descriptionTxtbox = driver.FindElement(By.Id("Description"));
            descriptionTxtbox.SendKeys("Feb21Test");

            //Identify Price per unit Textbox

            IWebElement pricepunitTxtbox1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
            pricepunitTxtbox1.Click();

            IWebElement pricepunitTxtbox = driver.FindElement(By.Id("Price"));
            pricepunitTxtbox.SendKeys("123000");

            //Identify Select Files Button

            //IWebElement selectFilesButton = driver.FindElement(By.Id("files"));
            //selectFilesButton.Click();
            //Thread.Sleep(1500);

            //Identify Save Button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1500);

            //Identify Back to List

            IWebElement bktolistButton = driver.FindElement(By.Id("container"));
            bktolistButton.Click();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/TimeMaterial");
            Thread.Sleep(1000);

            //Pagination Last page

            IWebElement pagenationButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            pagenationButton.Click();
            Thread.Sleep(1000);

            //validation of last page/if record is created

            //option1

             Assert.That (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text =="Feb21");

            //option2

            

            



        }

        public void EditTM(IWebDriver driver)
        {

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/TimeMaterial");
            Thread.Sleep(1000);

            //identify Edit Button

            IWebElement gridEditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]"));
            gridEditButton.Click();
            Thread.Sleep(1500);

            //Identify TypeCode Dropdown button

            IWebElement edittypecodeButton = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            edittypecodeButton.Click();
            Thread.Sleep(1500);

           
            //Identify Edit Code textbox
            IWebElement editcodeTxtbox = driver.FindElement(By.Id("Code"));
            editcodeTxtbox.SendKeys("");

            //Identify Edit Description textbox
            IWebElement editDescriptionTxtbox = driver.FindElement(By.Id("Description"));
            editDescriptionTxtbox.SendKeys("");

            //Identify Edit Price per unit Textbox
            IWebElement editpriceTxtbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
            editpriceTxtbox.Click();

            IWebElement editpriceTxtbox1 = driver.FindElement(By.Id("Price"));
            editpriceTxtbox1.SendKeys("123");


            ////Identify Select Files button
            //IWebElement selectfileButton = driver.FindElement(By.Id("TimeMaterialEditForm"));
            //selectfileButton.SendKeys(@"//should put file ex:.jpg, .doc");

            ////Identify Download file button
            //IWebElement editDownloadButton = driver.FindElement(By.XPath("downloadButton"));
            //editDownloadButton.Click();

            //Identify Save Button
            IWebElement editsaveButton = driver.FindElement(By.Id("SaveButton"));
            editsaveButton.Click();
            Thread.Sleep(1500);

            //Identify Back to List

            IWebElement bktolistButton1 = driver.FindElement(By.Id("container"));
            bktolistButton1.Click();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/TimeMaterial");
            Thread.Sleep(1000);


        }


        public void DeleteTM(IWebDriver driver)
        {

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/TimeMaterial");
            Thread.Sleep(1000);

            //identify Delete button

            IWebElement gridDeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[2]"));
            gridDeleteButton.Click();
            Thread.Sleep(1000);

            //Confirmation to Delete record (ACCEPTANCE/OK)

            var alertMessage = driver.SwitchTo().Alert().Text;

            if (alertMessage != "Are you sure you want to delete this record?")
            {

                Console.WriteLine("Test Failed");
            }
            else
            {
                Console.WriteLine("Test Accept");
            }

            driver.SwitchTo().Alert().Accept();


            Thread.Sleep(1500);


            //Confirmation to Delete record (CANCEL)

            IWebElement gridDeleteButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[2]"));
            gridDeleteButton1.Click();
            Thread.Sleep(1500);

            //Confirmation to Delete record (ACCEPTANCE/OK)

            var alertMessage1 = driver.SwitchTo().Alert().Text;

            if (alertMessage1 != "Are you sure you want to delete this record?")
            {

                Console.WriteLine("Test Failed");
            }
            else
            {
                Console.WriteLine("Test Accept");
            }

            driver.SwitchTo().Alert().Dismiss();

        }


    }

}
