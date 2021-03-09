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
    class TimeAndMaterialTests : CommonDriver
    {
        

        [OneTimeSetUp]
        public void Login()
        {
            

            //log in page obj and log in steps
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);


            //homepage and navigate steps

            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);
        }

        [Test]
        public void CreateTmTest()
        {

            //TM object and create step 

            TMPage tmObj = new TMPage();
            tmObj.CreateTM(driver);

        }

        [Test]
        public void EditTMTest()
        {

            //TM object and edit step

            TMPage editObj = new TMPage();
            editObj.EditTM(driver);

        }

        [Test]
        public void DeleteTMTest()
        {
            //TM object and delete step 

            TMPage deleteObj = new TMPage();
            deleteObj.DeleteTM(driver);
        }    

        [OneTimeTearDown]
        public void FinalSteps()
        {

            driver.Quit();
        }


        
    }
}
