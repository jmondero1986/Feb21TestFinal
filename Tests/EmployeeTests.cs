using System;
using System.Threading;
using Feb21Testing.Pages;
using Feb21Testing.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Feb21Testing

{
    [TestFixture]
    class EmployeeTests : CommonDriver
    {
       
        [OneTimeSetUp]
        public void Login()
        {


            //log in page obj and log in steps
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);


            //homepage and navigate steps

            HomePage homeObj = new HomePage();
            homeObj.NavigateToEmployee(driver);
        }

        [Test]
         public void CreateEmpTest()
        {

            //TM object and create step 

            Employee createEmpObj = new Employee();
            createEmpObj.CreateEmp(driver);

        }

        [Test]
        public void EditEmpTest()
        {

            //TM object and edit step

            Employee editEmpObj = new Employee();
            editEmpObj.EditEmp(driver);
            

        }

        [Test]
        public void DeleteEmpTest()
        {
            //TM object and delete step 

            Employee deleteEmpObj = new Employee();
            deleteEmpObj.DeleteEmp(driver);
        }

        [OneTimeTearDown]
        public void FinalSteps()
        {

            //driver.Quit();
        }



    }
}
