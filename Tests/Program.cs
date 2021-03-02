using System;
using System.Threading;
using Feb21Testing.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Feb21Testing

{
    class Program
    {
        static void Main(string[] args)
        {

            //intiate and define web driver
            IWebDriver driver = new ChromeDriver(@"D:\");

            //log in page obj and log in steps
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);

            //homepage and navigate steps

            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);


            //TM object and create step 

            TMPage tmObj = new TMPage();
            tmObj.CreateTM(driver);

            //TM object and edit step

            TMPage editObj = new TMPage();
            editObj.EditTM(driver);


            //TM object and delete step 

            TMPage deleteObj = new TMPage();
            deleteObj.DeleteTM(driver);





        }
    }
}
