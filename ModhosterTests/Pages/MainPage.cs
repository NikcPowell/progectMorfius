using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace ModhosterTests.Pages
{
    class MainPage : AbstractPage
    {
        private const string BASE_URL = "https://www.modhoster.com/";

        

        [FindsBy(How = How.CssSelector, Using = "#register_now")]
        private IWebElement buttonEnter;

        [FindsBy(How = How.Name, Using = "session[email]")]
        private IWebElement inputLogin;

        [FindsBy(How = How.Name, Using = "session[password]")]
        private IWebElement inputPassword;


        [FindsBy(How = How.Name, Using = "button")]
        private IWebElement buttonSubmit;

        [FindsBy(How = How.CssSelector, Using = "li.gameversion:nth-child(2) > a:nth-child(1)")]
        private IWebElement button2017;

        [FindsBy(How = How.CssSelector, Using = "li.white:nth-child(11) > a:nth-child(2)")]
        private IWebElement buttonexit;

        [FindsBy(How = How.CssSelector, Using = "li.game:nth-child(6) > a:nth-child(1)")]
        private IWebElement buttonEurotrk;

        [FindsBy(How = How.CssSelector, Using = "#main-navigation > div:nth-child(2) > span:nth-child(1)")]
        private IWebElement buttonCategory;
        [FindsBy(How = How.CssSelector, Using = "div.visible:nth-child(3) > div:nth-child(1) > a:nth-child(2)")]
        private IWebElement buttonImpl_tools;

        [FindsBy(How = How.CssSelector, Using = ".sprites-de")]
        private IWebElement buttonDeutch;

        [FindsBy(How = How.CssSelector, Using = "#account > ul:nth-child(1) > li:nth-child(5) > a:nth-child(2)")]
        private IWebElement buttoneditprof;

        [FindsBy(How = How.CssSelector, Using = "#user_password")]
        private IWebElement userpasschang;

        [FindsBy(How = How.Name, Using = "user[password_confirmation]")]
        private IWebElement userpassrepeat;

        [FindsBy(How = How.Name, Using = "commit")]
        private IWebElement buttoncommit;

        [FindsBy(How = How.CssSelector, Using = "li.grid-item:nth-child(1) > a:nth-child(13) > h3:nth-child(1) > span:nth-child(1)")]
        private IWebElement buttonselectmod;
        [FindsBy(How = How.CssSelector, Using = "a.compact:nth-child(1)")]
        private IWebElement buttondownload;
        [FindsBy(How = How.CssSelector, Using = "div.star:nth-child(2) > i:nth-child(4)")]
        private IWebElement buttonrate;

        [FindsBy(How = How.CssSelector, Using = "i.grid:nth-child(3)")]
        private IWebElement buttongrid;

        [FindsBy(How = How.CssSelector, Using = "div.link:nth-child(5) > span:nth-child(1)")]
        private IWebElement buttonwip;

        [FindsBy(How = How.CssSelector, Using = "div.visible:nth-child(3) > a:nth-child(3)")]
        private IWebElement buttonshow;

        [FindsBy(How = How.CssSelector, Using = ".prompt")]
        private IWebElement search;
        
        public MainPage(IWebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements(this.driver, this);
        }

        public override void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            
        }

        public void Login(string username, string password)
        {
            
            inputLogin.SendKeys(username);
            inputPassword.SendKeys(password);
            buttonSubmit.Click();            
            System.Threading.Thread.Sleep(1000);
        }
        public void LogOff()
        {
            
            buttonexit.Click();
        }

      
        public void mod2017()
        {

            button2017.Click();
        }
        public void modEurotruck()
        {

            buttonEurotrk.Click();
        }

        public void Category()
        {

            buttonCategory.Click();
            buttonImpl_tools.Click();
        }
        public void Deutch_english()
        {

            buttonDeutch.Click();
          
        }
        public void editprof(string pass, string repeatpass)
        {

            buttoneditprof.Click();
            userpasschang.SendKeys(pass);
            userpassrepeat.SendKeys(repeatpass);
            buttoncommit.Click();
            System.Threading.Thread.Sleep(1000);

        }
        public void moddownload()
        {

            buttonselectmod.Click();
            buttondownload.Click();

        }
        public void modrate()
        {

            buttonselectmod.Click();
            buttonrate.Click();

        }
        public void modgrid()
        {

            buttongrid.Click();

            System.Threading.Thread.Sleep(1000);
        }
       
        public void vipmods()
        {

            buttonwip.Click();
            buttonshow.Click();


        }
        public void searchclaas(string claas)
        {

            search.SendKeys(claas);
            search.Submit();

            System.Threading.Thread.Sleep(10000);
        }
    }
}
