using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;


namespace Feb21Testing.Pages
{
    class Employee
    {

        public void CreateEmp(IWebDriver driver)
        {

            //NEEDS TO CHECK FOR ERRORS!!!!//


            //Enable Create New Button

            IWebElement createnewEmpButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createnewEmpButton.Click();
            Thread.Sleep(500);
            //Enable Employee Name Textbox

            IWebElement EmpNameTxtbox = driver.FindElement(By.Id("Name"));
            EmpNameTxtbox.SendKeys("Julie MM");
            Thread.Sleep(500);

            //Enable Username Textbox
            IWebElement usernameTxtbox = driver.FindElement(By.Id("Username"));
            usernameTxtbox.SendKeys("JulieM86");
            Thread.Sleep(500);


            //Identify Contact Textbox
            //IWebElement ContactTxtbox = driver.FindElement(By.Id("ContactDisplay"));
            //ContactTxtbox.SendKeys("");
            //ContactTxtbox.Click();
            //Thread.Sleep(1500);

            //Identify Edit Contact Button

            IWebElement contactButton = driver.FindElement(By.Id("EditContactButton"));
            contactButton.Click();
            Thread.Sleep(1000);

            ////***************EDIT CONTACT *******************

            //IWebElement firstNameTxtbox = driver.FindElement(By.Id("FirstName"));//*[@id="FirstName"]
            //firstNameTxtbox.SendKeys("");
            //Thread.Sleep(500);

            //IWebElement lastNameTxtbox = driver.FindElement(By.Id("LastName"));
            //lastNameTxtbox.SendKeys("");
            //Thread.Sleep(500);

            //IWebElement preferedNameTxtbox = driver.FindElement(By.Id("PreferedName"));
            //preferedNameTxtbox.SendKeys("");
            //Thread.Sleep(500);

            //IWebElement phoneTxtbox = driver.FindElement(By.Id("Phone"));
            //phoneTxtbox.SendKeys("012345");
            //Thread.Sleep(500);

            //IWebElement mobileTxtbox = driver.FindElement(By.Id("Mobile"));
            //mobileTxtbox.SendKeys("23456789");
            //Thread.Sleep(500);

            //IWebElement emailTxtbox = driver.FindElement(By.Id("email"));
            //emailTxtbox.SendKeys("jmmmsfdf@gmail.com");
            //Thread.Sleep(500);

            //IWebElement faxTxtbox = driver.FindElement(By.Id("Fax"));
            //faxTxtbox.SendKeys("example fax");
            //Thread.Sleep(500);


            //IWebElement addressTxtbox = driver.FindElement(By.Id("autocomplete"));
            //addressTxtbox.SendKeys("");
            //Thread.Sleep(500);

            //IWebElement streetTxtbox = driver.FindElement(By.Id("Street"));
            //streetTxtbox.SendKeys("cockayne crescent");
            //Thread.Sleep(500);

            //IWebElement cityTxtbox = driver.FindElement(By.Id("City"));
            //cityTxtbox.SendKeys("Auckland ");
            //Thread.Sleep(500);

            //IWebElement postcodeTxtbox = driver.FindElement(By.Id("Postcode"));
            //postcodeTxtbox.SendKeys("0620");
            //Thread.Sleep(500);

            //IWebElement countryTxtbox = driver.FindElement(By.Id("Country"));
            //countryTxtbox.SendKeys("New Zealand");
            //Thread.Sleep(500);

            //IWebElement saveContactButton = driver.FindElement(By.Id("submitButton"));
            //saveContactButton.Click();
            //Thread.Sleep(1500);

           

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/User/Create");
            Thread.Sleep(1000);

            //**************END EDIT CONTACT*****************

            //Identify Password Textbox 
            IWebElement passwordTxtbox = driver.FindElement(By.Id("Password"));
            passwordTxtbox.SendKeys("111111111111");
            Thread.Sleep(1000);

            //Identify Re-type Password Textbox

            IWebElement retypePswdTxtbox = driver.FindElement(By.Id("RetypePassword"));
            retypePswdTxtbox.SendKeys("111111111111");
            Thread.Sleep(1000);


            //Identify IsAdmin Checkbox

            IWebElement isAdminCheckbox = driver.FindElement(By.XPath("//*[@id='IsAdmin']"));
            isAdminCheckbox.Click();
            Thread.Sleep(1000);

          

            //Identify Vehicle Dropdown

            IWebElement vehicle = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            vehicle.Click();
            Thread.Sleep(1000);

            //Identify Groups Textbox

            IWebElement groupTxtbox = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]"));
            groupTxtbox.Click();
            Thread.Sleep(1000);


            //Identify Save Button
            IWebElement empsaveButton = driver.FindElement(By.Id("SaveButton"));
            empsaveButton.Click();
            Thread.Sleep(1500);

            //Identify Back to List

           
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/User");
            Thread.Sleep(1000);

            //Pagination Last page

            IWebElement pagenationButton = driver.FindElement(By.XPath("//*[@id=usersGrid]/div[4]/a[4]/span"));
            pagenationButton.Click();
            Thread.Sleep(1000);

            //validation of last page/if record is created

            var lastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            
            if (lastPage.Text == "Julie MM")

            {
                Console.WriteLine("Test passed, time record created");
            }

            else
            {
                Console.WriteLine("Test failed, time record failed");
            }



        }

        public void EditEmp(IWebDriver driver)
        {

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/User");
            Thread.Sleep(1500);

            //identify Edit Button

            IWebElement editEmpButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[1]/td[3]/a[1]"));
            editEmpButton.Click();
            Thread.Sleep(1500);

            //Identify Employee Name Textbox

            IWebElement nameTxtbox = driver.FindElement(By.Id("Name"));
            nameTxtbox.SendKeys("");
            Thread.Sleep(1500);

            IWebElement usernameTxtbox = driver.FindElement(By.Id("Username"));
            usernameTxtbox.SendKeys("");
            Thread.Sleep(1500);

            //Identify Contact textbox
            //IWebElement contactTxtbox = driver.FindElement(By.Id("ContactDisplay")); //*[@id="ContactDisplay"]
            //contactTxtbox.SendKeys("");
            //Thread.Sleep(1000);

            //Identify Edit Contact Button

            IWebElement editContactButton = driver.FindElement(By.Id("EditContactButton"));
            editContactButton.Click();
            Thread.Sleep(1000);

            //***************EDIT CONTACT *******************

            //IWebElement firstNameTxtbox = driver.FindElement(By.Id("FirstName"));
            //firstNameTxtbox.SendKeys("Julie Ann");
            //Thread.Sleep(500);

            //IWebElement lastNameTxtbox = driver.FindElement(By.Id("LastName"));
            //lastNameTxtbox.SendKeys("Mondero");
            //Thread.Sleep(500);

            //IWebElement preferedNameTxtbox = driver.FindElement(By.Id("PreferedName"));
            //preferedNameTxtbox.SendKeys("Julie");
            //Thread.Sleep(500);

            //IWebElement phoneTxtbox = driver.FindElement(By.Id("Phone"));
            //phoneTxtbox.SendKeys("012345");
            //Thread.Sleep(500);

            //IWebElement mobileTxtbox = driver.FindElement(By.Id("Mobile"));
            //mobileTxtbox.SendKeys("23456789");
            //Thread.Sleep(500);

            //IWebElement emailTxtbox = driver.FindElement(By.Id("email"));
            //emailTxtbox.SendKeys("jmmmsfdf@gmail.com");
            //Thread.Sleep(500);

            //IWebElement faxTxtbox = driver.FindElement(By.Id("Fax"));
            //faxTxtbox.SendKeys("example fax");
            //Thread.Sleep(500);


            //IWebElement addressTxtbox = driver.FindElement(By.Id("autocomplete"));
            //addressTxtbox.SendKeys("");
            //Thread.Sleep(500);

            //IWebElement streetTxtbox = driver.FindElement(By.Id("Street"));
            //streetTxtbox.SendKeys("cockayne crescent");
            //Thread.Sleep(500);

            //IWebElement cityTxtbox = driver.FindElement(By.Id("City"));
            //cityTxtbox.SendKeys("Auckland ");
            //Thread.Sleep(500);

            //IWebElement postcodeTxtbox = driver.FindElement(By.Id("Postcode"));
            //postcodeTxtbox.SendKeys("0620");
            //Thread.Sleep(500);

            //IWebElement countryTxtbox = driver.FindElement(By.Id("Country"));
            //countryTxtbox.SendKeys("New Zealand");
            //Thread.Sleep(500);

            //IWebElement saveContactButton = driver.FindElement(By.Id("submitButton"));
            //saveContactButton.Click();
            //Thread.Sleep(500);

            //**************END EDIT CONTACT*****************


            //Identify Password textbox
            IWebElement passwordTxtbox1 = driver.FindElement(By.Id("Password"));//*[@id="Password"]
            passwordTxtbox1.SendKeys("");
            Thread.Sleep(1000);

            //Identify Retype PasswordTextbox
            IWebElement retypePswdTxtbox = driver.FindElement(By.XPath("RetypePassword"));
            retypePswdTxtbox.SendKeys("");
            Thread.Sleep(1000);



            //Identify IsAdmin Checkbox

            IWebElement isAdminCheckbox = driver.FindElement(By.Id("IsAdmin"));
            isAdminCheckbox.Click();
            Thread.Sleep(1000);

            //Identify Vehicle Dropdown

            IWebElement vehicle = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            vehicle.Click();
            Thread.Sleep(1000);

            //Identify Groups Textbox

            IWebElement groupTxtbox = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]"));
            groupTxtbox.Click();
            Thread.Sleep(1000);


            //Identify Save Button
            IWebElement empsaveButton = driver.FindElement(By.Id("SaveButton"));
            empsaveButton.Click();
            Thread.Sleep(1500);

            //Identify Back to List

            
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/User");
            Thread.Sleep(1000);


        }


        public void DeleteEmp(IWebDriver driver)
        {

            //identify Delete button

            IWebElement empDeleteButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[1]/td[3]/a[2]"));
            empDeleteButton.Click();
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

            IWebElement empDeleteButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[2]"));
            empDeleteButton1.Click();
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
