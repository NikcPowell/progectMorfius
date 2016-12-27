using System;
using OpenQA.Selenium;

namespace ModhosterTests.Steps
{
    class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

       

        public void LoginModhoster(string username, string password)
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.Login(username, password);

        }

        public void LogOffModhoster()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.LogOff();
        }

        
        public void Mod2017Modhoster()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.mod2017();
        }
        public void ModEurotruckModhoster()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.modEurotruck();
        }
        public void CatgoryImplModhoster()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.Category();
        }
        public void DeutchModhoster()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.Deutch_english();
        }
        public void editpassModhoster(string username, string password, string pass, string repeatpass)
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.Login(username, password);
            mainPage.editprof(pass, repeatpass);
        }
        public void downloadModhoster()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.moddownload();
         
        }
        public void rateModhoster()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.modrate();

        }
        public void gridModhoster()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.modgrid();

        }
        public void vipModhoster()
        {

            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
           
            mainPage.vipmods();

        }
        public void searchModhoster(string claas)
        {

            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();

            mainPage.searchclaas(claas);

        }
    }
}
